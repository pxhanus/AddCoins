'Patricia Hanus
'151110
'Add Coins
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim q As Integer = Val(Me.txtAmtQ.Text)
        Dim d As Integer = Val(Me.txtAmtD.Text)
        Dim n As Integer = Val(Me.txtAmtN.Text)
        Dim p As Integer = Val(Me.txtAmtP.Text)

        Dim total As Double = TotalDollars(q, d, n, p)

        Me.lblTotal.Text = "Total: $" & total
    End Sub
    '*************************************************************************
    'TotalDollars 
    'Adds together coin values for number of coins sent.
    '
    'post:  returns TotalDollars -- the total amount of coinage in dollars.
    '*************************************************************************
    Function TotalDollars(ByVal q As Integer, ByVal d As Integer, _
                          ByVal n As Integer, ByVal p As Integer)
        TotalDollars = q * 0.25 + d * 0.1 + n * 0.05 + p * 0.01
    End Function

    Private Sub txtCoin_TextChanged(sender As Object, e As EventArgs) Handles txtAmtQ.TextChanged, _
        txtAmtD.TextChanged, txtAmtN.TextChanged, txtAmtP.TextChanged
        Me.lblTotal.Text = Nothing
    End Sub
End Class
