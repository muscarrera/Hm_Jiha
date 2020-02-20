Imports System.IO

Public Class AddEditCat
    Private imgWithName, _imgPrd As Image

    Public Property ImgPrd As Image
        Get
            Return _imgPrd
        End Get
        Set(ByVal value As Image)
            Dim rnd As New Random
            If IsNothing(value) Then
                Dim BMG As New Bitmap(Form1.txtlongerbt.Text, Form1.txtlargebt.Text,
                                      Imaging.PixelFormat.Format24bppRgb)

                Dim GR As Graphics = Graphics.FromImage(BMG)
                GR.Clear(Color.White)
                GR.Clear(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)))
                _imgPrd = BMG
            Else
                _imgPrd = value
            End If

        End Set
    End Property
    Private Sub AddEditCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ALMohassinDBDataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.ALMohassinDBDataSet.Category)

    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        ImgPrd = Nothing
        TextBox1.Text = ""
        PBctg.BackgroundImage = Nothing
        PBctg.Tag = ""
        btcid.Tag = "0"
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If dgvctg.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("عند قيامكم على الضغط على 'موافق' سيتم حذف التصنيف المؤشر عليه من القائمة .. إضغط 'لا' لالغاء الحذف ", MsgBoxStyle.YesNo Or MessageBoxIcon.Exclamation, "حذف التصنيف") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim ta As New ALMohassinDBDataSetTableAdapters.CategoryTableAdapter
            ta.DeleteQuery(dgvctg.SelectedRows(0).Cells(0).Value)
            ta.Fill(ALMohassinDBDataSet.Category)
            ImgPrd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgvctg.SelectedRows.Count = 0 Then Exit Sub
        ImgPrd = Nothing

        TextBox1.Text = dgvctg.SelectedRows(0).Cells(1).Value
        TextBox1.Tag = dgvctg.SelectedRows(0).Cells(0).Value
        TextBox1.Text = dgvctg.SelectedRows(0).Cells(1).Value
        If dgvctg.SelectedRows(0).Cells(2).Value.ToString <> "" And dgvctg.SelectedRows(0).Cells(2).Value.ToString <> "No Image" Then
            Try
                Dim pmg3 As New Bitmap(Form1.BtImgPah.Tag.ToString & "\cat" & dgvctg.SelectedRows(0).Cells(2).Value.ToString)
                PBctg.Tag = dgvctg.SelectedRows(0).Cells(2).Value
                ImgPrd = pmg3

            Catch ex As Exception

            End Try
        End If
        PBctg.BackgroundImage = Drawimg(TextBox1.Text)
        btcid.Tag = "1"
        Panel1.Visible = True
    End Sub

    Private Sub btcid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcid.Click
        'validation
        ''empty field
        If TextBox1.Text.Trim = "" Then
            MsgBox("عذرا لا يمكن اتمام طلبكم.. المرجوا تعبئة الاسم", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
            TextBox1.Focus()
            Exit Sub
        End If

        If CInt(TextBox1.Tag) < 4 Then
            Try
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AlMohassib", "Cat_Ham_" & TextBox1.Tag, TextBox1.Text)
                TextBox1.Tag = 0
                btcid.Tag = 0
                TextBox1.Text = ""
                Panel1.Visible = False
                Exit Sub
            Catch ex As Exception

            End Try
        End If

        ' addddd
        If btcid.Tag = "0" Then
            ''check the name

            For i As Integer = 0 To dgvctg.Rows.Count - 1
                If TextBox1.Text = dgvctg.Rows(i).Cells(1).Value Then
                    MsgBox("عذرا لا يمكن اتمام طلبكم.. يجب عدم تكرار نفس الاسم", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
                    TextBox1.Focus()
                    dgvctg.Rows(i).Selected = True
                    dgvctg.FirstDisplayedScrollingRowIndex = dgvctg.Rows(i).Index
                    Exit Sub
                End If
            Next

            saveImage()

            Try
                Dim ta As New ALMohassinDBDataSetTableAdapters.CategoryTableAdapter
                ta.InsertQuery(TextBox1.Text, PBctg.Tag)
                ta.Fill(ALMohassinDBDataSet.Category)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'updateeee
        Else

            saveImage()
            Try
                Dim ta As New ALMohassinDBDataSetTableAdapters.CategoryTableAdapter
                ta.UpdateQuery(TextBox1.Text, PBctg.Tag, TextBox1.Tag)
                ta.Fill(ALMohassinDBDataSet.Category)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Panel1.Visible = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub btcimg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcimg.Click
        Dim savepic As New OpenFileDialog
        savepic.Filter = "*.jpg|*.jpg"
        If savepic.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim pmg2 As New Bitmap(savepic.FileName)
            PBctg.Tag = savepic.FileName
            ImgPrd = pmg2
            PBctg.BackgroundImage = Drawimg(TextBox1.Text)
        End If
    End Sub

    Public Function Drawimg(ByVal name As String) As Bitmap
        Dim fntSmall As New Font("Arial", 7)
        Dim fnt As New Font("Arial", 8, FontStyle.Bold)
        Dim ht As Integer = CInt(Form1.txtlargebt.Text)
        Dim wd As Integer = CInt(Form1.txtlongerbt.Text)
        'create the bitmap
        Dim BMG As New Bitmap(Form1.txtlongerbt.Text, Form1.txtlargebt.Text, Imaging.PixelFormat.Format24bppRgb)
        'ceate the graphic
        Dim GR As Graphics = Graphics.FromImage(BMG)
        GR.Clear(Color.White)

        'draw the lines
        Try
            If IsNothing(ImgPrd) Then ImgPrd = Nothing
            GR.DrawImage(ImgPrd, 0, 0, wd, ht)

            Dim sfC As New StringFormat()
            sfC.Alignment = StringAlignment.Center
            Dim size As SizeF = GR.MeasureString(name, fnt, wd)
            GR.FillRectangle(Brushes.White, 0, CInt(ht - size.Height), wd, CInt(size.Height + 5))
            GR.DrawString(name, fnt, Brushes.Black, New RectangleF(2, ht - size.Height, wd - 4, size.Height), sfC)
        Catch ex As Exception

        End Try

        imgWithName = BMG
        Return BMG
    End Function
    Private Sub saveImage()
        Dim dir1 As New DirectoryInfo(Form1.BtImgPah.Tag)
        If dir1.Exists = False Then dir1.Create()
        Try
            Dim str As String = TextBox1.Text
            str = str.Replace("/", "-")
            str = str.Replace("*", "-")

            Using img As Image = ImgPrd
                img.Save(Form1.BtImgPah.Tag & "\cat" & str & ".jpg", Imaging.ImageFormat.Jpeg)
            End Using
            Using img As Image = imgWithName
                img.Save(Form1.BtImgPah.Tag & "\P-cat" & str & ".jpg", Imaging.ImageFormat.Jpeg)
            End Using

            PBctg.Tag = str & ".jpg"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PBctg.BackgroundImage = Drawimg(TextBox1.Text)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click, Button36.Click, Button34.Click

        Try
            Dim bt As Button = sender

            TextBox1.Tag = bt.Tag

            Dim msg = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AlMohassib", "Cat_Ham_" & bt.Tag, Nothing)
              If msg = Nothing Then
                TextBox1.Text = ""
            Else
                TextBox1.Text = msg
            End If
        Catch ex As Exception
            TextBox1.Text = ""
        End Try

        Panel1.Visible = True
    End Sub
End Class