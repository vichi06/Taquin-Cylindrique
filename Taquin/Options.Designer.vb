<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.LabelTitreDif = New System.Windows.Forms.Label()
        Me.TrackBarDifficulté = New System.Windows.Forms.TrackBar()
        Me.ButtonExitOptions = New System.Windows.Forms.Button()
        Me.LabelFacile = New System.Windows.Forms.Label()
        Me.LabelDifficile = New System.Windows.Forms.Label()
        Me.LabelMoyen = New System.Windows.Forms.Label()
        Me.LabelTresFacile = New System.Windows.Forms.Label()
        Me.LabelHardcore = New System.Windows.Forms.Label()
        Me.PanelDif = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCharger = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonSauvegarder = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBoxPlayPause = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBarDifficulté, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDif.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitreDif
        '
        Me.LabelTitreDif.AutoSize = True
        Me.LabelTitreDif.Font = New System.Drawing.Font("OCR A Extended", 12.0!)
        Me.LabelTitreDif.Location = New System.Drawing.Point(19, 26)
        Me.LabelTitreDif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitreDif.Name = "LabelTitreDif"
        Me.LabelTitreDif.Size = New System.Drawing.Size(128, 17)
        Me.LabelTitreDif.TabIndex = 0
        Me.LabelTitreDif.Text = "Difficulté :"
        '
        'TrackBarDifficulté
        '
        Me.TrackBarDifficulté.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TrackBarDifficulté.Cursor = System.Windows.Forms.Cursors.Default
        Me.TrackBarDifficulté.LargeChange = 1
        Me.TrackBarDifficulté.Location = New System.Drawing.Point(1, 90)
        Me.TrackBarDifficulté.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackBarDifficulté.Maximum = 5
        Me.TrackBarDifficulté.Minimum = 1
        Me.TrackBarDifficulté.Name = "TrackBarDifficulté"
        Me.TrackBarDifficulté.Size = New System.Drawing.Size(279, 45)
        Me.TrackBarDifficulté.TabIndex = 1
        Me.TrackBarDifficulté.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarDifficulté.Value = 1
        '
        'ButtonExitOptions
        '
        Me.ButtonExitOptions.Font = New System.Drawing.Font("OCR A Extended", 12.0!)
        Me.ButtonExitOptions.Location = New System.Drawing.Point(98, 362)
        Me.ButtonExitOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExitOptions.Name = "ButtonExitOptions"
        Me.ButtonExitOptions.Size = New System.Drawing.Size(74, 31)
        Me.ButtonExitOptions.TabIndex = 8
        Me.ButtonExitOptions.Text = "Exit"
        Me.ButtonExitOptions.UseVisualStyleBackColor = True
        '
        'LabelFacile
        '
        Me.LabelFacile.AutoSize = True
        Me.LabelFacile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelFacile.Font = New System.Drawing.Font("OCR A Extended", 9.0!)
        Me.LabelFacile.Location = New System.Drawing.Point(53, 16)
        Me.LabelFacile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFacile.Name = "LabelFacile"
        Me.LabelFacile.Size = New System.Drawing.Size(49, 13)
        Me.LabelFacile.TabIndex = 9
        Me.LabelFacile.Text = "Facile"
        '
        'LabelDifficile
        '
        Me.LabelDifficile.AutoSize = True
        Me.LabelDifficile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelDifficile.Font = New System.Drawing.Font("OCR A Extended", 9.0!)
        Me.LabelDifficile.Location = New System.Drawing.Point(168, 16)
        Me.LabelDifficile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDifficile.Name = "LabelDifficile"
        Me.LabelDifficile.Size = New System.Drawing.Size(70, 13)
        Me.LabelDifficile.TabIndex = 10
        Me.LabelDifficile.Text = "Difficile"
        '
        'LabelMoyen
        '
        Me.LabelMoyen.AutoSize = True
        Me.LabelMoyen.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelMoyen.Font = New System.Drawing.Font("OCR A Extended", 9.0!)
        Me.LabelMoyen.Location = New System.Drawing.Point(118, 79)
        Me.LabelMoyen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMoyen.Name = "LabelMoyen"
        Me.LabelMoyen.Size = New System.Drawing.Size(42, 13)
        Me.LabelMoyen.TabIndex = 11
        Me.LabelMoyen.Text = "Moyen"
        '
        'LabelTresFacile
        '
        Me.LabelTresFacile.AutoSize = True
        Me.LabelTresFacile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelTresFacile.Font = New System.Drawing.Font("OCR A Extended", 9.0!)
        Me.LabelTresFacile.Location = New System.Drawing.Point(2, 79)
        Me.LabelTresFacile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTresFacile.Name = "LabelTresFacile"
        Me.LabelTresFacile.Size = New System.Drawing.Size(84, 13)
        Me.LabelTresFacile.TabIndex = 12
        Me.LabelTresFacile.Text = "Très Facile"
        '
        'LabelHardcore
        '
        Me.LabelHardcore.AutoSize = True
        Me.LabelHardcore.BackColor = System.Drawing.SystemColors.HighlightText
        Me.LabelHardcore.Font = New System.Drawing.Font("OCR A Extended", 9.0!)
        Me.LabelHardcore.Location = New System.Drawing.Point(208, 79)
        Me.LabelHardcore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHardcore.Name = "LabelHardcore"
        Me.LabelHardcore.Size = New System.Drawing.Size(63, 13)
        Me.LabelHardcore.TabIndex = 13
        Me.LabelHardcore.Text = "Hardcore"
        '
        'PanelDif
        '
        Me.PanelDif.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PanelDif.Controls.Add(Me.LabelTresFacile)
        Me.PanelDif.Controls.Add(Me.LabelDifficile)
        Me.PanelDif.Controls.Add(Me.LabelHardcore)
        Me.PanelDif.Controls.Add(Me.LabelFacile)
        Me.PanelDif.Controls.Add(Me.LabelMoyen)
        Me.PanelDif.Location = New System.Drawing.Point(1, 59)
        Me.PanelDif.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDif.Name = "PanelDif"
        Me.PanelDif.Size = New System.Drawing.Size(279, 119)
        Me.PanelDif.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 38)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Définir le fichier source des données :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.ButtonCharger)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonSauvegarder)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 228)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 124)
        Me.Panel1.TabIndex = 17
        '
        'ButtonCharger
        '
        Me.ButtonCharger.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCharger.Location = New System.Drawing.Point(21, 89)
        Me.ButtonCharger.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCharger.Name = "ButtonCharger"
        Me.ButtonCharger.Size = New System.Drawing.Size(79, 20)
        Me.ButtonCharger.TabIndex = 20
        Me.ButtonCharger.Text = "Charger"
        Me.ButtonCharger.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ou "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonSauvegarder
        '
        Me.ButtonSauvegarder.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSauvegarder.Location = New System.Drawing.Point(141, 89)
        Me.ButtonSauvegarder.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
        Me.ButtonSauvegarder.Size = New System.Drawing.Size(106, 20)
        Me.ButtonSauvegarder.TabIndex = 18
        Me.ButtonSauvegarder.Text = "Sauvegarder"
        Me.ButtonSauvegarder.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(21, 58)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 22)
        Me.TextBox1.TabIndex = 17
        '
        'CheckBoxPlayPause
        '
        Me.CheckBoxPlayPause.AutoSize = True
        Me.CheckBoxPlayPause.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPlayPause.Location = New System.Drawing.Point(171, 196)
        Me.CheckBoxPlayPause.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxPlayPause.Name = "CheckBoxPlayPause"
        Me.CheckBoxPlayPause.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxPlayPause.TabIndex = 19
        Me.CheckBoxPlayPause.Text = "Play/Pause"
        Me.CheckBoxPlayPause.UseVisualStyleBackColor = True
        '
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxTime.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTime.Location = New System.Drawing.Point(9, 196)
        Me.CheckBoxTime.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(138, 17)
        Me.CheckBoxTime.TabIndex = 20
        Me.CheckBoxTime.Text = "Désactiver Temps"
        Me.CheckBoxTime.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 411)
        Me.Controls.Add(Me.CheckBoxTime)
        Me.Controls.Add(Me.CheckBoxPlayPause)
        Me.Controls.Add(Me.ButtonExitOptions)
        Me.Controls.Add(Me.TrackBarDifficulté)
        Me.Controls.Add(Me.LabelTitreDif)
        Me.Controls.Add(Me.PanelDif)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Options"
        Me.Text = "Options"
        CType(Me.TrackBarDifficulté, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDif.ResumeLayout(False)
        Me.PanelDif.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitreDif As Windows.Forms.Label
    Friend WithEvents TrackBarDifficulté As Windows.Forms.TrackBar
    Friend WithEvents ButtonExitOptions As Windows.Forms.Button
    Friend WithEvents LabelFacile As Windows.Forms.Label
    Friend WithEvents LabelDifficile As Windows.Forms.Label
    Friend WithEvents LabelMoyen As Windows.Forms.Label
    Friend WithEvents LabelTresFacile As Windows.Forms.Label
    Friend WithEvents LabelHardcore As Windows.Forms.Label
    Friend WithEvents PanelDif As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ButtonSauvegarder As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents CheckBoxPlayPause As Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTime As Windows.Forms.CheckBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ButtonCharger As Windows.Forms.Button
End Class
