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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPesquisarAluno = New System.Windows.Forms.Button()
        Me.btnPesquisarCurso = New System.Windows.Forms.Button()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomeCurso = New System.Windows.Forms.TextBox()
        Me.txtCodAluno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodCurso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarAlunoCurso = New System.Windows.Forms.Button()
        Me.btnSalvarAlunoCurso = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPesquisarAluno)
        Me.GroupBox1.Controls.Add(Me.btnPesquisarCurso)
        Me.GroupBox1.Controls.Add(Me.txtNomeAluno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNomeCurso)
        Me.GroupBox1.Controls.Add(Me.txtCodAluno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodCurso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes"
        '
        'btnPesquisarAluno
        '
        Me.btnPesquisarAluno.Location = New System.Drawing.Point(314, 83)
        Me.btnPesquisarAluno.Name = "btnPesquisarAluno"
        Me.btnPesquisarAluno.Size = New System.Drawing.Size(81, 25)
        Me.btnPesquisarAluno.TabIndex = 2
        Me.btnPesquisarAluno.Text = "Pesquisar"
        Me.btnPesquisarAluno.UseVisualStyleBackColor = True
        '
        'btnPesquisarCurso
        '
        Me.btnPesquisarCurso.Location = New System.Drawing.Point(314, 41)
        Me.btnPesquisarCurso.Name = "btnPesquisarCurso"
        Me.btnPesquisarCurso.Size = New System.Drawing.Size(81, 25)
        Me.btnPesquisarCurso.TabIndex = 2
        Me.btnPesquisarCurso.Text = "Pesquisar"
        Me.btnPesquisarCurso.UseVisualStyleBackColor = True
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.BackColor = System.Drawing.Color.White
        Me.txtNomeAluno.Enabled = False
        Me.txtNomeAluno.Location = New System.Drawing.Point(112, 86)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(196, 20)
        Me.txtNomeAluno.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nome Aluno"
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.BackColor = System.Drawing.Color.White
        Me.txtNomeCurso.Enabled = False
        Me.txtNomeCurso.Location = New System.Drawing.Point(112, 44)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(196, 20)
        Me.txtNomeCurso.TabIndex = 1
        '
        'txtCodAluno
        '
        Me.txtCodAluno.BackColor = System.Drawing.Color.White
        Me.txtCodAluno.Enabled = False
        Me.txtCodAluno.Location = New System.Drawing.Point(24, 86)
        Me.txtCodAluno.Name = "txtCodAluno"
        Me.txtCodAluno.Size = New System.Drawing.Size(82, 20)
        Me.txtCodAluno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cód. Aluno"
        '
        'txtCodCurso
        '
        Me.txtCodCurso.BackColor = System.Drawing.Color.White
        Me.txtCodCurso.Enabled = False
        Me.txtCodCurso.Location = New System.Drawing.Point(24, 44)
        Me.txtCodCurso.Name = "txtCodCurso"
        Me.txtCodCurso.Size = New System.Drawing.Size(82, 20)
        Me.txtCodCurso.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Curso"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelarAlunoCurso)
        Me.GroupBox2.Controls.Add(Me.btnSalvarAlunoCurso)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnCancelarAlunoCurso
        '
        Me.btnCancelarAlunoCurso.Location = New System.Drawing.Point(212, 19)
        Me.btnCancelarAlunoCurso.Name = "btnCancelarAlunoCurso"
        Me.btnCancelarAlunoCurso.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelarAlunoCurso.TabIndex = 0
        Me.btnCancelarAlunoCurso.Text = "Cancelar"
        Me.btnCancelarAlunoCurso.UseVisualStyleBackColor = True
        '
        'btnSalvarAlunoCurso
        '
        Me.btnSalvarAlunoCurso.Location = New System.Drawing.Point(88, 19)
        Me.btnSalvarAlunoCurso.Name = "btnSalvarAlunoCurso"
        Me.btnSalvarAlunoCurso.Size = New System.Drawing.Size(117, 37)
        Me.btnSalvarAlunoCurso.TabIndex = 0
        Me.btnSalvarAlunoCurso.Text = "Salvar Aluno/Curso"
        Me.btnSalvarAlunoCurso.UseVisualStyleBackColor = True
        '
        'cadFormAlunoCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 238)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "cadFormAlunoCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPesquisarCurso As System.Windows.Forms.Button
    Friend WithEvents txtNomeAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCurso As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodCurso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarAlunoCurso As System.Windows.Forms.Button
    Friend WithEvents btnSalvarAlunoCurso As System.Windows.Forms.Button
    Friend WithEvents btnPesquisarAluno As System.Windows.Forms.Button
End Class
