﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lstHighScore = New System.Windows.Forms.ListBox()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(98, 70)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(623, 25)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
        '
        'lstHighScore
        '
        Me.lstHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHighScore.ItemHeight = 20
        Me.lstHighScore.Items.AddRange(New Object() {"Name                          Score", "", "Rhonda                           5", "", "Dave                                5"})
        Me.lstHighScore.Location = New System.Drawing.Point(171, 145)
        Me.lstHighScore.Name = "lstHighScore"
        Me.lstHighScore.Size = New System.Drawing.Size(331, 144)
        Me.lstHighScore.TabIndex = 1
        '
        'btnAgain
        '
        Me.btnAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgain.Location = New System.Drawing.Point(544, 298)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(117, 43)
        Me.btnAgain.TabIndex = 2
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(544, 357)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(117, 50)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.lstHighScore)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents lstHighScore As ListBox
    Friend WithEvents btnAgain As Button
    Friend WithEvents btnQuit As Button
End Class
