﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Surat_Keluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Surat_Keluar))
        Me.pengirim = New System.Windows.Forms.TextBox
        Me.no_srt = New System.Windows.Forms.TextBox
        Me.batal = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.simpan = New System.Windows.Forms.Button
        Me.ket = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.jmlh = New System.Windows.Forms.TextBox
        Me.Keluar = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.cari = New System.Windows.Forms.TextBox
        Me.hapus = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.perihal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_jns = New System.Windows.Forms.ComboBox
        Me.tgl_kir = New System.Windows.Forms.DateTimePicker
        Me.no_agen = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pengirim
        '
        Me.pengirim.Location = New System.Drawing.Point(474, 55)
        Me.pengirim.Name = "pengirim"
        Me.pengirim.Size = New System.Drawing.Size(210, 22)
        Me.pengirim.TabIndex = 32
        '
        'no_srt
        '
        Me.no_srt.Location = New System.Drawing.Point(474, 27)
        Me.no_srt.Name = "no_srt"
        Me.no_srt.Size = New System.Drawing.Size(210, 22)
        Me.no_srt.TabIndex = 31
        '
        'batal
        '
        Me.batal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.batal.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batal.ForeColor = System.Drawing.Color.SaddleBrown
        Me.batal.Image = CType(resources.GetObject("batal.Image"), System.Drawing.Image)
        Me.batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.batal.Location = New System.Drawing.Point(88, 16)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(75, 52)
        Me.batal.TabIndex = 1
        Me.batal.Text = "Batal"
        Me.batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.batal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(287, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Surat Keluar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(457, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(457, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(457, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Pengirim"
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.simpan.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpan.ForeColor = System.Drawing.Color.SaddleBrown
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.Location = New System.Drawing.Point(3, 16)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(88, 52)
        Me.simpan.TabIndex = 0
        Me.simpan.Text = "Simpan"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.simpan.UseVisualStyleBackColor = False
        '
        'ket
        '
        Me.ket.Location = New System.Drawing.Point(130, 108)
        Me.ket.Name = "ket"
        Me.ket.Size = New System.Drawing.Size(210, 22)
        Me.ket.TabIndex = 36
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(113, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.jmlh)
        Me.GroupBox2.Controls.Add(Me.Keluar)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cari)
        Me.GroupBox2.Controls.Add(Me.hapus)
        Me.GroupBox2.Controls.Add(Me.edit)
        Me.GroupBox2.Controls.Add(Me.batal)
        Me.GroupBox2.Controls.Add(Me.simpan)
        Me.GroupBox2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox2.Location = New System.Drawing.Point(11, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 110)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Jumlah Surat Keluar"
        '
        'jmlh
        '
        Me.jmlh.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jmlh.Location = New System.Drawing.Point(133, 77)
        Me.jmlh.Name = "jmlh"
        Me.jmlh.Size = New System.Drawing.Size(87, 22)
        Me.jmlh.TabIndex = 14
        Me.jmlh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Keluar
        '
        Me.Keluar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Keluar.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keluar.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Keluar.Location = New System.Drawing.Point(606, 13)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(89, 52)
        Me.Keluar.TabIndex = 7
        Me.Keluar.Text = "Keluar"
        Me.Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Keluar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(425, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 16)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Cari"
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(461, 71)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(234, 22)
        Me.cari.TabIndex = 5
        '
        'hapus
        '
        Me.hapus.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapus.ForeColor = System.Drawing.Color.SaddleBrown
        Me.hapus.Image = CType(resources.GetObject("hapus.Image"), System.Drawing.Image)
        Me.hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hapus.Location = New System.Drawing.Point(238, 16)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(83, 52)
        Me.hapus.TabIndex = 3
        Me.hapus.Text = "Hapus"
        Me.hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.hapus.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("Kristen ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.Location = New System.Drawing.Point(163, 16)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 52)
        Me.edit.TabIndex = 2
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.ket)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.perihal)
        Me.GroupBox1.Controls.Add(Me.pengirim)
        Me.GroupBox1.Controls.Add(Me.no_srt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_jns)
        Me.GroupBox1.Controls.Add(Me.tgl_kir)
        Me.GroupBox1.Controls.Add(Me.no_agen)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 170)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 16)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Keterangan"
        '
        'perihal
        '
        Me.perihal.Location = New System.Drawing.Point(474, 80)
        Me.perihal.Multiline = True
        Me.perihal.Name = "perihal"
        Me.perihal.Size = New System.Drawing.Size(210, 84)
        Me.perihal.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Perihal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "No. Surat"
        '
        'cmb_jns
        '
        Me.cmb_jns.FormattingEnabled = True
        Me.cmb_jns.Location = New System.Drawing.Point(129, 53)
        Me.cmb_jns.Name = "cmb_jns"
        Me.cmb_jns.Size = New System.Drawing.Size(172, 24)
        Me.cmb_jns.TabIndex = 24
        '
        'tgl_kir
        '
        Me.tgl_kir.Location = New System.Drawing.Point(130, 80)
        Me.tgl_kir.Name = "tgl_kir"
        Me.tgl_kir.Size = New System.Drawing.Size(210, 22)
        Me.tgl_kir.TabIndex = 19
        '
        'no_agen
        '
        Me.no_agen.Location = New System.Drawing.Point(129, 27)
        Me.no_agen.Name = "no_agen"
        Me.no_agen.Size = New System.Drawing.Size(210, 22)
        Me.no_agen.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(113, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(113, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 16)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(113, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 16)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tanggal Kirim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Surat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Agenda"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 330)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(702, 150)
        Me.DGV.TabIndex = 11
        '
        'Surat_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(720, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Surat_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surat_Keluar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pengirim As System.Windows.Forms.TextBox
    Friend WithEvents no_srt As System.Windows.Forms.TextBox
    Friend WithEvents batal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents ket As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Keluar As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents perihal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_jns As System.Windows.Forms.ComboBox
    Friend WithEvents tgl_kir As System.Windows.Forms.DateTimePicker
    Friend WithEvents no_agen As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jmlh As System.Windows.Forms.TextBox
End Class
