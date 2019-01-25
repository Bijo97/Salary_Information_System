Public Class Edit_Data_Departemen

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Data_Departemen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DEPARTMENT' table. You can move, or remove it, as needed.
        Me.DEPARTMENTTableAdapter.Fill(Me.DataSet1.DEPARTMENT)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.DEPARTMENTTableAdapter.CEK_DEPARTMENT(TextBox1.Text) = 1 Then
            Me.DEPARTMENTTableAdapter.SearchById(Me.DataSet1.DEPARTMENT, TextBox1.Text)
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
            TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value

            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox5.Enabled = True
            Button3.Enabled = False
            Button1.Enabled = True
            Button4.Enabled = True
            Button2.Enabled = False
        Else
            MsgBox("Id departemen sudah ada, ganti dengan Id lainnya!!!")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        Button3.Enabled = True
        Button1.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DEPARTMENTTableAdapter.UpdateQuery(TextBox3.Text, TextBox2.Text, TextBox5.Text, TextBox1.Text)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        Button3.Enabled = True
        Button1.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = True
    End Sub
End Class