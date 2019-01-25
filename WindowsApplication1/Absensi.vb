Public Class Absensi

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub

    Private Sub Absensi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ABSENSI' table. You can move, or remove it, as needed.
        Me.ABSENSITableAdapter.Fill(Me.DataSet1.ABSENSI)
        'TODO: This line of code loads data into the 'DataSet1.KARYAWAN' table. You can move, or remove it, as needed.
        Me.KARYAWANTableAdapter.Fill(Me.DataSet1.KARYAWAN)

        Dim today, thistime As Date
        today = DateValue(Now)
        thistime = TimeValue(Now)

        Label3.Text = today
        Label5.Text = thistime
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim count As Integer

        count = Me.ABSENSITableAdapter.ScalarQuery()
        If Me.KARYAWANTableAdapter.CEK_KARYAWAN(TextBox1.Text) = 1 Then
            Me.ABSENSITableAdapter().InsertQuery(count + 1, Label5.Text, TextBox1.Text, Label3.Text)
        End If
    End Sub
End Class