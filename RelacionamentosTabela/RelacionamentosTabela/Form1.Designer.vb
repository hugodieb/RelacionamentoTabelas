<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_index
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
        Me.dgvAlunoCursos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCursos = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFechar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAlunoCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlunoCursos
        '
        Me.dgvAlunoCursos.AllowUserToAddRows = False
        Me.dgvAlunoCursos.AllowUserToDeleteRows = False
        Me.dgvAlunoCursos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAlunoCursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAlunoCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlunoCursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlunoCursos.EnableHeadersVisualStyles = False
        Me.dgvAlunoCursos.Location = New System.Drawing.Point(3, 19)
        Me.dgvAlunoCursos.Name = "dgvAlunoCursos"
        Me.dgvAlunoCursos.ReadOnly = True
        Me.dgvAlunoCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlunoCursos.Size = New System.Drawing.Size(451, 227)
        Me.dgvAlunoCursos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCursos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Cursos"
        '
        'lstCursos
        '
        Me.lstCursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCursos.FormattingEnabled = True
        Me.lstCursos.ItemHeight = 15
        Me.lstCursos.Location = New System.Drawing.Point(3, 19)
        Me.lstCursos.Name = "lstCursos"
        Me.lstCursos.Size = New System.Drawing.Size(150, 230)
        Me.lstCursos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAlunoCursos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(167, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 249)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Alunos e seus Cursos"
        '
        'btnLista
        '
        Me.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.Location = New System.Drawing.Point(422, 293)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLista.Size = New System.Drawing.Size(199, 31)
        Me.btnLista.TabIndex = 3
        Me.btnLista.Text = "&Lista Completa"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpçõesToolStripMenuItem, Me.btnFechar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCadastro})
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OpçõesToolStripMenuItem.Text = "Opções    |"
        '
        'btnCadastro
        '
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(152, 22)
        Me.btnCadastro.Text = "Cadastro"
        '
        'btnFechar
        '
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(54, 20)
        Me.btnFechar.Text = "Fechar"
        '
        'form_index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(631, 334)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form_index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realacionamento de Tabelas"
        CType(Me.dgvAlunoCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCursos As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents dgvAlunoCursos As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripMenuItem

End Class
