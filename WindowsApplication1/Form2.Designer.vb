<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.QuảnLýToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'DanhSáchKháchHàngToolStripMenuItem
        '
        Me.DanhSáchKháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DanhSáchKháchHàngToolStripMenuItem.Name = "DanhSáchKháchHàngToolStripMenuItem"
        Me.DanhSáchKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DanhSáchKháchHàngToolStripMenuItem.Text = "Danh sách khách hàng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchSảnPhẩmToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'DanhSáchSảnPhẩmToolStripMenuItem
        '
        Me.DanhSáchSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Name = "DanhSáchSảnPhẩmToolStripMenuItem"
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Text = "Danh sách sản phẩm"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Hóa đơn"
        '
        'QuảnLýToolStripMenuItem1
        '
        Me.QuảnLýToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýKháchHàngToolStripMenuItem, Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem1.Name = "QuảnLýToolStripMenuItem1"
        Me.QuảnLýToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem1.Text = "Quản lý"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(490, 187)
        Me.DataGridView1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 247)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Quản lý"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
