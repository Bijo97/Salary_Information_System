Public Class Master_Gaji

    Private Sub Master_Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.MASTER_GAJI' table. You can move, or remove it, as needed.
        Me.MASTER_GAJITableAdapter.Fill(Me.DataSet1.MASTER_GAJI)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        new_report_MasterGaji.Show()
        Me.Hide()
    End Sub
End Class