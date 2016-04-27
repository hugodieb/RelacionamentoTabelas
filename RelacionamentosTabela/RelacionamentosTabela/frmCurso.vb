Imports System.Data
Imports System.Data.OleDb

Public Class frmCurso

    Private Sub frmCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.carregaGridView()
    End Sub

    Private Sub carregaGridView()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT * FROM curso"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                dgvCurso.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnCloseCurso_Click(sender As Object, e As EventArgs) Handles btnCloseCurso.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddCurso_Click(sender As Object, e As EventArgs) Handles btnAddCurso.Click
        intCodCurso = dgvCurso.CurrentRow().Cells(0).Value
        strNomeCurso = dgvCurso.CurrentRow().Cells(1).Value

        Me.Dispose()
    End Sub
End Class