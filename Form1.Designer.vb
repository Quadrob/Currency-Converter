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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.versionlable1 = New System.Windows.Forms.Label()
        Me.Proceed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell Nova Cond", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(541, 300)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'versionlable1
        '
        Me.versionlable1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.versionlable1.AutoSize = True
        Me.versionlable1.BackColor = System.Drawing.Color.Transparent
        Me.versionlable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionlable1.ForeColor = System.Drawing.Color.White
        Me.versionlable1.Location = New System.Drawing.Point(805, 15)
        Me.versionlable1.Name = "versionlable1"
        Me.versionlable1.Size = New System.Drawing.Size(65, 20)
        Me.versionlable1.TabIndex = 3
        Me.versionlable1.Text = "V: 1.0.0"
        '
        'Proceed
        '
        Me.Proceed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Proceed.BackColor = System.Drawing.Color.White
        Me.Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Proceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Proceed.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Proceed.FlatAppearance.BorderSize = 0
        Me.Proceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Proceed.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceed.ForeColor = System.Drawing.Color.Black
        Me.Proceed.Location = New System.Drawing.Point(340, 335)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(100, 30)
        Me.Proceed.TabIndex = 4
        Me.Proceed.Text = "Proceed"
        Me.Proceed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Proceed.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 403)
        Me.Controls.Add(Me.Proceed)
        Me.Controls.Add(Me.versionlable1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents versionlable1 As Label
    Friend WithEvents Proceed As Button
End Class
