Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrieTest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrieTest))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCountWords = New System.Windows.Forms.Button()
        Me.ButtonDepth = New System.Windows.Forms.Button()
        Me.ButtonTotal = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.Info
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeView1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.LineColor = System.Drawing.Color.Navy
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(1176, 293)
        Me.TreeView1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TreeView1, "Suffix Trie")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.ButtonCountWords)
        Me.GroupBox1.Controls.Add(Me.ButtonDepth)
        Me.GroupBox1.Controls.Add(Me.ButtonTotal)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1176, 351)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'ButtonCountWords
        '
        Me.ButtonCountWords.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonCountWords.Location = New System.Drawing.Point(703, 263)
        Me.ButtonCountWords.Name = "ButtonCountWords"
        Me.ButtonCountWords.Size = New System.Drawing.Size(110, 33)
        Me.ButtonCountWords.TabIndex = 9
        Me.ButtonCountWords.Text = "Word Count"
        Me.ToolTip1.SetToolTip(Me.ButtonCountWords, "Counts how many words are in the tree")
        Me.ButtonCountWords.UseVisualStyleBackColor = False
        '
        'ButtonDepth
        '
        Me.ButtonDepth.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonDepth.Location = New System.Drawing.Point(819, 263)
        Me.ButtonDepth.Name = "ButtonDepth"
        Me.ButtonDepth.Size = New System.Drawing.Size(75, 33)
        Me.ButtonDepth.TabIndex = 8
        Me.ButtonDepth.Text = "Depth"
        Me.ToolTip1.SetToolTip(Me.ButtonDepth, "Finds the Deepest Node (- the StopChar)")
        Me.ButtonDepth.UseVisualStyleBackColor = False
        '
        'ButtonTotal
        '
        Me.ButtonTotal.BackColor = System.Drawing.Color.LightSlateGray
        Me.ButtonTotal.Location = New System.Drawing.Point(622, 263)
        Me.ButtonTotal.Name = "ButtonTotal"
        Me.ButtonTotal.Size = New System.Drawing.Size(75, 33)
        Me.ButtonTotal.TabIndex = 7
        Me.ButtonTotal.Text = "Nodes"
        Me.ToolTip1.SetToolTip(Me.ButtonTotal, "Counts total odes in tree")
        Me.ButtonTotal.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.Location = New System.Drawing.Point(143, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 33)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Find Word"
        Me.ToolTip1.SetToolTip(Me.Button3, "Finds complete word in tree")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button4.Location = New System.Drawing.Point(12, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 33)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Find Prefix"
        Me.ToolTip1.SetToolTip(Me.Button4, "finds word as prefix")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 318)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1170, 30)
        Me.TextBox2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Interactive text window")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1170, 237)
        Me.TextBox1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Interactive display")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.Location = New System.Drawing.Point(1091, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Button2, "Clears the info screen")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button5.Location = New System.Drawing.Point(407, 263)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 33)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Add Word"
        Me.ToolTip1.SetToolTip(Me.Button5, "Adds word as suffix tree")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.Location = New System.Drawing.Point(274, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Word"
        Me.ToolTip1.SetToolTip(Me.Button1, "Add a single word into the tree")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmTrieTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1176, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTrieTest"
        Me.Text = "Trie - Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ButtonDepth As Button
    Friend WithEvents ButtonTotal As Button
    Friend WithEvents ButtonCountWords As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
