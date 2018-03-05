Imports System.Data.OleDb
Public Class Login

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
    Private Sub txt_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.btn_simpan.Focus()
        End If
    End Sub
    Sub Kosongkan()
        Me.txt_user.Clear()
        Me.txt_password.Clear()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If Me.txt_user.Text = "" Or Me.txt_password.Text = "" Then
            MsgBox("data Login belum ada")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from petugass where username = '" & Me.txt_user.Text & "' and password='" & Me.txt_password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("gagal login")
                Me.txt_user.Clear()
                Me.txt_password.Clear()
                Me.txt_user.Focus()
                Exit Sub
            Else
                Me.Visible = False
                menuutama.Show()
                menuutama.panelkode.Text = dr.Item("id_petugas")
                menuutama.panelnama.Text = dr.Item("username")
                menuutama.panelstatus.Text = dr.Item("status")

            End If
            'hak akses
            If menuutama.panelstatus.Text = "USER" Then
                menuutama1.Show()
                menuutama1.panelkode.Text = dr.Item("id_petugas")
                menuutama1.panelnama.Text = dr.Item("username")
                menuutama1.panelstatus.Text = dr.Item("status")
                menuutama.Hide()

            ElseIf menuutama.panelstatus .Text = "ADMIN" Then
                menuutama.Button8.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
