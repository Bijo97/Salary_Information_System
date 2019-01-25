Public Class Login
    Public id

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.KARYAWANTableAdapter.CEK_LOGIN(TextBox1.Text, TextBox2.Text) = 1 Then
            id = TextBox1.Text
            If Me.KARYAWANTableAdapter.CEK_PERAN(TextBox1.Text) = 1 Then
                Menu_Page.DataKaryawanToolStripMenuItem.Enabled = True
                Menu_Page.DataDepartemenToolStripMenuItem.Enabled = True
            Else
                Menu_Page.DataKaryawanToolStripMenuItem.Enabled = False
                Menu_Page.DataDepartemenToolStripMenuItem.Enabled = False
            End If
            Menu_Page.Show()
            Me.Hide()
        Else
            MsgBox("Id atau password salah!!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.KARYAWAN' table. You can move, or remove it, as needed.
        Me.KARYAWANTableAdapter.Fill(Me.DataSet1.KARYAWAN)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class