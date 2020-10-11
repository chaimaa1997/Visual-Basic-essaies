<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClickThis = New System.Windows.Forms.Button()
        Me.lblexecuter = New System.Windows.Forms.Label()
        Me.btnNon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClickThis
        '
        Me.btnClickThis.Location = New System.Drawing.Point(32, 142)
        Me.btnClickThis.Name = "btnClickThis"
        Me.btnClickThis.Size = New System.Drawing.Size(163, 72)
        Me.btnClickThis.TabIndex = 0
        Me.btnClickThis.Text = "OUI"
        Me.btnClickThis.UseVisualStyleBackColor = True
        '
        'lblexecuter
        '
        Me.lblexecuter.AutoSize = True
        Me.lblexecuter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblexecuter.Location = New System.Drawing.Point(92, 81)
        Me.lblexecuter.Name = "lblexecuter"
        Me.lblexecuter.Size = New System.Drawing.Size(274, 20)
        Me.lblexecuter.TabIndex = 1
        Me.lblexecuter.Text = "Voulez vous exécuter le programme ?"
        '
        'btnNon
        '
        Me.btnNon.Location = New System.Drawing.Point(275, 142)
        Me.btnNon.Name = "btnNon"
        Me.btnNon.Size = New System.Drawing.Size(162, 72)
        Me.btnNon.TabIndex = 2
        Me.btnNon.Text = "NON"
        Me.btnNon.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(474, 378)
        Me.Controls.Add(Me.btnNon)
        Me.Controls.Add(Me.lblexecuter)
        Me.Controls.Add(Me.btnClickThis)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Calculs avec 2 nombres"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickThis As Button
    Friend WithEvents lblexecuter As Label
    Friend WithEvents btnNon As Button
End Class
