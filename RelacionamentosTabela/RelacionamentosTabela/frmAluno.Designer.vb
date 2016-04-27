<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluno
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
        Me.dgvAluno = New System.Windows.Forms.DataGridView()
        Me.btnAddAluno = New System.Windows.Forms.Button()
        Me.btnCloseAluno = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAluno
        '
        Me.dgvAluno.AllowUserToAddRows = False
        Me.dgvAluno.AllowUserToDeleteRows = False
        Me.dgvAluno.BackgroundColor = System.Drawing.Color.White
        Me.dgvAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAluno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAluno.Location = New System.Drawing.Point(3, 16)
        Me.dgvAluno.MultiSelect = False
        Me.dgvAluno.Name = "dgvAluno"
        Me.dgvAluno.ReadOnly = True
        Me.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAluno.Size = New System.Drawing.Size(392, 226)
        Me.dgvAluno.TabIndex = 0
        '
        'btnAddAluno
        '
        Me.btnAddAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAluno.Location = New System.Drawing.Point(254, 270)
        Me.btnAddAluno.Name = "btnAddAluno"
        Me.btnAddAluno.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAluno.TabIndex = 1
        Me.btnAddAluno.Text = "Adicionar"
        Me.btnAddAluno.UseVisualStyleBackColor = True
        '
        'btnCloseAluno
        '
        Me.btnCloseAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseAluno.Location = New System.Drawing.Point(335, 270)
        Me.btnCloseAluno.Name = "btnCloseAluno"
        Me.btnCloseAluno.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseAluno.TabIndex = 1
        Me.btnCloseAluno.Text = "Fechar"
        Me.btnCloseAluno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvAluno)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 245)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'frmAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCloseAluno)
        Me.Controls.Add(Me.btnAddAluno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aluno"
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAluno As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddAluno As System.Windows.Forms.Button
    Friend WithEvents btnCloseAluno As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
