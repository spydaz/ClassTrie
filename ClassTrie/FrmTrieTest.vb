﻿

Public Class FrmTrieTest
    Dim MyTree As New TreeNode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyTree.Insert(TextBox2.Text)

        TextBox1.AppendText("Added : " & TextBox2.Text.ToUpper & vbNewLine)
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(MyTree.ToView())


        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTree = MyTree.Create
        TextBox1.AppendText("Created : " & vbNewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.AppendText(TextBox2.Text & ": " & MyTree.FindWord(TextBox2.Text) & vbNewLine)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.AppendText(TextBox2.Text & ": " & MyTree.FindPrefix(TextBox2.Text))
    End Sub

    Private Sub ButtonDepth_Click(sender As Object, e As EventArgs) Handles ButtonDepth.Click
        TextBox1.AppendText("Deepest Node :" & MyTree.LowestLevel - 1 & vbNewLine)
    End Sub

    Private Sub ButtonTotal_Click(sender As Object, e As EventArgs) Handles ButtonTotal.Click
        TextBox1.AppendText("Number of Nodes :" & MyTree.CountNodes(0) - MyTree.CountWords(0) & vbNewLine)
    End Sub

    Private Sub ButtonCountWords_Click(sender As Object, e As EventArgs) Handles ButtonCountWords.Click
        TextBox1.AppendText("Number of Words :" & MyTree.CountWords(0) & vbNewLine)
    End Sub
End Class