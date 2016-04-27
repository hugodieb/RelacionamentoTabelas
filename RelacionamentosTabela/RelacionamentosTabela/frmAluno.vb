Imports System.Data
Imports System.Data.OleDb

Public Class frmAluno

    Private Sub frmAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.carregaGridView()
    End Sub

    Private Sub carregaGridView()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT * FROM aluno"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                dgvAluno.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCloseAluno_Click(sender As Object, e As EventArgs) Handles btnCloseAluno.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddAluno_Click(sender As Object, e As EventArgs) Handles btnAddAluno.Click
        intCodAluno = dgvAluno.CurrentRow().Cells(0).Value
        strNomeAluno = dgvAluno.CurrentRow().Cells(1).Value

        Me.Dispose()
    End Sub
End Class