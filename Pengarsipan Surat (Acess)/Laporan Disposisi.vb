Public Class Laporan_Disposisi

    Public ExitYN As System.Windows.Forms.DialogResult

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV1.SelectionFormula = "totext({disposisi.tgl_disposisi})= '" & DTP1.Text & "'"
        CRV1.ReportSource = "dis_harian.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ExitYN = MsgBox("Apa Anda yakin ingin menutup aplikasi ini ?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV1.SelectionFormula = "totext({disposisi.tgl_disposisi})>='" & DTP2.Text & "' and totext({disposisi.tgl_disposisi})<='" & DTP3.Text & "'"
        CRV1.ReportSource = "dis_mingguan.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV1.SelectionFormula = "month({disposisi.tgl_disposisi})=(" & Month(DTP4.Text) & ") and year({disposisi.tgl_disposisi})=(" & Year(DTP4.Text) & ")"
        CRV1.ReportSource = "dis_bulanan.rpt"
        CRV1.RefreshReport()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class