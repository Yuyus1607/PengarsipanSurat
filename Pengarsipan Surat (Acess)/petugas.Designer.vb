<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class petugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petugas))
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.id_pet = New System.Windows.Forms.TextBox
        Me.username = New System.Windows.Forms.TextBox
        Me.status = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.password = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.nm_dpn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nm_blkng = New System.Windows.Forms.TextBox
        Me.save = New System.Windows.Forms.Button
        Me.cancel = New System.Windows.Forms.Button
        Me.hapus = New System.Windows.Forms.Button
        Me.cari = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Keluar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.edit = New System.Windows.Forms.Button
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(6, 281)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(656, 131)
        Me.DGV.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id Petugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'id_pet
        '
        Me.id_pet.Location = New System.Drawing.Point(121, 25)
        Me.id_pet.Name = "id_pet"
        Me.id_pet.Size = New System.Drawing.Size(187, 22)
        Me.id_pet.TabIndex = 3
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(424, 25)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(190, 22)
        Me.username.TabIndex = 4
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(424, 79)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(94, 24)
        Me.status.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.nm_blkng)
        Me.GroupBox1.Controls.Add(Me.nm_dpn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.id_pet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(6, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 120)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master User"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(424, 53)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(190, 22)
        Me.password.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nama Belakang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nama Depan"
        '
        'nm_dpn
        '
        Me.nm_dpn.Location = New System.Drawing.Point(121, 53)
        Me.nm_dpn.Name = "nm_dpn"
        Me.nm_dpn.Size = New System.Drawing.Size(187, 22)
        Me.nm_dpn.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Chocolate
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 27)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Petugas"
        '
        'nm_blkng
        '
        Me.nm_blkng.Location = New System.Drawing.Point(121, 81)
        Me.nm_blkng.Name = "nm_blkng"
        Me.nm_blkng.Size = New System.Drawing.Size(187, 22)
        Me.nm_blkng.TabIndex = 10
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.SaddleBrown
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save.Location = New System.Drawing.Point(3, 16)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 52)
        Me.save.TabIndex = 0
        Me.save.Text = "Simpan"
        Me.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.Location = New System.Drawing.Point(164, 16)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 52)
        Me.cancel.TabIndex = 1
        Me.cancel.Text = "Batal"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.UseVisualStyleBackColor = False
        '
        'hapus
        '
        Me.hapus.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapus.ForeColor = System.Drawing.Color.SaddleBrown
        Me.hapus.Image = CType(resources.GetObject("hapus.Image"), System.Drawing.Image)
        Me.hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hapus.Location = New System.Drawing.Point(236, 16)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(83, 52)
        Me.hapus.TabIndex = 3
        Me.hapus.Text = "Hapus"
        Me.hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.hapus.UseVisualStyleBackColor = False
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(405, 74)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(234, 22)
        Me.cari.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(369, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 16)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Cari"
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Keluar.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Keluar.Location = New System.Drawing.Point(550, 16)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(89, 52)
        Me.Keluar.TabIndex = 7
        Me.Keluar.Text = "Keluar"
        Me.Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.edit)
        Me.GroupBox2.Controls.Add(Me.Keluar)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cari)
        Me.GroupBox2.Controls.Add(Me.hapus)
        Me.GroupBox2.Controls.Add(Me.cancel)
        Me.GroupBox2.Controls.Add(Me.save)
        Me.GroupBox2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox2.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 110)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.Location = New System.Drawing.Point(89, 16)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 52)
        Me.edit.TabIndex = 8
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.UseVisualStyleBackColor = False
        '
        'petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(674, 426)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "petugas"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_pet As System.Windows.Forms.TextBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nm_blkng As System.Windows.Forms.TextBox
    Friend WithEvents nm_dpn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents edit As System.Windows.Forms.Button
End Class
