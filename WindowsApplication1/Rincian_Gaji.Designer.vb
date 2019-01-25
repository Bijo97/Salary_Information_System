<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rincian_Gaji
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDGAJIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALTERIMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALGAJIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAJIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.GAJITableAdapter = New WindowsApplication1.DataSet1TableAdapters.GAJITableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAJIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(347, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 51)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "&Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(374, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 20)
        Me.Label27.TabIndex = 93
        Me.Label27.Text = "Label27"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(308, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 20)
        Me.Label26.TabIndex = 92
        Me.Label26.Text = "Bulan:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 51)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "&View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Jabatan:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Departemen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Nama Karyawan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "ID Karyawan:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Rincian Gaji"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDGAJIDataGridViewTextBoxColumn, Me.TANGGALTERIMADataGridViewTextBoxColumn, Me.TOTALGAJIDataGridViewTextBoxColumn, Me.IDKARYAWANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GAJIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(494, 201)
        Me.DataGridView1.TabIndex = 95
        '
        'IDGAJIDataGridViewTextBoxColumn
        '
        Me.IDGAJIDataGridViewTextBoxColumn.DataPropertyName = "ID_GAJI"
        Me.IDGAJIDataGridViewTextBoxColumn.HeaderText = "ID_GAJI"
        Me.IDGAJIDataGridViewTextBoxColumn.Name = "IDGAJIDataGridViewTextBoxColumn"
        '
        'TANGGALTERIMADataGridViewTextBoxColumn
        '
        Me.TANGGALTERIMADataGridViewTextBoxColumn.DataPropertyName = "TANGGAL_TERIMA"
        Me.TANGGALTERIMADataGridViewTextBoxColumn.HeaderText = "TANGGAL_TERIMA"
        Me.TANGGALTERIMADataGridViewTextBoxColumn.Name = "TANGGALTERIMADataGridViewTextBoxColumn"
        '
        'TOTALGAJIDataGridViewTextBoxColumn
        '
        Me.TOTALGAJIDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_GAJI"
        Me.TOTALGAJIDataGridViewTextBoxColumn.HeaderText = "TOTAL_GAJI"
        Me.TOTALGAJIDataGridViewTextBoxColumn.Name = "TOTALGAJIDataGridViewTextBoxColumn"
        '
        'IDKARYAWANDataGridViewTextBoxColumn
        '
        Me.IDKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.HeaderText = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.Name = "IDKARYAWANDataGridViewTextBoxColumn"
        '
        'GAJIBindingSource
        '
        Me.GAJIBindingSource.DataMember = "GAJI"
        Me.GAJIBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GAJITableAdapter
        '
        Me.GAJITableAdapter.ClearBeforeFill = True
        '
        'Rincian_Gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rincian_Gaji"
        Me.Text = "Rincian_Gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAJIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents GAJIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GAJITableAdapter As WindowsApplication1.DataSet1TableAdapters.GAJITableAdapter
    Friend WithEvents IDGAJIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TANGGALTERIMADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALGAJIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
