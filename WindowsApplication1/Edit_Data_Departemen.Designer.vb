<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Data_Departemen
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.DEPARTMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPARTMENTTableAdapter = New WindowsApplication1.DataSet1TableAdapters.DEPARTMENTTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMANAGERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTELPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTMENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(330, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 45)
        Me.Button3.TabIndex = 115
        Me.Button3.Text = "&Check ID"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 25)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Edit Departemen"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 45)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "&Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(330, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "&Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(164, 238)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 20)
        Me.TextBox5.TabIndex = 111
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(164, 199)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 20)
        Me.TextBox4.TabIndex = 110
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(164, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 109
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(164, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 108
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "No. Telp Departemen:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Jumlah Karyawan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "ID Manager:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Nama Departemen:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "ID Departemen:"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(330, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 45)
        Me.Button4.TabIndex = 116
        Me.Button4.Text = "&Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPARTMENTBindingSource
        '
        Me.DEPARTMENTBindingSource.DataMember = "DEPARTMENT"
        Me.DEPARTMENTBindingSource.DataSource = Me.DataSet1
        '
        'DEPARTMENTTableAdapter
        '
        Me.DEPARTMENTTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDEPTDataGridViewTextBoxColumn, Me.IDMANAGERDataGridViewTextBoxColumn, Me.NAMADEPARTMENTDataGridViewTextBoxColumn, Me.NOTELPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DEPARTMENTBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(243, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(61, 55)
        Me.DataGridView1.TabIndex = 117
        Me.DataGridView1.Visible = False
        '
        'IDDEPTDataGridViewTextBoxColumn
        '
        Me.IDDEPTDataGridViewTextBoxColumn.DataPropertyName = "ID_DEPT"
        Me.IDDEPTDataGridViewTextBoxColumn.HeaderText = "ID_DEPT"
        Me.IDDEPTDataGridViewTextBoxColumn.Name = "IDDEPTDataGridViewTextBoxColumn"
        '
        'IDMANAGERDataGridViewTextBoxColumn
        '
        Me.IDMANAGERDataGridViewTextBoxColumn.DataPropertyName = "ID_MANAGER"
        Me.IDMANAGERDataGridViewTextBoxColumn.HeaderText = "ID_MANAGER"
        Me.IDMANAGERDataGridViewTextBoxColumn.Name = "IDMANAGERDataGridViewTextBoxColumn"
        '
        'NAMADEPARTMENTDataGridViewTextBoxColumn
        '
        Me.NAMADEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "NAMA_DEPARTMENT"
        Me.NAMADEPARTMENTDataGridViewTextBoxColumn.HeaderText = "NAMA_DEPARTMENT"
        Me.NAMADEPARTMENTDataGridViewTextBoxColumn.Name = "NAMADEPARTMENTDataGridViewTextBoxColumn"
        '
        'NOTELPDataGridViewTextBoxColumn
        '
        Me.NOTELPDataGridViewTextBoxColumn.DataPropertyName = "NO_TELP"
        Me.NOTELPDataGridViewTextBoxColumn.HeaderText = "NO_TELP"
        Me.NOTELPDataGridViewTextBoxColumn.Name = "NOTELPDataGridViewTextBoxColumn"
        '
        'DEPARTMENTBindingSource1
        '
        Me.DEPARTMENTBindingSource1.DataMember = "DEPARTMENT"
        Me.DEPARTMENTBindingSource1.DataSource = Me.DataSet1
        '
        'Edit_Data_Departemen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 290)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Data_Departemen"
        Me.Text = "Edit Data Departemen"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTMENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents DEPARTMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPARTMENTTableAdapter As WindowsApplication1.DataSet1TableAdapters.DEPARTMENTTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDEPTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMANAGERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMADEPARTMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTELPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENTBindingSource1 As System.Windows.Forms.BindingSource
End Class
