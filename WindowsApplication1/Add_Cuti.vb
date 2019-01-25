Public Class Add_Cuti

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim count As Integer

        count = Me.CUTITableAdapter.ScalarQuery()
        If Me.KARYAWANTableAdapter.CEK_KARYAWAN(TextBox1.Text) = 1 Then
            Me.CUTITableAdapter().InsertQuery(count + 1, DateTimePicker1.Value, RichTextBox1.Text, TextBox1.Text)
        End If
    End Sub

    Private Sub Add_Cuti_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.KARYAWAN' table. You can move, or remove it, as needed.
        Me.KARYAWANTableAdapter.Fill(Me.DataSet1.KARYAWAN)
        'TODO: This line of code loads data into the 'DataSet1.CUTI' table. You can move, or remove it, as needed.
        Me.CUTITableAdapter.Fill(Me.DataSet1.CUTI)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub
End Class