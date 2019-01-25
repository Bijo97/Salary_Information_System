<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Data_Karyawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.JABATANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.JABATANTableAdapter = New WindowsApplication1.DataSet1TableAdapters.JABATANTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPATLAHIRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALLAHIRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUMLAHANAKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTELPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSPERNIKAHANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDJABATANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KARYAWANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KARYAWANTableAdapter = New WindowsApplication1.DataSet1TableAdapters.KARYAWANTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.JABATANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KARYAWANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4 or more"})
        Me.ComboBox3.Location = New System.Drawing.Point(437, 202)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox3.TabIndex = 134
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(335, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 133
        Me.Label11.Text = "Jumlah Anak:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(437, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 50)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(92, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton4.TabIndex = 82
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Menikah"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(16, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton3.TabIndex = 81
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Single"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(437, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 51)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(92, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton2.TabIndex = 71
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Non-Aktif"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1.TabIndex = 70
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Aktif"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(335, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Status Menikah:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.JABATANBindingSource
        Me.ComboBox2.DisplayMember = "NAMA_JABATAN"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(437, 241)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox2.TabIndex = 129
        Me.ComboBox2.ValueMember = "ID_JABATAN"
        '
        'JABATANBindingSource
        '
        Me.JABATANBindingSource.DataMember = "JABATAN"
        Me.JABATANBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(335, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Jabatan:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 348)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 45)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "&Check ID"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 25)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Tambah Data Karyawan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(581, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 45)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "&Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(295, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "&Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(149, 256)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 20)
        Me.TextBox4.TabIndex = 120
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(148, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 119
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(148, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 118
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 117
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "No. Telp:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Status Kerja:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Alamat:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Tempat Lahir:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Nama:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "ID Karyawan:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Tanggal Lahir:"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(149, 224)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(137, 20)
        Me.TextBox6.TabIndex = 136
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(137, 20)
        Me.DateTimePicker1.TabIndex = 141
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(437, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 45)
        Me.Button4.TabIndex = 142
        Me.Button4.Text = "&Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'JABATANTableAdapter
        '
        Me.JABATANTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Password:"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(148, 291)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 20)
        Me.TextBox5.TabIndex = 144
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDKARYAWANDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.TEMPATLAHIRDataGridViewTextBoxColumn, Me.TANGGALLAHIRDataGridViewTextBoxColumn, Me.ALAMATDataGridViewTextBoxColumn, Me.JUMLAHANAKDataGridViewTextBoxColumn, Me.NOTELPDataGridViewTextBoxColumn, Me.STATUSKARYAWANDataGridViewTextBoxColumn, Me.STATUSPERNIKAHANDataGridViewTextBoxColumn, Me.PASSWORDKARYAWANDataGridViewTextBoxColumn, Me.IDJABATANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KARYAWANBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(596, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(75, 43)
        Me.DataGridView1.TabIndex = 145
        Me.DataGridView1.Visible = False
        '
        'IDKARYAWANDataGridViewTextBoxColumn
        '
        Me.IDKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.HeaderText = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.Name = "IDKARYAWANDataGridViewTextBoxColumn"
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        '
        'TEMPATLAHIRDataGridViewTextBoxColumn
        '
        Me.TEMPATLAHIRDataGridViewTextBoxColumn.DataPropertyName = "TEMPAT_LAHIR"
        Me.TEMPATLAHIRDataGridViewTextBoxColumn.HeaderText = "TEMPAT_LAHIR"
        Me.TEMPATLAHIRDataGridViewTextBoxColumn.Name = "TEMPATLAHIRDataGridViewTextBoxColumn"
        '
        'TANGGALLAHIRDataGridViewTextBoxColumn
        '
        Me.TANGGALLAHIRDataGridViewTextBoxColumn.DataPropertyName = "TANGGAL_LAHIR"
        Me.TANGGALLAHIRDataGridViewTextBoxColumn.HeaderText = "TANGGAL_LAHIR"
        Me.TANGGALLAHIRDataGridViewTextBoxColumn.Name = "TANGGALLAHIRDataGridViewTextBoxColumn"
        '
        'ALAMATDataGridViewTextBoxColumn
        '
        Me.ALAMATDataGridViewTextBoxColumn.DataPropertyName = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.HeaderText = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.Name = "ALAMATDataGridViewTextBoxColumn"
        '
        'JUMLAHANAKDataGridViewTextBoxColumn
        '
        Me.JUMLAHANAKDataGridViewTextBoxColumn.DataPropertyName = "JUMLAH_ANAK"
        Me.JUMLAHANAKDataGridViewTextBoxColumn.HeaderText = "JUMLAH_ANAK"
        Me.JUMLAHANAKDataGridViewTextBoxColumn.Name = "JUMLAHANAKDataGridViewTextBoxColumn"
        '
        'NOTELPDataGridViewTextBoxColumn
        '
        Me.NOTELPDataGridViewTextBoxColumn.DataPropertyName = "NO_TELP"
        Me.NOTELPDataGridViewTextBoxColumn.HeaderText = "NO_TELP"
        Me.NOTELPDataGridViewTextBoxColumn.Name = "NOTELPDataGridViewTextBoxColumn"
        '
        'STATUSKARYAWANDataGridViewTextBoxColumn
        '
        Me.STATUSKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "STATUS_KARYAWAN"
        Me.STATUSKARYAWANDataGridViewTextBoxColumn.HeaderText = "STATUS_KARYAWAN"
        Me.STATUSKARYAWANDataGridViewTextBoxColumn.Name = "STATUSKARYAWANDataGridViewTextBoxColumn"
        '
        'STATUSPERNIKAHANDataGridViewTextBoxColumn
        '
        Me.STATUSPERNIKAHANDataGridViewTextBoxColumn.DataPropertyName = "STATUS_PERNIKAHAN"
        Me.STATUSPERNIKAHANDataGridViewTextBoxColumn.HeaderText = "STATUS_PERNIKAHAN"
        Me.STATUSPERNIKAHANDataGridViewTextBoxColumn.Name = "STATUSPERNIKAHANDataGridViewTextBoxColumn"
        '
        'PASSWORDKARYAWANDataGridViewTextBoxColumn
        '
        Me.PASSWORDKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD_KARYAWAN"
        Me.PASSWORDKARYAWANDataGridViewTextBoxColumn.HeaderText = "PASSWORD_KARYAWAN"
        Me.PASSWORDKARYAWANDataGridViewTextBoxColumn.Name = "PASSWORDKARYAWANDataGridViewTextBoxColumn"
        '
        'IDJABATANDataGridViewTextBoxColumn
        '
        Me.IDJABATANDataGridViewTextBoxColumn.DataPropertyName = "ID_JABATAN"
        Me.IDJABATANDataGridViewTextBoxColumn.HeaderText = "ID_JABATAN"
        Me.IDJABATANDataGridViewTextBoxColumn.Name = "IDJABATANDataGridViewTextBoxColumn"
        '
        'KARYAWANBindingSource
        '
        Me.KARYAWANBindingSource.DataMember = "KARYAWAN"
        Me.KARYAWANBindingSource.DataSource = Me.DataSet1
        '
        'KARYAWANTableAdapter
        '
        Me.KARYAWANTableAdapter.ClearBeforeFill = True
        '
        'Tambah_Data_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 412)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah_Data_Karyawan"
        Me.Text = "Tambah Data Karyawan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.JABATANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KARYAWANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents JABATANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JABATANTableAdapter As WindowsApplication1.DataSet1TableAdapters.JABATANTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents KARYAWANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KARYAWANTableAdapter As WindowsApplication1.DataSet1TableAdapters.KARYAWANTableAdapter
    Friend WithEvents IDKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEMPATLAHIRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TANGGALLAHIRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALAMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUMLAHANAKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTELPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUSKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUSPERNIKAHANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDJABATANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
