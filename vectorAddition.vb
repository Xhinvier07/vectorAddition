Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class vectorAddition
    Dim polar As New polar()
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles vector.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub vectorForm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vectorForm.SelectedIndexChanged

    End Sub

    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click



        If vectorForm.SelectedIndex >= 0 Then
            Dim selectedItem As String = vectorForm.SelectedItem.ToString()

            If selectedItem = "Polar Form" Then

                Me.Hide()
                polar.Show()


            End If
        Else
            MsgBox("Please select from the options", MsgBoxStyle.Information, "NOTE")
        End If


        If numVector.SelectedIndex = 0 Then '1 Vector
            polar.TextBox3.Enabled = False
            polar.TextBox4.Enabled = False
            polar.TextBox5.Enabled = False
            polar.TextBox6.Enabled = False
            polar.TextBox7.Enabled = False
            polar.TextBox8.Enabled = False

        ElseIf numVector.SelectedIndex = 1 Then '2 Vector
            ' Disable TextBox1 and TextBox2 in the polar form
            polar.TextBox5.Enabled = False
            polar.TextBox6.Enabled = False
            polar.TextBox7.Enabled = False
            polar.TextBox8.Enabled = False

        ElseIf numVector.SelectedIndex = 2 Then '3 Vector
            polar.TextBox7.Enabled = False
            polar.TextBox8.Enabled = False

        ElseIf numVector.SelectedIndex = 3 Then '4 Vector
            polar.TextBox1.Enabled = True
            polar.TextBox2.Enabled = True
            polar.TextBox3.Enabled = True
            polar.TextBox4.Enabled = True
            polar.TextBox5.Enabled = True
            polar.TextBox6.Enabled = True
            polar.TextBox7.Enabled = True
            polar.TextBox8.Enabled = True
        Else
            ' Enable TextBox1 and TextBox2 in the polar form
            polar.TextBox1.Enabled = True
            polar.TextBox2.Enabled = True
            polar.TextBox3.Enabled = True
            polar.TextBox4.Enabled = True
            polar.TextBox5.Enabled = True
            polar.TextBox6.Enabled = True
            polar.TextBox7.Enabled = True
            polar.TextBox8.Enabled = True
        End If





    End Sub

    Private Sub sigFig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sigFig.SelectedIndexChanged

    End Sub

    Private Sub numVector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numVector.SelectedIndexChanged


    End Sub
End Class
