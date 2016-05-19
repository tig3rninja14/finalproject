<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ALEast = New System.Windows.Forms.DataGridView()
        Me.Team = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Losses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ALEast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALEast
        '
        Me.ALEast.AllowUserToDeleteRows = False
        Me.ALEast.AllowUserToResizeColumns = False
        Me.ALEast.AllowUserToResizeRows = False
        Me.ALEast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALEast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Team, Me.Wins, Me.Losses, Me.WinPerc})
        Me.ALEast.Location = New System.Drawing.Point(1, 2)
        Me.ALEast.Name = "ALEast"
        Me.ALEast.ReadOnly = True
        Me.ALEast.Size = New System.Drawing.Size(445, 233)
        Me.ALEast.TabIndex = 0
        '
        'Team
        '
        Me.Team.HeaderText = "Team"
        Me.Team.Name = "Team"
        '
        'Wins
        '
        Me.Wins.HeaderText = "Wins"
        Me.Wins.Name = "Wins"
        '
        'Losses
        '
        Me.Losses.HeaderText = "Losses"
        Me.Losses.Name = "Losses"
        '
        'WinPerc
        '
        Me.WinPerc.HeaderText = "Win %"
        Me.WinPerc.Name = "WinPerc"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 531)
        Me.Controls.Add(Me.ALEast)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.ALEast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ALEast As DataGridView
    Friend WithEvents Team As DataGridViewTextBoxColumn
    Friend WithEvents Wins As DataGridViewTextBoxColumn
    Friend WithEvents Losses As DataGridViewTextBoxColumn
    Friend WithEvents WinPerc As DataGridViewTextBoxColumn
End Class
