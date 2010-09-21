Public Class frmMain

    Private Sub btnProcessOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessOrder.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\Price&TaxData.txt")
        Dim strName As String = txtboxName.Text
        Dim strAddress As String = txtboxAddress.Text
        Dim strCityStateZip As String = txtboxCityStateZip.Text
        Dim strNumChairs As String = txtboxChairsOrdered.Text
        Dim strNumSofas As String = txtSofasOrdered.Text
        Dim strChairCost As String = sr.ReadLine
        Dim strSofaCost As String = sr.ReadLine
        Dim strTax As String = sr.ReadLine




    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub
End Class
