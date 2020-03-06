Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles AgeBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextButtton.Click
        Dim btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddressBox.Text

        Dim txt As System.IO.StreamWriter
        txt = My.Computer.FileSystem.OpenTextFileWriter("Txt.txt", True)
        txt.WriteLine("Name : " + name)
        txt.WriteLine("Age : " + age)
        txt.WriteLine("Address : " + add)
        txt.Close()

        If btn Then
            MessageBox.Show("Text is Created @ '\HW2\bin\Debug' ")
        End If

    End Sub

    Private Sub XMLButton_Click(sender As Object, e As EventArgs) Handles XMLButton.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddressBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("XML.xml", True)
        Txt.WriteLine("<Name>" + name + "</Name>")
        Txt.WriteLine("<Age>" + age + "</Age>")
        Txt.WriteLine("<Address>" + add + "</Address>")
        Txt.Close()

        If Btn Then
            MessageBox.Show("XML is Created @ '\HW2\bin\Debug' ")
        End If
    End Sub

    Private Sub JSONButton_Click(sender As Object, e As EventArgs) Handles JSONButton.Click
        Dim Btn As Boolean = True

        Dim name As String = NameBox.Text
        Dim age As String = AgeBox.Text
        Dim add As String = AddressBox.Text

        Dim Txt As System.IO.StreamWriter
        Txt = My.Computer.FileSystem.OpenTextFileWriter("JSON.json", True)
        Txt.WriteLine("{")
        Txt.WriteLine("  ""Name:"" " + name + ",")
        Txt.WriteLine("  ""Age:"" " + age + ",")
        Txt.WriteLine("  ""Address:"" " + add)
        Txt.WriteLine("}")
        Txt.Close()

        If Btn Then
            MessageBox.Show("JSON is Created @ '\HW2\bin\Debug' ")
        End If
    End Sub
End Class
