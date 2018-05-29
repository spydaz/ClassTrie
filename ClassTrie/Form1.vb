Public Class Form1
    Dim MyTree As New TrieNode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyTree.Insert(MyTree, TextBox2.Text)

        TextBox1.AppendText("Added : " & TextBox2.Text.ToUpper & vbNewLine)
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(MyTree.ToView)
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
        TextBox1.Text = TextBox2.Text & ": " & MyTree.FindWord(MyTree, TextBox2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox2.Text & ": " & MyTree.FindPrefix(MyTree, TextBox2.Text)
    End Sub


End Class