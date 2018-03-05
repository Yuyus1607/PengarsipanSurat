Imports System.Data.OleDb

Public Class Surat_Masuk

    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
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
        Me.tgl_kir.Text = Today
        Me.ket.Clear()
        Me.no_srt.Clear()
        Me.tgl_ter.Text = Today
        Me.pengirim.Clear()
        Me.cmb_jns.Text = "~Pilihan~"
        Me.perihal.Clear()
    End Sub
    Sub TampilGrid()
        Call koneksi()
        da = New OleDbDataAdapter("select * from surat_masuk", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub fakturotomatistgl()
        Call koneksi()
        cmd = New OleDbCommand("select * from surat_masuk order by no_agenda desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            no_agen.Text = "SM" + "-" + Format(Now, "dd/MM/yyyy") + "-" + "0001"
        Else
            no_agen.Text = "SM" + "-" + Format(Now, "dd/MM/yyyy") + "-" + Format(Microsoft.VisualBasic.Right(dr(0), 4) + 1, "0000")
        End If
        no_agen.Enabled = False
    End Sub
    Sub jumlah()
        Call koneksi()
        da = New OleDbDataAdapter("select * from surat_masuk", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        jmlh.Text = DGV.RowCount - 1

    End Sub
    Sub tampilsurat()
        Call koneksi()
        da = New OleDbDataAdapter("select * from disposisi ", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        DGV1.ReadOnly = True
    End Sub
    Private Sub Surat_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '====== ComboBox Jenis Surat ============
        Me.cmb_jns.Text = "~Pilihan~"
        cmb_jns.Items.Add("Penting")
        cmb_jns.Items.Add("Umum")
        cmb_jns.Items.Add("Rahasia")
        cmb_jns.Items.Add("Pribadi")
        Call TampilGrid()
        Call tampilsurat()
        Call fakturotomatistgl()
        Call jumlah()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If cmb_jns.Text = "" Or tgl_kir.Text = "" Or ket.Text = "" Or tgl_ter.Text = "" Or no_srt.Text = "" Or pengirim.Text = "" Or perihal.Text = "" Then

            MsgBox("Data belum lengkap")
            Exit Sub
        End If

        Call koneksi()

        Dim simpan As String = "insert into surat_masuk values('" & no_agen.Text & "','" & menuutama.panelkode.Text & "','" & cmb_jns.Text & "','" & Format(DateValue(tgl_kir.Text), "MM/dd/yyyy") & "','" & Format(DateValue(tgl_ter.Text), "MM/dd/yyyy") & "','" & no_srt.Text & "','" & pengirim.Text & "','" & perihal.Text & "','" & ket.Text & "')"
        cmd = New OleDbCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Call jumlah()
        Call Kosongkan()
        Call TampilGrid()
        Call fakturotomatistgl()
    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        Call Kosongkan()
        Call fakturotomatistgl()
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        '-----------------EDIT----------------
        Call koneksi()
        Dim edit As String = "update surat_masuk set id_petugas ='" & menuutama.panelkode.Text & "', jenis_surat ='" & Me.cmb_jns.Text & "', tgl_kirim ='" & Format(DateValue(tgl_kir.Text), "MM/dd/yyyy") & "', tgl_terima ='" & Format(DateValue(tgl_ter.Text), "MM/dd/yyyy") & "', no_surat ='" & Me.no_srt.Text & "', pengirim ='" & Me.pengirim.Text & "', perihal ='" & Me.perihal.Text & "', ket ='" & Me.ket.Text & "' where no_agenda = '" & Me.no_agen.Text & "'"
        cmd = New OleDbCommand(edit, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        Call jumlah()
        Call Kosongkan()
        Call TampilGrid()
        Call fakturotomatistgl()
    End Sub

    Private Sub cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from surat_masuk where no_agenda like '%" & Me.cari.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New OleDbDataAdapter("select * from surat_masuk where no_agenda like '%" & Me.cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        '--------PROSES DELETE------------
        If Me.no_agen.Text = "" Then
            MsgBox("ID SURAT HARUS DIISI")
            Me.no_agen.Focus()
            Exit Sub
        End If
        '-----------proses delete---
        Call koneksi()
        If MessageBox.Show("Hapus data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "delete from surat_masuk where no_agenda  ='" & no_agen.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Call TampilGrid()
            Call fakturotomatistgl()
            Call jumlah()
            Call Kosongkan()
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        ExitYN = MsgBox("Apa Anda yakin ingin menutup aplikasi ini ?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Disposisi.Show()
        Disposisi.srt_dari.Text = menuutama.panelnama.Text
        Disposisi.no_srt.Text = no_srt.Text
        Disposisi.no_agen.Text = no_agen.Text
        Disposisi.tgl_srt.Text = tgl_kir.Text
        Disposisi.tgl_ter.Text = tgl_ter.Text
        Disposisi.perihal.Text = perihal.Text
        Disposisi.cmb_jns.Text = cmb_jns.Text

        Dispose()
    End Sub

    Private Sub DGV_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        no_agen.Text = DGV.Rows(e.RowIndex).Cells(0).Value()
        cmb_jns.Text = DGV.Rows(e.RowIndex).Cells(2).Value()
        tgl_kir.Text = DGV.Rows(e.RowIndex).Cells(3).Value()
        tgl_ter.Text = DGV.Rows(e.RowIndex).Cells(4).Value()
        no_srt.Text = DGV.Rows(e.RowIndex).Cells(5).Value()
        pengirim.Text = DGV.Rows(e.RowIndex).Cells(6).Value()
        perihal.Text = DGV.Rows(e.RowIndex).Cells(7).Value()
        ket.Text = DGV.Rows(e.RowIndex).Cells(8).Value()

        '=================================
    End Sub

    Private Sub cmb_jns_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_jns.SelectedIndexChanged

    End Sub
End Class