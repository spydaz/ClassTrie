Public Module Trees

    Public Structure TrieNode
        ''' <summary>
        ''' Each Set of Nodes has only 26 ID's ID 0 = stop
        ''' </summary>
        Public Enum CharID
            StartChar = 0
            a = 1
            b = 2
            c = 3
            d = 4
            e = 5
            f = 6
            g = 7
            h = 8
            i = 9
            j = 10
            k = 11
            l = 12
            m = 13
            n = 14
            o = 15
            p = 16
            q = 17
            r = 18
            s = 19
            t = 20
            u = 21
            v = 22
            w = 23
            x = 24
            y = 25
            z = 26
            StopChar = 27
        End Enum
        Public Sub New(ByRef mLevel As Integer)
            Children = New List(Of TrieNode)
            Level = mLevel
        End Sub
        Private Shared Function MakeTrieTree() As TrieNode
            Dim tree As New TrieNode(0)

            tree.NodeData = "Root"
            tree.NodeID = CharID.StartChar
            Return tree
        End Function
        ''' <summary>
        ''' Character held in str
        ''' </summary>
        Public NodeData As String
        Public NodeID As CharID
        Public Children As List(Of TrieNode)
        Public Level As Integer
        ''' <summary>
        ''' If node does not exist in child node set it is added 
        ''' if node already exists then no node is added a node ID is generated
        ''' </summary>
        ''' <param name="NodeData">Character to be added</param>
        Private Shared Function CreateNode(ByRef NodeData As String, ByRef Level As Integer) As TrieNode

            'Create node - 2
            Dim NewNode As New TrieNode(Level)
            NewNode.NodeData = NodeData
            'create id
            NewNode.NodeID = GenerateNodeID(NodeData)



            Return NewNode
        End Function
        ''' <summary>
        ''' Generates an ID from NodeData
        ''' </summary>
        ''' <param name="Nodedata">Character string for node</param>
        ''' <returns></returns>
        Private Shared Function GenerateNodeID(ByRef Nodedata As String) As CharID
            Dim Newnode As New TrieNode
            'SET ID for node
            Select Case Nodedata.ToUpper
                Case "STOPCHAR"
                    Newnode.NodeID = CharID.StopChar
                Case "A"
                    Newnode.NodeID = CharID.a
                Case "B"
                    Newnode.NodeID = CharID.b
                Case "C"
                    Newnode.NodeID = CharID.c
                Case "D"
                    Newnode.NodeID = CharID.d
                Case "E"
                    Newnode.NodeID = CharID.e
                Case "F"
                    Newnode.NodeID = CharID.f
                Case "G"
                    Newnode.NodeID = CharID.g
                Case "H"
                    Newnode.NodeID = CharID.h
                Case "I"
                    Newnode.NodeID = CharID.i
                Case "J"
                    Newnode.NodeID = CharID.j
                Case "K"
                    Newnode.NodeID = CharID.k
                Case "L"
                    Newnode.NodeID = CharID.l
                Case "M"
                    Newnode.NodeID = CharID.m
                Case "N"
                    Newnode.NodeID = CharID.n
                Case "O"
                    Newnode.NodeID = CharID.o
                Case "P"
                    Newnode.NodeID = CharID.p
                Case "Q"
                    Newnode.NodeID = CharID.q
                Case "R"
                    Newnode.NodeID = CharID.r
                Case "S"
                    Newnode.NodeID = CharID.s
                Case "T"
                    Newnode.NodeID = CharID.t
                Case "U"
                    Newnode.NodeID = CharID.u
                Case "V"
                    Newnode.NodeID = CharID.v
                Case "W"
                    Newnode.NodeID = CharID.w
                Case "X"
                    Newnode.NodeID = CharID.x
                Case "Y"
                    Newnode.NodeID = CharID.y
                Case "Z"
                    Newnode.NodeID = CharID.z
            End Select
            Return Newnode.NodeID
        End Function
        ''' <summary>
        ''' checks if node exists in child nodes
        ''' </summary>
        ''' <param name="Nodedata">Char string</param>
        ''' <returns></returns>
        Private Shared Function CheckNodeExists(ByRef Children As List(Of TrieNode), ByRef Nodedata As String) As Boolean
            'Check node does not exist
            Dim found As Boolean = False
            For Each mNode As TrieNode In Children
                If mNode.NodeData = Nodedata Then
                    found = True
                Else
                End If
            Next
            Return found
        End Function
        ''' <summary>
        ''' Checks if Character exists in children of given Sibling List
        ''' </summary>
        ''' <param name="Children"></param>
        ''' <param name="LocChar"></param>
        ''' <returns></returns>
        Public Shared Function CheckCharExists(ByRef Children As List(Of TrieNode), ByRef LocChar As String) As Boolean
            'Check node does not exist
            Dim found As Boolean = False
            For Each mNode As TrieNode In Children
                If mNode.NodeData = LocChar Then
                    found = True
                Else
                End If
            Next
            Return found
        End Function
        ''' <summary>
        ''' Checks if Character exists in children of node
        ''' </summary>
        ''' <param name="LocChar"></param>
        ''' <returns></returns>
        Public Function CheckCharExists(ByRef LocChar As String) As Boolean
            'Check node does not exist
            Dim found As Boolean = False
            For Each mNode As TrieNode In Me.Children
                If mNode.NodeData = LocChar Then
                    found = True
                Else
                End If
            Next
            Return found
        End Function
        Private Shared Function GetNode(ByRef Tree As List(Of TrieNode), ByRef NodeData As String) As TrieNode
            Dim Foundnode As New TrieNode
            For Each item In Tree
                If item.NodeData = NodeData Then
                    Foundnode = item
                Else
                End If
            Next
            Return Foundnode
        End Function
        ''' <summary>
        ''' Checks if given node has children 
        ''' </summary>
        ''' <param name="Node"></param>
        ''' <returns></returns>
        Public Shared Function HasChildren(ByRef Node As TrieNode) As Boolean
            Return If(Node.Children IsNot Nothing, True, False)
        End Function
        ''' <summary>
        ''' Checks if node Has children
        ''' </summary>
        ''' <returns></returns>
        Public Function HasChildren() As Boolean
            Return If(Me.Children IsNot Nothing, True, False)
        End Function
        ''' <summary>
        ''' Adds char to Node(children) Returning the child
        ''' </summary>
        ''' <param name="CurrentNode">node containing children</param>
        ''' <param name="ChrStr">String to be added </param>
        ''' <param name="CharPos">this denotes the level of the node</param>
        ''' <returns></returns>
        Private Shared Function AddCharToTrie(ByRef CurrentNode As TrieNode, ByRef ChrStr As String, ByRef CharPos As Integer) As TrieNode
            'start of tree

            Dim Text As String = ChrStr
            Dim returnNode As New TrieNode
            Dim NewNode As New TrieNode
            'Goto first node

            'does this node have siblings
            If TrieNode.HasChildren(CurrentNode) = True Then
                'Check children
                If TrieNode.CheckNodeExists(CurrentNode.Children, ChrStr) = False Then
                    'create a new node for char
                    NewNode = TrieNode.CreateNode(ChrStr, CurrentNode.Level + 1)
                    NewNode.Level = CharPos
                    'Add childnode 
                    CurrentNode.Children.Add(NewNode)
                    returnNode = TrieNode.GetNode(CurrentNode.Children, ChrStr)
                Else
                    returnNode = TrieNode.GetNode(CurrentNode.Children, ChrStr)
                End If

            Else
                'If no silings then Create new node
                'create a new node for char
                NewNode = TrieNode.CreateNode(ChrStr, CurrentNode.Level + 1)
                NewNode.Level = CharPos
                'Add childnode 
                CurrentNode.Children.Add(NewNode)
                returnNode = TrieNode.GetNode(CurrentNode.Children, ChrStr)
            End If

            Return returnNode
        End Function
        ''' <summary>
        ''' Adds string to given trie
        ''' </summary>
        ''' <param name="Tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Shared Function AddString(ByRef Tree As TrieNode, Str As String) As TrieNode
            Dim curr As TrieNode = Tree
            Dim Pos As Integer = 0
            For Each chr As Char In Str
                Pos += 1
                curr = TrieNode.AddCharToTrie(curr, chr, Pos)
            Next
            curr = TrieNode.AddCharToTrie(curr, "StopChar", Pos + 1)
            Return Tree
        End Function
        ''' <summary>
        ''' Returns true if string is contined in trie (prefix) not as Word
        ''' </summary>
        ''' <param name="tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Shared Function CheckPrefix(ByRef tree As TrieNode, ByRef Str As String) As Boolean
            Dim CurrentNode As TrieNode = tree
            Dim found As Boolean = False

            Dim Pos As Integer = 0
            For Each chrStr As Char In Str
                Pos += 1


                'Check Chars
                If TrieNode.CheckNodeExists(CurrentNode.Children, chrStr) = True Then
                    CurrentNode = TrieNode.GetNode(CurrentNode.Children, chrStr)
                    found = True
                Else
                    found = False
                End If
            Next
            Return found
        End Function
        ''' <summary>
        ''' Returns true if Word is found in trie
        ''' </summary>
        ''' <param name="tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Shared Function CheckWord(ByRef tree As TrieNode, ByRef Str As String) As Boolean
            Dim CurrentNode As TrieNode = tree
            Dim found As Boolean = False
            'Position in Characterstr
            Dim Pos As Integer = 0
            For Each chrStr As Char In Str
                Pos += 1


                'Check Chars
                If TrieNode.CheckNodeExists(CurrentNode.Children, chrStr) = True Then
                    CurrentNode = TrieNode.GetNode(CurrentNode.Children, chrStr)
                    found = True
                Else
                    'Terminated before end of Word
                    found = False
                End If
            Next

            'Check for end of word marker
            Return If(found = True, TrieNode.CheckNodeExists(CurrentNode.Children, "StopChar") = True, False)



        End Function
        ''' <summary>
        ''' Creates a trie
        ''' </summary>
        ''' <returns></returns>
        Public Function Create() As TrieNode
            Return TrieNode.MakeTrieTree()
        End Function
        ''' <summary>
        ''' Insert String into trie
        ''' </summary>
        ''' <param name="tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function Insert(ByRef tree As TrieNode, ByRef Str As String) As TrieNode
            Return TrieNode.AddString(tree, Str)
        End Function
        ''' <summary>
        ''' Checks if PRefix is in trie
        ''' </summary>
        ''' <param name="tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function FindPrefix(ByRef tree As TrieNode, ByRef Str As String) As Boolean

            Return TrieNode.CheckPrefix(tree, Str)
        End Function
        ''' <summary>
        ''' Checks if word is in trie
        ''' </summary>
        ''' <param name="tree"></param>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function FindWord(ByRef tree As TrieNode, ByRef Str As String) As Boolean
            Return TrieNode.CheckWord(tree, Str)
        End Function
        ''' <summary>
        ''' Displays Contents of trie
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function ToString() As String
            Dim wrd As String = ""
            Dim Str As String = "NodeID " & Me.NodeID.ToString & vbNewLine &
            "Data: " & Me.NodeData & vbNewLine &
            "Node Level: " & Level.ToString & vbNewLine
            For Each child In Me.Children
                Str &= "Child: " & child.ToString()



            Next
            Return Str

        End Function
        ''' <summary>
        ''' Returns a TreeViewControl with the Contents of the Trie:
        ''' </summary>
        ''' <returns></returns>
        Public Function ToView() As System.Windows.Forms.TreeNode
            Dim nde As New System.Windows.Forms.TreeNode
            nde.Text = Me.NodeData.ToString.ToUpper & vbNewLine &
                "(" & Me.Level & ")" & vbNewLine

            For Each child In Me.Children
                nde.Nodes.Add(child.ToView)

            Next

            Return nde

        End Function
        ''' <summary>
        ''' Inserts a string into the trie
        ''' </summary>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function Insert(ByRef Str As String) As TrieNode
            Return TrieNode.AddString(Me, Str)
        End Function
        ''' <summary>
        ''' Returns true if String is found as a prefix in trie
        ''' </summary>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function FindPrefix(ByRef Str As String) As Boolean

            Return TrieNode.CheckPrefix(Me, Str)
        End Function
        ''' <summary>
        ''' Returns true if string is found as word in trie
        ''' </summary>
        ''' <param name="Str"></param>
        ''' <returns></returns>
        Public Function FindWord(ByRef Str As String) As Boolean
            Return TrieNode.CheckWord(Me, Str)
        End Function
    End Structure
    Function Delete(ByRef tree As TrieNode, ByRef Str As String) As TrieNode
        Return tree
    End Function
End Module
