<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.d = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.AllTotalText = New System.Windows.Forms.TextBox()
        Me.AllExtraText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExportBtn = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(108, 370)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(49, 15)
        Me.d.TabIndex = 1
        Me.d.Text = "All Total"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(122, 102)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 25
        Me.DGV.Size = New System.Drawing.Size(555, 213)
        Me.DGV.TabIndex = 2
        '
        'AllTotalText
        '
        Me.AllTotalText.Location = New System.Drawing.Point(195, 370)
        Me.AllTotalText.Name = "AllTotalText"
        Me.AllTotalText.Size = New System.Drawing.Size(100, 23)
        Me.AllTotalText.TabIndex = 3
        '
        'AllExtraText
        '
        Me.AllExtraText.Location = New System.Drawing.Point(405, 370)
        Me.AllExtraText.Name = "AllExtraText"
        Me.AllExtraText.Size = New System.Drawing.Size(100, 23)
        Me.AllExtraText.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "All Extra"
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(156, 36)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(321, 36)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(133, 23)
        Me.ExportBtn.TabIndex = 8
        Me.ExportBtn.Text = "Export To Excel"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AllExtraText)
        Me.Controls.Add(Me.AllTotalText)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.d)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents d As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents AllTotalText As TextBox
    Friend WithEvents AllExtraText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents ExportBtn As Button
End Class
