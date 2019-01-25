Public Class Rincian_Gaji

    Private Sub Rincian_Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.GAJI' table. You can move, or remove it, as needed.
        Me.GAJITableAdapter.Fill(Me.DataSet1.GAJI)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        report_gaji.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.GAJITableAdapter.HITUNG_GAJI(Login.id)
    End Sub
End Class