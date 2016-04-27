<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurso
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
        Me.btnCloseCurso = New System.Windows.Forms.Button()
        Me.btnAddCurso = New System.Windows.Forms.Button()
        Me.dgvCurso = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCloseCurso
        '
        Me.btnCloseCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseCurso.Location = New System.Drawing.Point(335, 264)
        Me.btnCloseCurso.Name = "btnCloseCurso"
        Me.btnCloseCurso.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseCurso.TabIndex = 4
        Me.btnCloseCurso.Text = "Fechar"
        Me.btnCloseCurso.UseVisualStyleBackColor = True
        '
        'btnAddCurso
        '
        Me.btnAddCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCurso.Location = New System.Drawing.Point(254, 264)
        Me.btnAddCurso.Name = "btnAddCurso"
        Me.btnAddCurso.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCurso.TabIndex = 3
        Me.btnAddCurso.Text = "Adicionar"
        Me.btnAddCurso.UseVisualStyleBackColor = True
        '
        'dgvCurso
        '
        Me.dgvCurso.AllowUserToAddRows = False
        Me.dgvCurso.AllowUserToDeleteRows = False
        Me.dgvCurso.BackgroundColor = System.Drawing.Color.White
        Me.dgvCurso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCurso.Location = New System.Drawing.Point(3, 16)
        Me.dgvCurso.MultiSelect = False
        Me.dgvCurso.Name = "dgvCurso"
        Me.dgvCurso.ReadOnly = True
        Me.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCurso.Size = New System.Drawing.Size(392, 219)
        Me.dgvCurso.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCurso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 238)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'frmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 303)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCloseCurso)
        Me.Controls.Add(Me.btnAddCurso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curso"
        CType(Me.dgvCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCloseCurso As System.Windows.Forms.Button
    Friend WithEvents btnAddCurso As System.Windows.Forms.Button
    Friend WithEvents dgvCurso As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
