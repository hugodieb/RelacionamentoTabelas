<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadFormAlunoCurso
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnConfirmaAluno = New System.Windows.Forms.Button()
        Me.btnFecharAluno = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(604, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'btnConfirmaAluno
        '
        Me.btnConfirmaAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmaAluno.Location = New System.Drawing.Point(171, 307)
        Me.btnConfirmaAluno.Name = "btnConfirmaAluno"
        Me.btnConfirmaAluno.Size = New System.Drawing.Size(140, 23)
        Me.btnConfirmaAluno.TabIndex = 1
        Me.btnConfirmaAluno.Text = "Adicionar"
        Me.btnConfirmaAluno.UseVisualStyleBackColor = True
        '
        'btnFecharAluno
        '
        Me.btnFecharAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharAluno.Location = New System.Drawing.Point(317, 307)
        Me.btnFecharAluno.Name = "btnFecharAluno"
        Me.btnFecharAluno.Size = New System.Drawing.Size(140, 23)
        Me.btnFecharAluno.TabIndex = 1
        Me.btnFecharAluno.Text = "Fechar"
        Me.btnFecharAluno.UseVisualStyleBackColor = True
        '
        'cadFormAlunoCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 342)
        Me.Controls.Add(Me.btnFecharAluno)
        Me.Controls.Add(Me.btnConfirmaAluno)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "cadFormAlunoCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnConfirmaAluno As System.Windows.Forms.Button
    Friend WithEvents btnFecharAluno As System.Windows.Forms.Button
End Class
