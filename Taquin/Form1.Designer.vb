﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identité
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButtonEt = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFr = New System.Windows.Forms.RadioButton()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.LabelPays = New System.Windows.Forms.Label()
        Me.TextBoxPays = New System.Windows.Forms.TextBox()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.PanelPays = New System.Windows.Forms.Panel()
        Me.PanelCP = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelPays.SuspendLayout()
        Me.PanelCP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Location = New System.Drawing.Point(21, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 169)
        Me.Panel1.TabIndex = 0
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(42, 20)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton5.TabIndex = 2
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Option1"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(42, 70)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Option2"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(42, 119)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Option3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButtonEt)
        Me.Panel2.Controls.Add(Me.RadioButtonFr)
        Me.Panel2.Location = New System.Drawing.Point(22, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 195)
        Me.Panel2.TabIndex = 1
        '
        'RadioButtonEt
        '
        Me.RadioButtonEt.AutoSize = True
        Me.RadioButtonEt.Location = New System.Drawing.Point(41, 110)
        Me.RadioButtonEt.Name = "RadioButtonEt"
        Me.RadioButtonEt.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonEt.TabIndex = 1
        Me.RadioButtonEt.TabStop = True
        Me.RadioButtonEt.Text = "etranger"
        Me.RadioButtonEt.UseVisualStyleBackColor = True
        '
        'RadioButtonFr
        '
        Me.RadioButtonFr.AutoSize = True
        Me.RadioButtonFr.Location = New System.Drawing.Point(41, 51)
        Me.RadioButtonFr.Name = "RadioButtonFr"
        Me.RadioButtonFr.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonFr.TabIndex = 0
        Me.RadioButtonFr.TabStop = True
        Me.RadioButtonFr.Text = "francais"
        Me.RadioButtonFr.UseVisualStyleBackColor = True
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(250, 121)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(60, 13)
        Me.LabelPrenom.TabIndex = 2
        Me.LabelPrenom.Text = "PRENOM :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(250, 37)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(38, 13)
        Me.LabelNom.TabIndex = 3
        Me.LabelNom.Text = "NOM :"
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = True
        Me.LabelCP.Location = New System.Drawing.Point(5, 23)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(62, 13)
        Me.LabelCP.TabIndex = 4
        Me.LabelCP.Text = "code postal"
        '
        'LabelPays
        '
        Me.LabelPays.AutoSize = True
        Me.LabelPays.Location = New System.Drawing.Point(11, 17)
        Me.LabelPays.Name = "LabelPays"
        Me.LabelPays.Size = New System.Drawing.Size(29, 13)
        Me.LabelPays.TabIndex = 5
        Me.LabelPays.Text = "pays"
        '
        'TextBoxPays
        '
        Me.TextBoxPays.Location = New System.Drawing.Point(84, 11)
        Me.TextBoxPays.Name = "TextBoxPays"
        Me.TextBoxPays.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPays.TabIndex = 6
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Location = New System.Drawing.Point(89, 16)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxCP.TabIndex = 7
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(333, 34)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxNom.TabIndex = 8
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(337, 118)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxPrenom.TabIndex = 9
        '
        'PanelPays
        '
        Me.PanelPays.Controls.Add(Me.TextBoxPays)
        Me.PanelPays.Controls.Add(Me.LabelPays)
        Me.PanelPays.Location = New System.Drawing.Point(248, 369)
        Me.PanelPays.Name = "PanelPays"
        Me.PanelPays.Size = New System.Drawing.Size(205, 56)
        Me.PanelPays.TabIndex = 10
        Me.PanelPays.Visible = False
        '
        'PanelCP
        '
        Me.PanelCP.Controls.Add(Me.TextBoxCP)
        Me.PanelCP.Controls.Add(Me.LabelCP)
        Me.PanelCP.Location = New System.Drawing.Point(243, 255)
        Me.PanelCP.Name = "PanelCP"
        Me.PanelCP.Size = New System.Drawing.Size(233, 61)
        Me.PanelCP.TabIndex = 11
        Me.PanelCP.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Validation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(265, 481)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Arrêt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Identité
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 537)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelCP)
        Me.Controls.Add(Me.PanelPays)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Identité"
        Me.Text = "Identité"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelPays.ResumeLayout(False)
        Me.PanelPays.PerformLayout()
        Me.PanelCP.ResumeLayout(False)
        Me.PanelCP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents LabelPrenom As Windows.Forms.Label
    Friend WithEvents LabelNom As Windows.Forms.Label
    Friend WithEvents LabelCP As Windows.Forms.Label
    Friend WithEvents LabelPays As Windows.Forms.Label
    Friend WithEvents TextBoxPays As Windows.Forms.TextBox
    Friend WithEvents TextBoxCP As Windows.Forms.TextBox
    Friend WithEvents TextBoxNom As Windows.Forms.TextBox
    Friend WithEvents TextBoxPrenom As Windows.Forms.TextBox
    Friend WithEvents RadioButtonFr As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEt As Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As Windows.Forms.RadioButton
    Friend WithEvents PanelPays As Windows.Forms.Panel
    Friend WithEvents PanelCP As Windows.Forms.Panel
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
