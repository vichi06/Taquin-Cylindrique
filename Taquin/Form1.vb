Imports System.Windows.Forms

Public Class Identité
    Private Sub Identité_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TickBox_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sexe() As String = {"MR", "MME", "MLLE"}
        Dim i As Integer = 0

        For Each rb As RadioButton In Panel1.Controls
            rb.Text = sexe(i)
            i = i + 1
        Next

    End Sub

    Private Sub Alphab_Control(sender As Object, e As KeyPressEventArgs) Handles TextBoxNom.KeyPress, TextBoxPrenom.KeyPress, TextBoxPays.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True ' empeche l'evenement de se propager
        End If
    End Sub

    Private Sub Num_Control(sender As Object, e As KeyPressEventArgs) Handles TextBoxCP.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCP_LostFocus(sender As Object, e As EventArgs) Handles TextBoxNom.LostFocus, TextBoxPays.LostFocus, TextBoxPrenom.LostFocus
        sender.text = StrConv(sender.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valid As Boolean = True

        If TextBoxCP.Text.Length <> 5 Or (TextBoxCP.Text.ElementAt(0).Equals("0") And (TextBoxCP.Text.ElementAt(1).Equals("0"))) Then
            LabelCP.ForeColor = Drawing.Color.Red
            valid = False
        End If

        If TextBoxNom.Text.Length = 0 Then
            LabelNom.ForeColor = Drawing.Color.Red
            valid = False
        End If

        If TextBoxPrenom.Text.Length = 0 Then
            LabelPrenom.ForeColor = Drawing.Color.Red
            valid = False
        End If

        If TextBoxPays.Text.Length = 0 Then
            LabelPays.ForeColor = Drawing.Color.Red
            valid = False
        End If

        If valid = True Then
            Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Etes-vous sur?", vbYesNo, "Confirmation") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFr.CheckedChanged
        If RadioButtonFr.Checked Then
            PanelCP.Visible = True
            PanelPays.Visible = False
        Else
            PanelCP.Visible = False
            PanelPays.Visible = True
        End If
    End Sub
End Class