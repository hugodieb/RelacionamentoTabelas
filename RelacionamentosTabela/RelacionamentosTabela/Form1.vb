Imports System.Data.OleDb

Public Class form_index

    Private Sub form_index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        carregaListBox()

    End Sub

    Private Sub carregaListBox()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "select * from curso"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                lstCursos.ValueMember = "idCurso"
                lstCursos.DisplayMember = "curso"

                lstCursos.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub carregaGridView()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT aluno.idAluno, aluno.nome, curso.curso, curso.idCurso "
                sql += "FROM curso INNER JOIN (aluno INNER JOIN alunoCurso ON aluno.[idAluno] = alunoCurso.[idAluno]) ON "
                sql += "curso.[idCurso] = alunoCurso.[idCurso];"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                dgvAlunoCursos.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub carregaListaAlunosCursos()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT aluno.idAluno, aluno.nome, curso.curso, curso.idCurso "
                sql += "FROM curso INNER JOIN (aluno INNER JOIN alunoCurso ON aluno.[idAluno] = alunoCurso.[idAluno]) ON "
                sql += "curso.[idCurso] = alunoCurso.[idCurso]"
                sql += "where curso.[idCurso]=" & lstCursos.SelectedValue

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                dgvAlunoCursos.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub formataGrid()
        With dgvAlunoCursos
            .Columns(0).HeaderText = "Código Aluno"
            .Columns(1).HeaderText = "Nome Aluno"
            .Columns(2).HeaderText = "Nome Curso"
            .Columns(3).HeaderText = "Código Curso"

            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub

    Private Sub lstCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCursos.SelectedIndexChanged
        carregaListaAlunosCursos()
        formataGrid()
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        carregaGridView()
        formataGrid()
    End Sub
End Class
