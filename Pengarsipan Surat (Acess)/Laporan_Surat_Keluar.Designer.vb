﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Surat_Keluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan_Surat_Keluar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.DTP4 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTP3 = New System.Windows.Forms.DateTimePicker
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.CRV1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1359, 180)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button4.Font = New System.Drawing.Font("Kristen ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1226, 13)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Keluar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.DTP4)
        Me.GroupBox4.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(764, 72)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(129, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bulanan"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(4, 63)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "View"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DTP4
        '
        Me.DTP4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP4.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP4.Location = New System.Drawing.Point(4, 19)
        Me.DTP4.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP4.Name = "DTP4"
        Me.DTP4.Size = New System.Drawing.Size(121, 22)
        Me.DTP4.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox3.Controls.Add(Me.DTP3)
        Me.GroupBox3.Controls.Add(Me.DTP2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(621, 70)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(139, 102)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mingguan"
        '
        'DTP3
        '
        Me.DTP3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP3.Location = New System.Drawing.Point(4, 41)
        Me.DTP3.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP3.Name = "DTP3"
        Me.DTP3.Size = New System.Drawing.Size(131, 22)
        Me.DTP3.TabIndex = 4
        '
        'DTP2
        '
        Me.DTP2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(4, 19)
        Me.DTP2.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(131, 22)
        Me.DTP2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(4, 65)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "View"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DTP1)
        Me.GroupBox2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(484, 69)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(133, 103)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Harian"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(4, 66)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTP1
        '
        Me.DTP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(4, 19)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(125, 22)
        Me.DTP1.TabIndex = 0
        '
        'CRV1
        '
        Me.CRV1.ActiveViewIndex = -1
        Me.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV1.Location = New System.Drawing.Point(0, 180)
        Me.CRV1.Margin = New System.Windows.Forms.Padding(4)
        Me.CRV1.Name = "CRV1"
        Me.CRV1.SelectionFormula = ""
        Me.CRV1.Size = New System.Drawing.Size(1359, 543)
        Me.CRV1.TabIndex = 5
        Me.CRV1.ViewTimeSelectionFormula = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(509, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SMK NEGERI 2 KOTA BEKASI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(556, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LAPORAN SURAT KELUAR"
        '
        'Laporan_Surat_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 723)
        Me.Controls.Add(Me.CRV1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Laporan_Surat_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan_Surat_Keluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTP4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
