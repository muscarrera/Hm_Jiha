﻿Imports System.IO

Public Class Client

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ALMohassinDBDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.ALMohassinDBDataSet.Client)
        If Form1.admin = False Then
            DataGridView1.Columns(6).Visible = False
            btAllow.Visible = False
            btAllow2.Visible = False
            btAllow3.Visible = False

            txttp.Visible = False
            lbTp.Visible = False
        Else
            txttp.Visible = Form1.chbsell.Checked
            lbTp.Visible = Form1.chbsell.Checked
        End If

    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        btcancel_Click(Nothing, Nothing)
        If Form1.admin = False Then
            txtcrd.text = 1
            txtcrd.Visible = False
        End If

        GB1.Visible = True
    End Sub

    Private Sub btcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancel.Click
        txtname.text = ""
        txtname.Tag = ""
        txtcin.text = ""
        txtad.text = ""
        txttel.text = ""
        btcon.Tag = "0"
        GB1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        If Form1.admin = False Then txtcrd.Visible = False

        txtname.text = DataGridView1.SelectedRows(0).Cells(1).Value
        txtname.Tag = DataGridView1.SelectedRows(0).Cells(0).Value
        txtcin.text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        txtad.text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        txttel.text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString

        Dim tp As String = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
        If tp.Contains("|") Then
            txtcrd.text = tp.Split("|")(0)
            txttp.text = tp.Split("|")(1)
        Else
            txtcrd.text = tp
            txttp.text = 0
        End If

        btcon.Tag = "1"

        GB1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("عند قيامكم على الضغط على 'موافق' سيتم حذف الزبون  المؤشر عليها من القائمة .. إضغط  'لا'  لالغاء الحذف ", MsgBoxStyle.YesNo Or MessageBoxIcon.Exclamation, "حذف الزبون") = MsgBoxResult.No Then
            Exit Sub
        End If
        If DataGridView1.SelectedRows(0).Cells(5).Value > 0 Then
            'MsgBox("عذرا لا يمكن اتمام طلبكم.. هذا الزبون ما زال يتوفر على دين. المرجوا قضاء دينه اولا", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
            'Exit Sub
        End If
        Try
            Dim ta As New ALMohassinDBDataSetTableAdapters.ClientTableAdapter
            ta.DeleteQuery(DataGridView1.SelectedRows(0).Cells(0).Value)
            ta.Fill(ALMohassinDBDataSet.Client)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcon.Click

        'validation
        ''empty field
        If txtname.text.Trim = "" Then
            MsgBox("عذرا لا يمكن اتمام طلبكم.. المرجوا تعبئة الاسم", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
            txtname.Focus()
            Exit Sub
        End If

        If txtcrd.text.Trim = "" Or Not IsNumeric(txtcrd.text) Then txtcrd.text = 30
        If txttp.text.Trim = "" Or Not IsNumeric(txttp.text) Then txttp.text = 0

        Dim tp As String = txtcrd.text & "|" & txttp.text

        ' addddd
        If btcon.Tag = "0" Then
            ''check the name
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If txtname.text = DataGridView1.Rows(i).Cells(1).Value Then
                    MsgBox("عذرا لا يمكن اتمام طلبكم.. يجب عدم تكرار نفس الاسم", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
                    txtname.Focus()
                    DataGridView1.Rows(i).Selected = True
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.SelectedRows(0).Index
                    Exit Sub
                End If
            Next

            Try
                Dim ta As New ALMohassinDBDataSetTableAdapters.ClientTableAdapter
                ta.InsertQuery(txtname.text, txtcin.text, txtad.text, txttel.text, "0", CInt(txtcrd.text))
                ta.Fill(ALMohassinDBDataSet.Client)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'updateeee
        Else
            Try
                Dim ta As New ALMohassinDBDataSetTableAdapters.ClientTableAdapter
                ta.UpdateQuery(txtname.text, txtcin.text, txtad.text, txttel.text, tp, txtname.Tag)
                ta.Fill(ALMohassinDBDataSet.Client)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        btcancel_Click(Nothing, Nothing)
        GB1.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Value.ToString.Contains(txtsearch.Text) Then
                DataGridView1.Rows(i).Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(i).Index
                Exit For
            End If
            If DataGridView1.Rows(i).Cells(0).Value.ToString.Contains(txtsearch.Text) Then
                DataGridView1.Rows(i).Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(i).Index
                Exit For
            End If
        Next

    End Sub

    Private Sub txtsearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyUp
        Button5_Click(Nothing, Nothing)
    End Sub

    Private Sub btAllow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAllow.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Voulez-vous autoriser ce client ? ", MsgBoxStyle.YesNo Or MessageBoxIcon.Exclamation, "ترخيص الزبون") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim strpath As String = Form1.BtImgPah.Tag & "\AllowClient"
        If Not Directory.Exists(strpath) Then
            Directory.CreateDirectory(strpath)
            Exit Sub
        End If

        Dim cid As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim savePath As String = Path.Combine(strpath, cid & "-Allowed.dat")
        If System.IO.File.Exists(savePath) Then
        Else
            System.IO.File.Create(savePath)
        End If
    End Sub

    Private Sub txttp_TxtChanged() Handles txttp.TxtChanged
        Try
            If IsNumeric(txttp.text) Then
                txttp.text = CInt(txttp.text)
            Else
                txttp.text = ""
            End If
            If txttp.text > 3 Or txttp.text < 0 Then txttp.text = ""
        Catch ex As Exception
            txttp.text = ""
        End Try

    End Sub

    Private Sub btAllow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAllow2.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Voulez-vous donner l'autorisation illimité à ce client?", MsgBoxStyle.YesNo Or MessageBoxIcon.Exclamation, "ترخيص الزبون") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim strpath As String = Form1.BtImgPah.Tag & "\AllowClient"
        If Not Directory.Exists(strpath) Then
            Directory.CreateDirectory(strpath)
            Exit Sub
        End If

        Dim cid As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim savePath As String = Path.Combine(strpath, cid & "-Auth.dat")
        If System.IO.File.Exists(savePath) Then
        Else
            System.IO.File.Create(savePath)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAllow3.Click
        Dim strpath As String = Form1.BtImgPah.Tag & "\AllowClient"
        If Not Directory.Exists(strpath) Then
            Directory.CreateDirectory(strpath)
        End If
        Dim clid As String = DataGridView1.SelectedRows(0).Cells(0).Value

        Dim savePath As String = Path.Combine(strpath, clid & "-Allowed.dat")
        Dim savePath2 As String = Path.Combine(strpath, clid & "-Auth.dat")

        If System.IO.File.Exists(savePath) Then
            File.Delete(savePath)
        End If
        If System.IO.File.Exists(savePath2) Then
            File.Delete(savePath2)
        End If

        MsgBox("l'autorisation de ce client a bien supprimer")
    End Sub
End Class