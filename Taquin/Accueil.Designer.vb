<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ButtonLancer = New System.Windows.Forms.Button()
        Me.ButtonTabScores = New System.Windows.Forms.Button()
        Me.LabelEditor = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.PanelTitre = New System.Windows.Forms.Panel()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.PanelTitre.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(90, 329)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(88, 44)
        Me.ButtonQuitter.TabIndex = 4
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ComboBoxName
        '
        Me.ComboBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxName.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(113, 145)
        Me.ComboBoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(112, 23)
        Me.ComboBoxName.TabIndex = 0
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(48, 149)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(53, 17)
        Me.LabelNom.TabIndex = 4
        Me.LabelNom.Text = "Nom :"
        '
        'ButtonLancer
        '
        Me.ButtonLancer.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLancer.Location = New System.Drawing.Point(90, 195)
        Me.ButtonLancer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonLancer.Name = "ButtonLancer"
        Me.ButtonLancer.Size = New System.Drawing.Size(96, 54)
        Me.ButtonLancer.TabIndex = 1
        Me.ButtonLancer.Text = "Lancer"
        Me.ButtonLancer.UseVisualStyleBackColor = True
        '
        'ButtonTabScores
        '
        Me.ButtonTabScores.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTabScores.Location = New System.Drawing.Point(9, 262)
        Me.ButtonTabScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonTabScores.Name = "ButtonTabScores"
        Me.ButtonTabScores.Size = New System.Drawing.Size(118, 54)
        Me.ButtonTabScores.TabIndex = 2
        Me.ButtonTabScores.Text = "Tableau des Scores"
        Me.ButtonTabScores.UseVisualStyleBackColor = True
        '
        'LabelEditor
        '
        Me.LabelEditor.AutoSize = True
        Me.LabelEditor.Font = New System.Drawing.Font("OCR A Extended", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditor.Location = New System.Drawing.Point(172, 394)
        Me.LabelEditor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEditor.Name = "LabelEditor"
        Me.LabelEditor.Size = New System.Drawing.Size(110, 12)
        Me.LabelEditor.TabIndex = 5
        Me.LabelEditor.Text = "Made by Vincent"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTitre.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ForeColor = System.Drawing.Color.MintCream
        Me.LabelTitre.Location = New System.Drawing.Point(26, 24)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(202, 31)
        Me.LabelTitre.TabIndex = 6
        Me.LabelTitre.Text = "Taquin Game"
        '
        'PanelTitre
        '
        Me.PanelTitre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelTitre.Controls.Add(Me.LabelTitre)
        Me.PanelTitre.Location = New System.Drawing.Point(9, 24)
        Me.PanelTitre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelTitre.Name = "PanelTitre"
        Me.PanelTitre.Size = New System.Drawing.Size(259, 84)
        Me.PanelTitre.TabIndex = 7
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOptions.Location = New System.Drawing.Point(152, 262)
        Me.ButtonOptions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(115, 54)
        Me.ButtonOptions.TabIndex = 3
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 414)
        Me.Controls.Add(Me.ButtonOptions)
        Me.Controls.Add(Me.PanelTitre)
        Me.Controls.Add(Me.LabelEditor)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Controls.Add(Me.ButtonTabScores)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonLancer)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.PanelTitre.ResumeLayout(False)
        Me.PanelTitre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonQuitter As Windows.Forms.Button
    Friend WithEvents ComboBoxName As Windows.Forms.ComboBox
    Friend WithEvents LabelNom As Windows.Forms.Label
    Friend WithEvents ButtonLancer As Windows.Forms.Button
    Friend WithEvents ButtonTabScores As Windows.Forms.Button
    Friend WithEvents LabelEditor As Windows.Forms.Label
    Friend WithEvents LabelTitre As Windows.Forms.Label
    Friend WithEvents PanelTitre As Windows.Forms.Panel
    Friend WithEvents ButtonOptions As Windows.Forms.Button
End Class
