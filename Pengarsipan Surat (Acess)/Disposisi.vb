Imports System.Data.OleDb

Public Class Disposisi

    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim jenis As String
    Public ExitYN As System.Windows.Forms.DialogResult

    Public Sub koneksi()
        Try
            conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Surat.mdb") 'data disesuaikan dengan yang kamu buat
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub Kosongkan()
        Me.ComboBox1.Text = "~Pilihan~"
        Me.TextBox1.Clear()
        Call Notis()
    End Sub
    Sub Notis() 'nomor otomatis
        Call koneksi()
        cmd = New OleDbCommand("select * from disposisi order by no_disposisi desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            no_dis.Text = "DIS" + "0001"
        Else
            no_dis.Text = "DIS" + Format(Microsoft.VisualBasic.Right(dr(0), 4) + 1, "0000")
        End If
        no_dis.Enabled = False
    End Sub
    Private Sub Disposisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Notis()
        tgl_dis.Text = Today
        tgl_dis.Enabled = False
        srt_dari.Enabled = False
        no_srt.Enabled = False
        no_agen.Enabled = False
        tgl_srt.Enabled = False
        tgl_ter.Enabled = False
        perihal.Enabled = False
        cmb_jns.Enabled = False
        '====== ComboBox diteruskan ke ============
        Me.ComboBox1.Text = "~Pilihan~"
        ComboBox1.Items.Add("Kepala Sekolah")
        ComboBox1.Items.Add("Wakil Bidang Management Mutu")
        ComboBox1.Items.Add("Wakil Bidang Kurikulum")
        ComboBox1.Items.Add("Wakil Bidang Kesiswaan")
        ComboBox1.Items.Add("Wakil Bidang Sarana Prasarana")
        ComboBox1.Items.Add("Tata Usaha")
        ComboBox1.Items.Add("Guru")
        ComboBox1.Items.Add("BPBK")
        ComboBox1.Items.Add("BKK")
        ComboBox1.Items.Add("Caraka")
        ComboBox1.Items.Add("Satpam")
        ComboBox1.Items.Add("Siswa")
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        Call Kosongkan()
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        ExitYN = MsgBox("Apa Anda yakin ingin menutup aplikasi ini ?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox1.Text = "" Then

            MsgBox("Data belum lengkap")
            Exit Sub
        End If

        Call koneksi()

        Dim simpan As String = "insert into disposisi values('" & no_dis.Text & "','" & Format(DateValue(tgl_dis.Text), "MM/dd/yyyy") & "','" & no_agen.Text & "','" & no_srt.Text & "','" & Format(DateValue(tgl_ter.Text), "MM/dd/yyyy") & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & cmb_jns.Text & "')"
        cmd = New OleDbCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Call Notis()
        Call Kosongkan()
        '-------------------------------
        If MessageBox.Show("cetak Disposisi ??", "Perhatian", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cetak.Show()
            cetak.CrystalReportViewer1.ReportSource = "cetak_dis.rpt"
            cetak.CrystalReportViewer1.RefreshReport()

        End If
        '==============================================
        Call Notis()
        Me.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_dis.TextChanged

    End Sub

    Private Sub tgl_dis_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgl_dis.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Surat_Keluar.Show()
        Surat_Keluar.cmb_jns.Text = cmb_jns.Text
        Surat_Keluar.no_srt.Text = no_srt.Text
        Surat_Keluar.pengirim.Text = srt_dari.Text
        Surat_Keluar.perihal.Text = perihal.Text
        Dispose()

    End Sub
End Class