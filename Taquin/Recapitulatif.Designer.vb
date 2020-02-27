<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recapitulatif
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
        Me.ComboBoxJoueurs = New System.Windows.Forms.ComboBox()
        Me.ListBoxNoms = New System.Windows.Forms.ListBox()
        Me.ListBoxBestScore = New System.Windows.Forms.ListBox()
        Me.ButtonFullStats = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.RadioButtonTriAlpha = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTriTmps = New System.Windows.Forms.RadioButton()
        Me.LabelTri = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxJoueurs
        '
        Me.ComboBoxJoueurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxJoueurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxJoueurs.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxJoueurs.FormattingEnabled = True
        Me.ComboBoxJoueurs.Location = New System.Drawing.Point(37, 34)
        Me.ComboBoxJoueurs.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxJoueurs.Name = "ComboBoxJoueurs"
        Me.ComboBoxJoueurs.Size = New System.Drawing.Size(104, 23)
        Me.ComboBoxJoueurs.TabIndex = 0
        '
        'ListBoxNoms
        '
        Me.ListBoxNoms.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNoms.FormattingEnabled = True
        Me.ListBoxNoms.ItemHeight = 15
        Me.ListBoxNoms.Location = New System.Drawing.Point(28, 115)
        Me.ListBoxNoms.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxNoms.Name = "ListBoxNoms"
        Me.ListBoxNoms.Size = New System.Drawing.Size(96, 214)
        Me.ListBoxNoms.TabIndex = 2
        '
        'ListBoxBestScore
        '
        Me.ListBoxBestScore.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxBestScore.FormattingEnabled = True
        Me.ListBoxBestScore.ItemHeight = 15
        Me.ListBoxBestScore.Location = New System.Drawing.Point(147, 115)
        Me.ListBoxBestScore.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxBestScore.Name = "ListBoxBestScore"
        Me.ListBoxBestScore.Size = New System.Drawing.Size(96, 214)
        Me.ListBoxBestScore.TabIndex = 3
        '
        'ButtonFullStats
        '
        Me.ButtonFullStats.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFullStats.Location = New System.Drawing.Point(173, 20)
        Me.ButtonFullStats.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFullStats.Name = "ButtonFullStats"
        Me.ButtonFullStats.Size = New System.Drawing.Size(68, 50)
        Me.ButtonFullStats.TabIndex = 1
        Me.ButtonFullStats.Text = "Full Stats"
        Me.ButtonFullStats.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(189, 387)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(54, 32)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'RadioButtonTriAlpha
        '
        Me.RadioButtonTriAlpha.AutoSize = True
        Me.RadioButtonTriAlpha.Font = New System.Drawing.Font("OCR A Extended", 10.8!)
        Me.RadioButtonTriAlpha.Location = New System.Drawing.Point(28, 371)
        Me.RadioButtonTriAlpha.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonTriAlpha.Name = "RadioButtonTriAlpha"
        Me.RadioButtonTriAlpha.Size = New System.Drawing.Size(134, 21)
        Me.RadioButtonTriAlpha.TabIndex = 4
        Me.RadioButtonTriAlpha.TabStop = True
        Me.RadioButtonTriAlpha.Text = "Alphabétique"
        Me.RadioButtonTriAlpha.UseVisualStyleBackColor = True
        '
        'RadioButtonTriTmps
        '
        Me.RadioButtonTriTmps.AutoSize = True
        Me.RadioButtonTriTmps.Font = New System.Drawing.Font("OCR A Extended", 10.8!)
        Me.RadioButtonTriTmps.Location = New System.Drawing.Point(28, 393)
        Me.RadioButtonTriTmps.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonTriTmps.Name = "RadioButtonTriTmps"
        Me.RadioButtonTriTmps.Size = New System.Drawing.Size(152, 21)
        Me.RadioButtonTriTmps.TabIndex = 5
        Me.RadioButtonTriTmps.TabStop = True
        Me.RadioButtonTriTmps.Text = "Meilleur Temps"
        Me.RadioButtonTriTmps.UseVisualStyleBackColor = True
        '
        'LabelTri
        '
        Me.LabelTri.AutoSize = True
        Me.LabelTri.Font = New System.Drawing.Font("OCR A Extended", 10.8!)
        Me.LabelTri.Location = New System.Drawing.Point(25, 353)
        Me.LabelTri.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTri.Name = "LabelTri"
        Me.LabelTri.Size = New System.Drawing.Size(107, 17)
        Me.LabelTri.TabIndex = 7
        Me.LabelTri.Text = "Trier par :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Joueurs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Highest Score"
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("OCR A Extended", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(175, 344)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(68, 32)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Recapitulatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 436)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTri)
        Me.Controls.Add(Me.RadioButtonTriTmps)
        Me.Controls.Add(Me.RadioButtonTriAlpha)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonFullStats)
        Me.Controls.Add(Me.ListBoxBestScore)
        Me.Controls.Add(Me.ListBoxNoms)
        Me.Controls.Add(Me.ComboBoxJoueurs)
        Me.Name = "Recapitulatif"
        Me.Text = "Récapitulatif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxJoueurs As Windows.Forms.ComboBox
    Friend WithEvents ListBoxNoms As Windows.Forms.ListBox
    Friend WithEvents ListBoxBestScore As Windows.Forms.ListBox
    Friend WithEvents ButtonFullStats As Windows.Forms.Button
    Friend WithEvents ButtonExit As Windows.Forms.Button
    Friend WithEvents RadioButtonTriAlpha As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriTmps As Windows.Forms.RadioButton
    Friend WithEvents LabelTri As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ButtonClear As Windows.Forms.Button
End Class
