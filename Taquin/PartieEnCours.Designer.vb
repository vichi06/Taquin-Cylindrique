<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PartieEnCours
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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.LabelTempsRestant = New System.Windows.Forms.Label()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.LabelChrono = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.ButtonPausePlay = New System.Windows.Forms.Button()
        Me.ButtonRésoudre = New System.Windows.Forms.Button()
        Me.LabelWaiting = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LabelNbClick = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomJoueur.Location = New System.Drawing.Point(216, 295)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(163, 20)
        Me.LabelNomJoueur.TabIndex = 0
        Me.LabelNomJoueur.Text = "LabelNomJoueur"
        '
        'LabelTempsRestant
        '
        Me.LabelTempsRestant.AutoSize = True
        Me.LabelTempsRestant.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempsRestant.Location = New System.Drawing.Point(132, 339)
        Me.LabelTempsRestant.Name = "LabelTempsRestant"
        Me.LabelTempsRestant.Size = New System.Drawing.Size(196, 20)
        Me.LabelTempsRestant.TabIndex = 1
        Me.LabelTempsRestant.Text = "LabelTempsRestant"
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbandonner.Location = New System.Drawing.Point(31, 434)
        Me.ButtonAbandonner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(139, 49)
        Me.ButtonAbandonner.TabIndex = 2
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'TimerGame
        '
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChrono.Location = New System.Drawing.Point(29, 339)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(97, 20)
        Me.LabelChrono.TabIndex = 18
        Me.LabelChrono.Text = "Chrono :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(27, 295)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(174, 20)
        Me.LabelNom.TabIndex = 19
        Me.LabelNom.Text = "Nom du joueur :"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(23, 140)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 50)
        Me.Button9.TabIndex = 11
        Me.Button9.TabStop = False
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(211, 84)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 50)
        Me.Button8.TabIndex = 10
        Me.Button8.TabStop = False
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(85, 140)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(60, 50)
        Me.Button10.TabIndex = 12
        Me.Button10.TabStop = False
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(148, 82)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 50)
        Me.Button7.TabIndex = 9
        Me.Button7.TabStop = False
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(148, 140)
        Me.Button11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(60, 50)
        Me.Button11.TabIndex = 13
        Me.Button11.TabStop = False
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(85, 84)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 50)
        Me.Button6.TabIndex = 8
        Me.Button6.TabStop = False
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(211, 139)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(60, 50)
        Me.Button12.TabIndex = 14
        Me.Button12.TabStop = False
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(23, 84)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 50)
        Me.Button5.TabIndex = 7
        Me.Button5.TabStop = False
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(211, 28)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 50)
        Me.Button4.TabIndex = 6
        Me.Button4.TabStop = False
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(85, 194)
        Me.Button14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(60, 50)
        Me.Button14.TabIndex = 16
        Me.Button14.TabStop = False
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(148, 28)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.TabStop = False
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(148, 194)
        Me.Button15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(60, 50)
        Me.Button15.TabIndex = 17
        Me.Button15.TabStop = False
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(85, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 50)
        Me.Button2.TabIndex = 4
        Me.Button2.TabStop = False
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 50)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(23, 194)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(60, 50)
        Me.Button13.TabIndex = 15
        Me.Button13.TabStop = False
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(211, 194)
        Me.Button16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(60, 50)
        Me.Button16.TabIndex = 20
        Me.Button16.TabStop = False
        Me.Button16.Text = "Button16"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.Button16)
        Me.PanelButtons.Controls.Add(Me.Button13)
        Me.PanelButtons.Controls.Add(Me.Button1)
        Me.PanelButtons.Controls.Add(Me.Button3)
        Me.PanelButtons.Controls.Add(Me.Button15)
        Me.PanelButtons.Controls.Add(Me.Button14)
        Me.PanelButtons.Controls.Add(Me.Button2)
        Me.PanelButtons.Controls.Add(Me.Button4)
        Me.PanelButtons.Controls.Add(Me.Button10)
        Me.PanelButtons.Controls.Add(Me.Button5)
        Me.PanelButtons.Controls.Add(Me.Button12)
        Me.PanelButtons.Controls.Add(Me.Button6)
        Me.PanelButtons.Controls.Add(Me.Button11)
        Me.PanelButtons.Controls.Add(Me.Button7)
        Me.PanelButtons.Controls.Add(Me.Button8)
        Me.PanelButtons.Controls.Add(Me.Button9)
        Me.PanelButtons.Location = New System.Drawing.Point(31, 22)
        Me.PanelButtons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(299, 261)
        Me.PanelButtons.TabIndex = 21
        '
        'ButtonPausePlay
        '
        Me.ButtonPausePlay.Enabled = False
        Me.ButtonPausePlay.Font = New System.Drawing.Font("OCR A Extended", 11.0!)
        Me.ButtonPausePlay.Location = New System.Drawing.Point(179, 434)
        Me.ButtonPausePlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonPausePlay.Name = "ButtonPausePlay"
        Me.ButtonPausePlay.Size = New System.Drawing.Size(149, 49)
        Me.ButtonPausePlay.TabIndex = 22
        Me.ButtonPausePlay.Text = "Pause/Play"
        Me.ButtonPausePlay.UseVisualStyleBackColor = True
        '
        'ButtonRésoudre
        '
        Me.ButtonRésoudre.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRésoudre.Location = New System.Drawing.Point(116, 378)
        Me.ButtonRésoudre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRésoudre.Name = "ButtonRésoudre"
        Me.ButtonRésoudre.Size = New System.Drawing.Size(123, 50)
        Me.ButtonRésoudre.TabIndex = 23
        Me.ButtonRésoudre.Text = "Résoudre"
        Me.ButtonRésoudre.UseVisualStyleBackColor = True
        '
        'LabelWaiting
        '
        Me.LabelWaiting.AutoSize = True
        Me.LabelWaiting.Location = New System.Drawing.Point(277, 398)
        Me.LabelWaiting.Name = "LabelWaiting"
        Me.LabelWaiting.Size = New System.Drawing.Size(0, 17)
        Me.LabelWaiting.TabIndex = 24
        '
        'LabelNbClick
        '
        Me.LabelNbClick.AutoSize = True
        Me.LabelNbClick.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbClick.Location = New System.Drawing.Point(245, 396)
        Me.LabelNbClick.Name = "LabelNbClick"
        Me.LabelNbClick.Size = New System.Drawing.Size(116, 17)
        Me.LabelNbClick.TabIndex = 25
        Me.LabelNbClick.Text = "LabelNbClick"
        '
        'PartieEnCours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 505)
        Me.Controls.Add(Me.LabelNbClick)
        Me.Controls.Add(Me.LabelWaiting)
        Me.Controls.Add(Me.ButtonRésoudre)
        Me.Controls.Add(Me.ButtonPausePlay)
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelChrono)
        Me.Controls.Add(Me.ButtonAbandonner)
        Me.Controls.Add(Me.LabelTempsRestant)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PartieEnCours"
        Me.Text = "Jeu"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
    Friend WithEvents ButtonAbandonner As Windows.Forms.Button
    Friend WithEvents LabelTempsRestant As Windows.Forms.Label
    Friend WithEvents LabelNomJoueur As Windows.Forms.Label
    Friend WithEvents TimerGame As Windows.Forms.Timer
    Friend WithEvents LabelNom As Windows.Forms.Label
    Friend WithEvents LabelChrono As Windows.Forms.Label
    Friend WithEvents PanelButtons As Windows.Forms.Panel
    Friend WithEvents Button16 As Windows.Forms.Button
    Friend WithEvents Button13 As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button15 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button14 As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents Button12 As Windows.Forms.Button
    Friend WithEvents Button6 As Windows.Forms.Button
    Friend WithEvents Button11 As Windows.Forms.Button
    Friend WithEvents Button7 As Windows.Forms.Button
    Friend WithEvents Button10 As Windows.Forms.Button
    Friend WithEvents Button8 As Windows.Forms.Button
    Friend WithEvents Button9 As Windows.Forms.Button
    Friend WithEvents ButtonPausePlay As Windows.Forms.Button
    Friend WithEvents ButtonRésoudre As Windows.Forms.Button
    Friend WithEvents LabelWaiting As Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As ComponentModel.BackgroundWorker
    Friend WithEvents LabelNbClick As Windows.Forms.Label
End Class
