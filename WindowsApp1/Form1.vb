Public Class Form1

    Dim NB1, NB2 As Integer

    Private Sub btnOui_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click
        NB1 = Val(InputBox("1er nombre"))
        NB2 = Val(InputBox("2ème nombre"))
        MsgBox("L'addition est : " & (NB1 + NB2))
        MsgBox("La soustraction est : " & (NB1 - NB2))
    End Sub

    Private Sub btnNon_Click(sender As Object, e As EventArgs) Handles btnNon.Click
        Me.Hide()
    End Sub


End Class
