<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnAddNew = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtTitle = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnRefresh = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Crimson
        Me.GunaLabel2.Location = New System.Drawing.Point(185, 19)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(127, 24)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "000WebHost"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.Gainsboro
        Me.GunaElipsePanel1.Controls.Add(Me.btnAddNew)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Controls.Add(Me.txtTitle)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(31, 59)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 8
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(437, 100)
        Me.GunaElipsePanel1.TabIndex = 6
        '
        'btnAddNew
        '
        Me.btnAddNew.AnimationHoverSpeed = 0.07!
        Me.btnAddNew.AnimationSpeed = 0.03!
        Me.btnAddNew.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNew.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNew.BorderColor = System.Drawing.Color.Black
        Me.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNew.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Image = Nothing
        Me.btnAddNew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddNew.Location = New System.Drawing.Point(295, 35)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddNew.OnHoverImage = Nothing
        Me.btnAddNew.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNew.Radius = 5
        Me.btnAddNew.Size = New System.Drawing.Size(89, 30)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(52, 43)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(29, 15)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Transparent
        Me.txtTitle.BaseColor = System.Drawing.Color.White
        Me.txtTitle.BorderColor = System.Drawing.Color.Silver
        Me.txtTitle.BorderSize = 1
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTitle.Location = New System.Drawing.Point(105, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.Radius = 5
        Me.txtTitle.Size = New System.Drawing.Size(160, 30)
        Me.txtTitle.TabIndex = 4
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.LightGray
        Me.GunaElipsePanel2.Controls.Add(Me.GunaDataGridView1)
        Me.GunaElipsePanel2.Controls.Add(Me.btnRefresh)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(31, 187)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 8
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(437, 240)
        Me.GunaElipsePanel2.TabIndex = 7
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(55, 64)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(329, 150)
        Me.GunaDataGridView1.TabIndex = 6
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 44
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Title"
        Me.Column2.Name = "Column2"
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.Width = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.AnimationHoverSpeed = 0.07!
        Me.btnRefresh.AnimationSpeed = 0.03!
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnRefresh.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRefresh.Location = New System.Drawing.Point(55, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.OnHoverBaseColor = System.Drawing.Color.Turquoise
        Me.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRefresh.OnHoverImage = Nothing
        Me.btnRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.btnRefresh.Radius = 5
        Me.btnRefresh.Size = New System.Drawing.Size(89, 30)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(452, 9)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(506, 450)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnAddNew As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtTitle As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnRefresh As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
