<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Gaji
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDMASTERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAJIPOKOKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNJANGANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDJABATANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MASTERGAJIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MASTER_GAJITableAdapter = New WindowsApplication1.DataSet1TableAdapters.MASTER_GAJITableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASTERGAJIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(353, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 51)
        Me.Button2.TabIndex = 95
        Me.Button2.Text = "&Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMASTERDataGridViewTextBoxColumn, Me.GAJIPOKOKDataGridViewTextBoxColumn, Me.TUNJANGANDataGridViewTextBoxColumn, Me.IDJABATANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MASTERGAJIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(473, 259)
        Me.DataGridView1.TabIndex = 94
        '
        'IDMASTERDataGridViewTextBoxColumn
        '
        Me.IDMASTERDataGridViewTextBoxColumn.DataPropertyName = "ID_MASTER"
        Me.IDMASTERDataGridViewTextBoxColumn.HeaderText = "ID_MASTER"
        Me.IDMASTERDataGridViewTextBoxColumn.Name = "IDMASTERDataGridViewTextBoxColumn"
        '
        'GAJIPOKOKDataGridViewTextBoxColumn
        '
        Me.GAJIPOKOKDataGridViewTextBoxColumn.DataPropertyName = "GAJI_POKOK"
        Me.GAJIPOKOKDataGridViewTextBoxColumn.HeaderText = "GAJI_POKOK"
        Me.GAJIPOKOKDataGridViewTextBoxColumn.Name = "GAJIPOKOKDataGridViewTextBoxColumn"
        '
        'TUNJANGANDataGridViewTextBoxColumn
        '
        Me.TUNJANGANDataGridViewTextBoxColumn.DataPropertyName = "TUNJANGAN"
        Me.TUNJANGANDataGridViewTextBoxColumn.HeaderText = "TUNJANGAN"
        Me.TUNJANGANDataGridViewTextBoxColumn.Name = "TUNJANGANDataGridViewTextBoxColumn"
        '
        'IDJABATANDataGridViewTextBoxColumn
        '
        Me.IDJABATANDataGridViewTextBoxColumn.DataPropertyName = "ID_JABATAN"
        Me.IDJABATANDataGridViewTextBoxColumn.HeaderText = "ID_JABATAN"
        Me.IDJABATANDataGridViewTextBoxColumn.Name = "IDJABATANDataGridViewTextBoxColumn"
        '
        'MASTERGAJIBindingSource
        '
        Me.MASTERGAJIBindingSource.DataMember = "MASTER_GAJI"
        Me.MASTERGAJIBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 51)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "&View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 25)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Master Gaji"
        '
        'MASTER_GAJITableAdapter
        '
        Me.MASTER_GAJITableAdapter.ClearBeforeFill = True
        '
        'Master_Gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 427)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Master_Gaji"
        Me.Text = "Master Gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASTERGAJIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents MASTERGAJIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MASTER_GAJITableAdapter As WindowsApplication1.DataSet1TableAdapters.MASTER_GAJITableAdapter
    Friend WithEvents IDMASTERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GAJIPOKOKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNJANGANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDJABATANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
