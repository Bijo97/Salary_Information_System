Public Class Tambah_Data_Karyawan

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Menu_Page.Show()
        Me.Close()
    End Sub

    Private Sub Tambah_Data_Karyawan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.JABATAN' table. You can move, or remove it, as needed.
        Me.JABATANTableAdapter.Fill(Me.DataSet1.JABATAN)
        'TODO: This line of code loads data into the 'DataSet1.KARYAWAN' table. You can move, or remove it, as needed.
        Me.KARYAWANTableAdapter.Fill(Me.DataSet1.KARYAWAN)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.KARYAWANTableAdapter.CEK_KARYAWAN(TextBox1.Text) = 0 Then
            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            DateTimePicker1.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
        Else
            MsgBox("Id karyawan sudah ada, ganti dengan id lainnya!!!")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim kerja, kawin As String
        Dim anak As Integer

        If RadioButton1.Checked = True Then
            kerja = "Aktif"
        ElseIf RadioButton2.Checked = True Then
            kerja = "Non-Aktif"
        End If

        If RadioButton3.Checked = True Then
            kawin = "Single"
        ElseIf RadioButton4.Checked = True Then
            kawin = "Menikah"
        End If

        If ComboBox3.SelectedIndex = 0 Then
            anak = 0
        ElseIf ComboBox3.SelectedIndex = 1 Then
            anak = 1
        ElseIf ComboBox3.SelectedIndex = 2 Then
            anak = 2
        ElseIf ComboBox3.SelectedIndex = 3 Then
            anak = 3
        ElseIf ComboBox3.SelectedIndex = 4 Then
            anak = 4
        End If

        Me.KARYAWANTableAdapter.KARYAWANS(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Value, TextBox6.Text, anak, TextBox4.Text, kerja, kawin, TextBox5.Text, ComboBox2.SelectedValue)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ComboBox2.SelectedValue = ""
        ComboBox3.SelectedValue = ""

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker1.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ComboBox2.SelectedValue = ""
        ComboBox3.SelectedValue = ""

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker1.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub
End Class