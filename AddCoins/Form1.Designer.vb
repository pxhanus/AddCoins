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
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtAmtQ = New System.Windows.Forms.TextBox()
        Me.txtAmtD = New System.Windows.Forms.TextBox()
        Me.txtAmtN = New System.Windows.Forms.TextBox()
        Me.txtAmtP = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(19, 23)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 0
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(19, 56)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 1
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(19, 90)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(45, 13)
        Me.lblNickels.TabIndex = 2
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(19, 120)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 3
        Me.lblPennies.Text = "Pennies:"
        '
        'txtAmtQ
        '
        Me.txtAmtQ.Location = New System.Drawing.Point(80, 20)
        Me.txtAmtQ.Name = "txtAmtQ"
        Me.txtAmtQ.Size = New System.Drawing.Size(50, 20)
        Me.txtAmtQ.TabIndex = 4
        '
        'txtAmtD
        '
        Me.txtAmtD.Location = New System.Drawing.Point(80, 53)
        Me.txtAmtD.Name = "txtAmtD"
        Me.txtAmtD.Size = New System.Drawing.Size(50, 20)
        Me.txtAmtD.TabIndex = 5
        '
        'txtAmtN
        '
        Me.txtAmtN.Location = New System.Drawing.Point(80, 87)
        Me.txtAmtN.Name = "txtAmtN"
        Me.txtAmtN.Size = New System.Drawing.Size(50, 20)
        Me.txtAmtN.TabIndex = 6
        '
        'txtAmtP
        '
        Me.txtAmtP.Location = New System.Drawing.Point(80, 117)
        Me.txtAmtP.Name = "txtAmtP"
        Me.txtAmtP.Size = New System.Drawing.Size(50, 20)
        Me.txtAmtP.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(173, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Coins"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(170, 90)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 148)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmtP)
        Me.Controls.Add(Me.txtAmtN)
        Me.Controls.Add(Me.txtAmtD)
        Me.Controls.Add(Me.txtAmtQ)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents txtAmtQ As System.Windows.Forms.TextBox
    Friend WithEvents txtAmtD As System.Windows.Forms.TextBox
    Friend WithEvents txtAmtN As System.Windows.Forms.TextBox
    Friend WithEvents txtAmtP As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
