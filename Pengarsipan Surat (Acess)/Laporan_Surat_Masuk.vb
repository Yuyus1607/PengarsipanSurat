Public Class Laporan_Surat_Masuk

    Public ExitYN As System.Windows.Forms.DialogResult

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV1.SelectionFormula = "totext({surat_masuk.tgl_terima})= '" & DTP1.Text & "'"
        CRV1.ReportSource = "Surat_harian.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV1.SelectionFormula = "month({surat_masuk.tgl_terima})=(" & Month(DTP4.Text) & ") and year({surat_masuk.tgl_terima})=(" & Year(DTP4.Text) & ")"
        CRV1.ReportSource = "Surat_bulanan.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV1.SelectionFormula = "totext({surat_masuk.tgl_terima})>='" & DTP2.Text & "' and totext({surat_masuk.tgl_terima})<='" & DTP3.Text & "'"
        CRV1.ReportSource = "Surat_mingguan1.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ExitYN = MsgBox("Apa Anda yakin ingin menutup aplikasi ini ?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP1.ValueChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CRV1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV1.Load

    End Sub
End Class