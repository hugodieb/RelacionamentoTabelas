﻿Imports System.Data
Imports System.Data.OleDb

Module acesso

    Public intCodCurso As Integer
    Public intCodAluno As Integer
    Public strNomeCurso As String
    Public strNomeAluno As String

    Public Function getConnection() As OleDbConnection
        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\projetos_vb\CRUD\RelacionamentosTabela\joinner.accdb"

        Return New OleDbConnection(sql)
    End Function

End Module
