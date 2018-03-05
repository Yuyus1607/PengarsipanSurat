Public Class Laporan_Surat_Keluar

    Public ExitYN As System.Windows.Forms.DialogResult

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV1.SelectionFormula = "totext({surat_keluar.tgl_kirim})= '" & DTP1.Text & "'"
        CRV1.ReportSource = "Keluar_harian.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV1.SelectionFormula = "month({surat_keluar.tgl_kirim})=(" & Month(DTP4.Text) & ") and year({surat_keluar.tgl_kirim})=(" & Year(DTP4.Text) & ")"
        CRV1.ReportSource = "Keluar_bulanan.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV1.SelectionFormula = "totext({surat_keluar.tgl_kirim})>='" & DTP2.Text & "' and totext({surat_keluar.tgl_kirim})<='" & DTP3.Text & "'"
        CRV1.ReportSource = "Keluar_mingguan.rpt"
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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class