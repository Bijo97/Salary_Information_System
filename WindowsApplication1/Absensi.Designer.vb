<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Absensi
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDABSENSIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WAKTUMASUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WAKTUKELUARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ABSENSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.KARYAWANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KARYAWANTableAdapter = New WindowsApplication1.DataSet1TableAdapters.KARYAWANTableAdapter()
        Me.ABSENSITableAdapter = New WindowsApplication1.DataSet1TableAdapters.ABSENSITableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABSENSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KARYAWANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Absensi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 45)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "&Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Tanggal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "ID Karyawan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Label3"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDABSENSIDataGridViewTextBoxColumn, Me.WAKTUMASUKDataGridViewTextBoxColumn, Me.WAKTUKELUARDataGridViewTextBoxColumn, Me.IDKARYAWANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ABSENSIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(194, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(96, 43)
        Me.DataGridView1.TabIndex = 153
        Me.DataGridView1.Visible = False
        '
        'IDABSENSIDataGridViewTextBoxColumn
        '
        Me.IDABSENSIDataGridViewTextBoxColumn.DataPropertyName = "ID_ABSENSI"
        Me.IDABSENSIDataGridViewTextBoxColumn.HeaderText = "ID_ABSENSI"
        Me.IDABSENSIDataGridViewTextBoxColumn.Name = "IDABSENSIDataGridViewTextBoxColumn"
        '
        'WAKTUMASUKDataGridViewTextBoxColumn
        '
        Me.WAKTUMASUKDataGridViewTextBoxColumn.DataPropertyName = "WAKTU_MASUK"
        Me.WAKTUMASUKDataGridViewTextBoxColumn.HeaderText = "WAKTU_MASUK"
        Me.WAKTUMASUKDataGridViewTextBoxColumn.Name = "WAKTUMASUKDataGridViewTextBoxColumn"
        '
        'WAKTUKELUARDataGridViewTextBoxColumn
        '
        Me.WAKTUKELUARDataGridViewTextBoxColumn.DataPropertyName = "WAKTU_KELUAR"
        Me.WAKTUKELUARDataGridViewTextBoxColumn.HeaderText = "WAKTU_KELUAR"
        Me.WAKTUKELUARDataGridViewTextBoxColumn.Name = "WAKTUKELUARDataGridViewTextBoxColumn"
        '
        'IDKARYAWANDataGridViewTextBoxColumn
        '
        Me.IDKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.HeaderText = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.Name = "IDKARYAWANDataGridViewTextBoxColumn"
        '
        'ABSENSIBindingSource
        '
        Me.ABSENSIBindingSource.DataMember = "ABSENSI"
        Me.ABSENSIBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ABSENSITableAdapter
        '
        Me.ABSENSITableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Waktu Masuk:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Label5"
        '
        'Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 281)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Absensi"
        Me.Text = "Absensi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABSENSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KARYAWANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents KARYAWANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KARYAWANTableAdapter As WindowsApplication1.DataSet1TableAdapters.KARYAWANTableAdapter
    Friend WithEvents ABSENSIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ABSENSITableAdapter As WindowsApplication1.DataSet1TableAdapters.ABSENSITableAdapter
    Friend WithEvents IDABSENSIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WAKTUMASUKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WAKTUKELUARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
