<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditArticle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditArticle))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtcb = New Al_Mohasib.TxtBox()
        Me.btgenir = New System.Windows.Forms.Button()
        Me.btprint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbctg = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMohassinDBDataSet = New Al_Mohasib.ALMohassinDBDataSet()
        Me.btprdimg = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprdname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PBprd = New System.Windows.Forms.PictureBox()
        Me.btprd = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCatHammam = New Al_Mohasib.TxtBox()
        Me.PlPrice = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtprice2 = New Al_Mohasib.TxtBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtprice3 = New Al_Mohasib.TxtBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbprice = New Al_Mohasib.TxtBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsprice = New Al_Mohasib.TxtBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbDetails = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbGrp = New System.Windows.Forms.ComboBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbchangeimg = New System.Windows.Forms.Label()
        Me.CBdp = New System.Windows.Forms.ComboBox()
        Me.DepotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New Al_Mohasib.ALMohassinDBDataSetTableAdapters.CategoryTableAdapter()
        Me.DepotTableAdapter = New Al_Mohasib.ALMohassinDBDataSetTableAdapters.DepotTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMohassinDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PlPrice.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DepotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtcb)
        Me.Panel4.Controls.Add(Me.btgenir)
        Me.Panel4.Controls.Add(Me.btprint)
        Me.Panel4.Location = New System.Drawing.Point(83, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(557, 43)
        Me.Panel4.TabIndex = 24
        '
        'txtcb
        '
        Me.txtcb.BackColor = System.Drawing.Color.White
        Me.txtcb.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtcb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcb.IsNumiric = False
        Me.txtcb.Location = New System.Drawing.Point(0, 0)
        Me.txtcb.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtcb.Name = "txtcb"
        Me.txtcb.ShowClearIcon = False
        Me.txtcb.ShowSaveIcon = False
        Me.txtcb.Size = New System.Drawing.Size(429, 41)
        Me.txtcb.StartUp = 2
        Me.txtcb.TabIndex = 26
        Me.txtcb.TextSize = 8
        Me.txtcb.TxtBackColor = True
        Me.txtcb.TxtColor = System.Drawing.Color.White
        Me.txtcb.txtReadOnly = False
        Me.txtcb.TxtSelect = New Integer() {1, 0}
        '
        'btgenir
        '
        Me.btgenir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btgenir.BackgroundImage = Global.Al_Mohasib.My.Resources.Resources.MENU_20
        Me.btgenir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btgenir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btgenir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btgenir.Location = New System.Drawing.Point(429, 0)
        Me.btgenir.Name = "btgenir"
        Me.btgenir.Size = New System.Drawing.Size(66, 41)
        Me.btgenir.TabIndex = 6
        Me.btgenir.UseVisualStyleBackColor = False
        '
        'btprint
        '
        Me.btprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btprint.BackgroundImage = Global.Al_Mohasib.My.Resources.Resources.Print_22X221
        Me.btprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btprint.Location = New System.Drawing.Point(495, 0)
        Me.btprint.Name = "btprint"
        Me.btprint.Size = New System.Drawing.Size(60, 41)
        Me.btprint.TabIndex = 5
        Me.btprint.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Réf."
        '
        'cbctg
        '
        Me.cbctg.DataSource = Me.CategoryBindingSource
        Me.cbctg.DisplayMember = "name"
        Me.cbctg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbctg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbctg.FormattingEnabled = True
        Me.cbctg.Location = New System.Drawing.Point(95, 164)
        Me.cbctg.Name = "cbctg"
        Me.cbctg.Size = New System.Drawing.Size(206, 28)
        Me.cbctg.TabIndex = 17
        Me.cbctg.ValueMember = "cid"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.ALMohassinDBDataSet
        '
        'ALMohassinDBDataSet
        '
        Me.ALMohassinDBDataSet.DataSetName = "ALMohassinDBDataSet"
        Me.ALMohassinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btprdimg
        '
        Me.btprdimg.Location = New System.Drawing.Point(407, 244)
        Me.btprdimg.Name = "btprdimg"
        Me.btprdimg.Size = New System.Drawing.Size(245, 36)
        Me.btprdimg.TabIndex = 21
        Me.btprdimg.Text = "Choisir une image *** اختر الصورة"
        Me.btprdimg.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Prix de Vente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Prix d'Achat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Groupe"
        '
        'txtprdname
        '
        Me.txtprdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprdname.Location = New System.Drawing.Point(82, 82)
        Me.txtprdname.Name = "txtprdname"
        Me.txtprdname.Size = New System.Drawing.Size(220, 20)
        Me.txtprdname.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nom"
        '
        'PBprd
        '
        Me.PBprd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBprd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBprd.Location = New System.Drawing.Point(407, 82)
        Me.PBprd.Name = "PBprd"
        Me.PBprd.Size = New System.Drawing.Size(245, 156)
        Me.PBprd.TabIndex = 11
        Me.PBprd.TabStop = False
        '
        'btprd
        '
        Me.btprd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btprd.FlatAppearance.BorderSize = 2
        Me.btprd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btprd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btprd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btprd.Image = CType(resources.GetObject("btprd.Image"), System.Drawing.Image)
        Me.btprd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btprd.Location = New System.Drawing.Point(469, 487)
        Me.btprd.Name = "btprd"
        Me.btprd.Size = New System.Drawing.Size(183, 50)
        Me.btprd.TabIndex = 22
        Me.btprd.Text = "Valider"
        Me.btprd.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(356, 502)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 35)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Annuler"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCatHammam)
        Me.GroupBox1.Controls.Add(Me.PlPrice)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CBdp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbDetails)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btprdimg)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CbGrp)
        Me.GroupBox1.Controls.Add(Me.cbctg)
        Me.GroupBox1.Controls.Add(Me.txtDetails)
        Me.GroupBox1.Controls.Add(Me.txtprdname)
        Me.GroupBox1.Controls.Add(Me.PBprd)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 481)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'txtCatHammam
        '
        Me.txtCatHammam.BackColor = System.Drawing.Color.White
        Me.txtCatHammam.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtCatHammam.IsNumiric = False
        Me.txtCatHammam.Location = New System.Drawing.Point(110, 198)
        Me.txtCatHammam.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtCatHammam.Name = "txtCatHammam"
        Me.txtCatHammam.ShowClearIcon = False
        Me.txtCatHammam.ShowSaveIcon = False
        Me.txtCatHammam.Size = New System.Drawing.Size(191, 30)
        Me.txtCatHammam.StartUp = 2
        Me.txtCatHammam.TabIndex = 26
        Me.txtCatHammam.TextSize = 8
        Me.txtCatHammam.TxtBackColor = True
        Me.txtCatHammam.TxtColor = System.Drawing.Color.White
        Me.txtCatHammam.txtReadOnly = False
        Me.txtCatHammam.TxtSelect = New Integer() {1, 0}
        '
        'PlPrice
        '
        Me.PlPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlPrice.Controls.Add(Me.Panel6)
        Me.PlPrice.Controls.Add(Me.Panel7)
        Me.PlPrice.Location = New System.Drawing.Point(386, 359)
        Me.PlPrice.Name = "PlPrice"
        Me.PlPrice.Size = New System.Drawing.Size(266, 116)
        Me.PlPrice.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Maroon
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtprice2)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Location = New System.Drawing.Point(3, 14)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(258, 42)
        Me.Panel6.TabIndex = 24
        '
        'txtprice2
        '
        Me.txtprice2.BackColor = System.Drawing.Color.White
        Me.txtprice2.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtprice2.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtprice2.IsNumiric = True
        Me.txtprice2.Location = New System.Drawing.Point(74, 0)
        Me.txtprice2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtprice2.Name = "txtprice2"
        Me.txtprice2.ShowClearIcon = False
        Me.txtprice2.ShowSaveIcon = False
        Me.txtprice2.Size = New System.Drawing.Size(139, 40)
        Me.txtprice2.StartUp = 2
        Me.txtprice2.TabIndex = 25
        Me.txtprice2.TextSize = 8
        Me.txtprice2.TxtBackColor = True
        Me.txtprice2.TxtColor = System.Drawing.Color.White
        Me.txtprice2.txtReadOnly = False
        Me.txtprice2.TxtSelect = New Integer() {1, 0}
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(213, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "TTC"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(12, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "ثمن البيـع"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(21, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Prix 2"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtprice3)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(3, 61)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(258, 42)
        Me.Panel7.TabIndex = 24
        '
        'txtprice3
        '
        Me.txtprice3.BackColor = System.Drawing.Color.White
        Me.txtprice3.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtprice3.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtprice3.IsNumiric = True
        Me.txtprice3.Location = New System.Drawing.Point(74, 0)
        Me.txtprice3.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtprice3.Name = "txtprice3"
        Me.txtprice3.ShowClearIcon = False
        Me.txtprice3.ShowSaveIcon = False
        Me.txtprice3.Size = New System.Drawing.Size(139, 40)
        Me.txtprice3.StartUp = 2
        Me.txtprice3.TabIndex = 26
        Me.txtprice3.TextSize = 8
        Me.txtprice3.TxtBackColor = True
        Me.txtprice3.TxtColor = System.Drawing.Color.White
        Me.txtprice3.txtReadOnly = False
        Me.txtprice3.TxtSelect = New Integer() {1, 0}
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(213, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 40)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "TTC"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(12, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "ثمن البيـع"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(22, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Prix3"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(27, 359)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 116)
        Me.Panel3.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtbprice)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(308, 42)
        Me.Panel2.TabIndex = 24
        '
        'txtbprice
        '
        Me.txtbprice.BackColor = System.Drawing.Color.White
        Me.txtbprice.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtbprice.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtbprice.IsNumiric = True
        Me.txtbprice.Location = New System.Drawing.Point(88, 0)
        Me.txtbprice.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtbprice.Name = "txtbprice"
        Me.txtbprice.ShowClearIcon = False
        Me.txtbprice.ShowSaveIcon = False
        Me.txtbprice.Size = New System.Drawing.Size(169, 40)
        Me.txtbprice.StartUp = 2
        Me.txtbprice.TabIndex = 25
        Me.txtbprice.TextSize = 8
        Me.txtbprice.TxtBackColor = True
        Me.txtbprice.TxtColor = System.Drawing.Color.White
        Me.txtbprice.txtReadOnly = False
        Me.txtbprice.TxtSelect = New Integer() {1, 0}
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(257, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 40)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "TTC"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(13, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "ثمــن الشراء"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtsprice)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 42)
        Me.Panel1.TabIndex = 24
        '
        'txtsprice
        '
        Me.txtsprice.BackColor = System.Drawing.Color.White
        Me.txtsprice.BorderColor = System.Drawing.SystemColors.ControlText
        Me.txtsprice.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtsprice.IsNumiric = True
        Me.txtsprice.Location = New System.Drawing.Point(88, 0)
        Me.txtsprice.MinimumSize = New System.Drawing.Size(0, 30)
        Me.txtsprice.Name = "txtsprice"
        Me.txtsprice.ShowClearIcon = False
        Me.txtsprice.ShowSaveIcon = False
        Me.txtsprice.Size = New System.Drawing.Size(169, 40)
        Me.txtsprice.StartUp = 2
        Me.txtsprice.TabIndex = 26
        Me.txtsprice.TextSize = 8
        Me.txtsprice.TxtBackColor = True
        Me.txtsprice.TxtColor = System.Drawing.Color.White
        Me.txtsprice.txtReadOnly = False
        Me.txtsprice.TxtSelect = New Integer() {1, 0}
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(257, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 40)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "TTC"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(18, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "ثمن البيـع"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(326, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "التصنيف"
        '
        'lbDetails
        '
        Me.lbDetails.AutoSize = True
        Me.lbDetails.Location = New System.Drawing.Point(36, 288)
        Me.lbDetails.Name = "lbDetails"
        Me.lbDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDetails.Size = New System.Drawing.Size(39, 13)
        Me.lbDetails.TabIndex = 13
        Me.lbDetails.Text = "Details"
        Me.lbDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbDetails.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cat :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(339, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "الاســم"
        '
        'CbGrp
        '
        Me.CbGrp.DisplayMember = "name"
        Me.CbGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbGrp.FormattingEnabled = True
        Me.CbGrp.Items.AddRange(New Object() {"Hammam Beldi", "Coiffure", "Tourki", "Produit"})
        Me.CbGrp.Location = New System.Drawing.Point(95, 121)
        Me.CbGrp.Name = "CbGrp"
        Me.CbGrp.Size = New System.Drawing.Size(208, 28)
        Me.CbGrp.TabIndex = 17
        Me.CbGrp.ValueMember = "cid"
        '
        'txtDetails
        '
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetails.Location = New System.Drawing.Point(31, 304)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(329, 49)
        Me.txtDetails.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 20)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "ctg"
        '
        'lbchangeimg
        '
        Me.lbchangeimg.AutoSize = True
        Me.lbchangeimg.Location = New System.Drawing.Point(184, 496)
        Me.lbchangeimg.Name = "lbchangeimg"
        Me.lbchangeimg.Size = New System.Drawing.Size(13, 13)
        Me.lbchangeimg.TabIndex = 7
        Me.lbchangeimg.Text = "0"
        Me.lbchangeimg.Visible = False
        '
        'CBdp
        '
        Me.CBdp.DataSource = Me.DepotBindingSource
        Me.CBdp.DisplayMember = "name"
        Me.CBdp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdp.FormattingEnabled = True
        Me.CBdp.Location = New System.Drawing.Point(94, 248)
        Me.CBdp.Name = "CBdp"
        Me.CBdp.Size = New System.Drawing.Size(209, 28)
        Me.CBdp.TabIndex = 17
        Me.CBdp.ValueMember = "dpid"
        '
        'DepotBindingSource
        '
        Me.DepotBindingSource.DataMember = "Depot"
        Me.DepotBindingSource.DataSource = Me.ALMohassinDBDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'DepotTableAdapter
        '
        Me.DepotTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(31, 495)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "الحفاظ على النافدة مفتوحة"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Depot :"
        '
        'AddEditArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 549)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btprd)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lbchangeimg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddEditArticle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Article Infos"
        Me.Panel4.ResumeLayout(False)
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMohassinDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PlPrice.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DepotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbctg As System.Windows.Forms.ComboBox
    Friend WithEvents PBprd As System.Windows.Forms.PictureBox
    Friend WithEvents btprdimg As System.Windows.Forms.Button
    Friend WithEvents btprd As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprdname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ALMohassinDBDataSet As Al_Mohasib.ALMohassinDBDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As Al_Mohasib.ALMohassinDBDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents DepotBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepotTableAdapter As Al_Mohasib.ALMohassinDBDataSetTableAdapters.DepotTableAdapter
    Friend WithEvents lbchangeimg As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CBdp As System.Windows.Forms.ComboBox
    Friend WithEvents btgenir As System.Windows.Forms.Button
    Friend WithEvents btprint As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtbprice As Al_Mohasib.TxtBox
    Friend WithEvents txtsprice As Al_Mohasib.TxtBox
    Friend WithEvents txtcb As Al_Mohasib.TxtBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PlPrice As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtprice2 As Al_Mohasib.TxtBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtprice3 As Al_Mohasib.TxtBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbGrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCatHammam As Al_Mohasib.TxtBox
    Friend WithEvents lbDetails As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
