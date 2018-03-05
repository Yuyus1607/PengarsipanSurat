Imports System.Data.OleDb

Public Class petugas

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
    Sub fakturotomatistgl()
        Call koneksi()
        cmd = New OleDbCommand("select * from petugass order by id_petugas desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            id_pet.Text = "P" + "0001"
        Else
            id_pet.Text = "P" + Format(Microsoft.VisualBasic.Right(dr(0), 4) + 1, "0000")
        End If
        id_pet.Enabled = False
    End Sub
    Sub kosongkan()
        Me.nm_dpn.Clear()
        Me.nm_blkng.Clear()
        Me.username.Clear()
        Me.password.Clear()
        Me.status.Text = ""
        Me.id_pet.Focus()
        Call fakturotomatistgl()
    End Sub

    Sub ketemu()
        On Error Resume Next
        Me.id_pet.Text = dr.Item("id_petugas")
        Me.nm_dpn.Text = dr.Item("nama_depan")
        Me.nm_blkng.Text = dr.Item("nama_belakang")
        Me.username.Text = dr.Item("username")
        Me.password.Text = dr.Item("password")
        Me.status.Text = dr.Item("status")
        Me.id_pet.Focus()
    End Sub

    Sub Tampilkan()
        Call koneksi()
        da = New OleDbDataAdapter("select * from petugass", conn)
        ds = New DataSet
        da.Fill(ds)

        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub

    Sub kondisiawal()
        Call kosongkan()
        Call Tampilkan()
    End Sub


    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        'memanggil field database'

        On Error Resume Next
        Call koneksi()
        Me.id_pet.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Me.nm_dpn.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        Me.nm_blkng.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        Me.username.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Me.password.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        Me.status.Text = DGV.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '====== ComboBox Jenis Surat ============
        status.Text = "~Pilihan~"
        status.Items.Add("ADMIN")
        status.Items.Add("USER")
        Call Tampilkan()
        Call koneksi()
        cmd = New OleDbCommand("select * from petugass", conn)
        dr = cmd.ExecuteReader
        
        Call koneksi()
        da = New OleDbDataAdapter("select * from petugass", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        'mengubah posisi tulisan field di griedview'
        Me.DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Call fakturotomatistgl()
    End Sub

    Private Sub hapus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        '--------PROSES DELETE------------
        If Me.id_pet.Text = "" Then
            MsgBox("ID PETUGAS HARUS DIISI")
            Me.id_pet.Focus()
            Exit Sub
        End If
        '-----------proses delete---
        Call koneksi()
        If MessageBox.Show("Hapus data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "delete from petugass where id_petugas ='" & id_pet.Text & "'"
            cmd = New OleDbCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Call kondisiawal()
            Call Tampilkan()
            Call fakturotomatistgl()
        Else
            Call kosongkan()
        End If
    End Sub

    Private Sub save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Call koneksi()
        cmd = New OleDbCommand("select * from petugass where id_petugas = '" & Me.id_pet.Text & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()

            '------------------SIMPAN-----------------

            Call koneksi()
        Dim simpan As String = "insert into petugass values('" & Me.id_pet.Text & "' ,'" & Me.nm_dpn.Text & "','" & Me.nm_blkng.Text & "','" & Me.username.Text & "','" & Me.password.Text & "','" & Me.status.Text & "' )"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Call Tampilkan()
            Call kondisiawal()
            Call fakturotomatistgl()


    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Call kosongkan()
    End Sub

    Private Sub Keluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        ExitYN = MsgBox("Apa Anda yakin ingin menutup aplikasi ini ?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from petugass where username like '%" & Me.cari.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New OleDbDataAdapter("select * from petugass where username like '%" & Me.cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            Me.DGV.DataSource = ds.Tables(0)
        Else
            MsgBox("Username tidak ditemukan")
        End If
    End Sub

    Private Sub id_pet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_pet.TextChanged

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Call koneksi()
        Dim sqlupdate As String
        sqlupdate = "UPDATE petugass set [nama_depan] ='" & Me.nm_dpn.Text & "', [nama_belakang] ='" & Me.nm_blkng.Text & "', [username] ='" & Me.username.Text & "', [password] ='" & Me.password.Text & "', [status] ='" & Me.status.Text & "' where [id_petugas]= '" & Me.id_pet.Text & "'"
        cmd = New OleDbCommand(sqlupdate, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Call kondisiawal()
        Call fakturotomatistgl()
    End Sub
End Class