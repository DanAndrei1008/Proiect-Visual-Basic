<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Inapoi = New System.Windows.Forms.Button()
        Me.Exit1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 351)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(753, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APLICATIE CREATA DE: Dumitru Denisa-Maria, Dan-Andrei Dosius, Ilie Cornel-Marian," &
    " Florea Catalin-Ionut"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(866, 176)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inapoi
        '
        Me.Inapoi.BackColor = System.Drawing.Color.FloralWhite
        Me.Inapoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Inapoi.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inapoi.Location = New System.Drawing.Point(900, 435)
        Me.Inapoi.Margin = New System.Windows.Forms.Padding(4)
        Me.Inapoi.Name = "Inapoi"
        Me.Inapoi.Size = New System.Drawing.Size(146, 40)
        Me.Inapoi.TabIndex = 35
        Me.Inapoi.Text = "Inapoi"
        Me.Inapoi.UseVisualStyleBackColor = False
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.Color.FloralWhite
        Me.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exit1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Exit1.Location = New System.Drawing.Point(900, 483)
        Me.Exit1.Margin = New System.Windows.Forms.Padding(4)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(146, 41)
        Me.Exit1.TabIndex = 46
        Me.Exit1.Text = "EXIT"
        Me.Exit1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "REGULI"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ListaBazaDate.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1059, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.Inapoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "REGULI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Inapoi As Button
    Friend WithEvents Exit1 As Button
    Friend WithEvents Label3 As Label
End Class
