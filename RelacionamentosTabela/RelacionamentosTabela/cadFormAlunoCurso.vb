﻿Imports System.Data
Imports System.Data.OleDb

Public Class cadFormAlunoCurso

    Private Sub btnPesquisarCurso_Click(sender As Object, e As EventArgs) Handles btnPesquisarCurso.Click
        frmCurso.ShowDialog()
        txtCodCurso.Text = intCodCurso
        txtNomeCurso.Text = strNomeCurso
    End Sub

    Private Sub btnPesquisarAluno_Click(sender As Object, e As EventArgs) Handles btnPesquisarAluno.Click
        frmAluno.ShowDialog()
        txtCodAluno.Text = intCodAluno
        txtNomeAluno.Text = strNomeAluno
    End Sub

    Private Sub btnSalvarAlunoCurso_Click(sender As Object, e As EventArgs) Handles btnSalvarAlunoCurso.Click

        If validaCampos() = False Then Exit Sub
        If verificaAlunoCurso() = False Then Exit Sub
        gravaAlunoCurso()

    End Sub

    Private Sub btnCancelarAlunoCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAlunoCurso.Click
        Me.Dispose()
    End Sub

    Private Sub gravaAlunoCurso()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "INSERT INTO alunoCurso (idAluno, idCurso) VALUES (?,?)"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("idAluno", txtCodAluno.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("idCurso", txtCodCurso.Text))

                cmd.ExecuteNonQuery()

                limpacadFormAlunoCurso()
                MsgBox("Dados salvos com sucesso", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Private Function verificaAlunoCurso() As Boolean
        Dim intResultQuery As Integer
        Dim sql As String

        Using con As OleDbConnection = getConnection()

            Try
                con.Open()
                sql = "SELECT COUNT(*) FROM alunoCurso WHERE idAluno=" & txtCodAluno.Text & "AND idCurso=" & txtCodCurso.Text

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                intResultQuery = cmd.ExecuteScalar

                If intResultQuery > 0 Then
                    MsgBox("Aluno ja cadastrado para este curso.", MsgBoxStyle.Information)

                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                con.Close()
            End Try

        End Using

        Return True
    End Function

    Private Function validaCampos() As Boolean

        If txtCodAluno.Text = "" Then
            MsgBox("Informe o código do aluno", MsgBoxStyle.Information)
            Return False
        End If

        If txtCodCurso.Text = "" Then
            MsgBox("Informe o código do curso", MsgBoxStyle.Information)
            Return False
        End If

        Return True
    End Function

    Private Sub limpacadFormAlunoCurso()
        txtCodAluno.Text = ""
        txtCodCurso.Text = ""
        txtNomeAluno.Text = ""
        txtNomeCurso.Text = ""
    End Sub

End Class