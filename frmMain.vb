Public Class frmMain

    Public Function ReverseString(ByRef strToReverse As String) As String
        Dim result As String = ""
        For i As Integer = 0 To strToReverse.Length - 1
            result += strToReverse(strToReverse.Length - 1 - i)
        Next
        Return result
    End Function

    Private Function Zip(ByVal strCityStateZip As String) As String
        Dim tempResult = ReverseString(strCityStateZip)

        tempResult = tempResult.Substring(0, 4)


        Return ReverseString(tempResult)

    End Function

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
        Dim strInvoiceNumber As String = ""

        'strCityStateZip = ReverseString(strCityStateZip)
        'strCityStateZip = Zip(strCityStateZip)

        'MessageBox.Show(ReverseString(strCityStateZip))
        'MessageBox.Show(ReverseString(Zip(strCityStateZip)))

        MessageBox.Show(Zip(strCityStateZip))

        lstBoxInformation.Items.Clear()
        lstBoxInformation.Items.Add("InvoiceNumber: " & strInvoiceNumber)



    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub






    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click


    End Sub
End Class
