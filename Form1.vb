Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim val1, val2, val3, val4
        Dim cons1, cons2, cons3, cons4

        Randomize()   ' Initialize random-number generator

        val1 = Int((9 * Rnd()) + 1)   ' Generates random value between 1 and 9
        val2 = Int((9 * Rnd()) + 1)
        val3 = Int((9 * Rnd()) + 1)
        val4 = Int((9 * Rnd()) + 1)

        cons1 = Chr(Int((122 - 97 + 1) * Rnd() + 97)) 'converts ascii values corresponding to a-z to character then Int((upperbound - lowerbound + 1) * Rnd + lowerbound)
        cons2 = Chr(Int((122 - 97 + 1) * Rnd() + 97))
        cons3 = Chr(Int((122 - 97 + 1) * Rnd() + 97))
        cons4 = Chr(Int((122 - 97 + 1) * Rnd() + 97))

        TextBox1.Text = cons1 & val1 & cons2 & val2 & cons3 & val3 & cons4 & val4

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'TextBox1.Text = cons1 & val1 & cons2 & val2 & cons3 & val3 & cons4 & val4
    End Sub
End Class
