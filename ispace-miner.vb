Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4443 -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4441 -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4444 -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4442 -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4445 -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:" + TextBox2.Text + " -u " + TextBox1.Text + " -p x " + TextBox5.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("bfgminer.exe -o " + TextBox7.Text + " -u " + TextBox1.Text + " -p " + TextBox4.Text + " " + TextBox5.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.Navigate("https://coinbase.com/checkouts/f4e00ed6acaa2e80f6bf831a038f8546")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WebBrowser1.Navigate("http://www.ispace.co.uk")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        WebBrowser1.Navigate("http://ispace.co.uk/my-mining")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        WebBrowser1.Navigate("http://ispace.co.uk/my-workers")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebBrowser1.Navigate("http://ispace.co.uk/my-mining/add-pool")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebBrowser1.Navigate("http://ispace.co.uk/support")
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click, TextBox6.Enter
        WebBrowser1.Navigate(TextBox6.Text)
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub Textbox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            WebBrowser1.Navigate(TextBox6.Text)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox6.Text = WebBrowser1.Url.ToString
    End Sub
    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Dim p, d, t As Integer
        d = e.CurrentProgress
        t = e.MaximumProgress
        If t < 1 Then t = 1
        p = Int(d / t) * 100
        If p > 100 Or p < 0 Then Exit Sub
        Progress.Value = p
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WebBrowser1.Navigate("https://docs.google.com/forms/d/18l8aMngVZ2P14x34UIIBzkJFdmEsfDhwfqoIljcBewQ/viewform")
    End Sub
End Class
