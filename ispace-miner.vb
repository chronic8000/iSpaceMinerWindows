Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = ("Started iSpace Miner For Windows Version 1.1")
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
        ToolStripStatusLabel1.Text = ("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = ("This pool monitors the CoinWarz website and looks to switch to the most profitable pool at any given time providing the current exchange rate")
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4443 -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4441 -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ToolStripStatusLabel1.Text = ("This pool monitors the difficulty settings of our coins and always mines the pool with the lowest value")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ToolStripStatusLabel1.Text = ("This pool simply rotates through all of our available pools on an hourly basis")
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4444 -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4442 -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ToolStripStatusLabel1.Text = ("This pool rotates on an 2-hourly basis through 5 coins chosen by us.")
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:4445 -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ToolStripStatusLabel1.Text = ("Started mining using port number " + TextBox2.Text)
        Shell("bfgminer.exe -o stratum+tcp://ispace.co.uk:" + TextBox2.Text + " -u " + TextBox1.Text + " -p x " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ToolStripStatusLabel1.Text = ("Started mining on pool address " + TextBox3.Text)
        Shell("bfgminer.exe -o " + TextBox3.Text + " -u " + TextBox7.Text + " -p " + TextBox4.Text + " " + TextBox5.Text + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ToolStripStatusLabel1.Text = ("Thanks, you have no idea how much this helps!")
        WebBrowser1.Navigate("https://coinbase.com/checkouts/f4e00ed6acaa2e80f6bf831a038f8546")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ToolStripStatusLabel1.Text = ("Loading iSpace home page...")
        WebBrowser1.Navigate("http://www.ispace.co.uk")
        ToolStripStatusLabel1.Text = ("iSpace home loaded")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ToolStripStatusLabel1.Text = ("Loading iSpace My Mining...")
        WebBrowser1.Navigate("http://ispace.co.uk/my-mining")
        ToolStripStatusLabel1.Text = ("Finished loading iSpace My Mining")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ToolStripStatusLabel1.Text = ("Loading iSpace My Workers...")
        WebBrowser1.Navigate("http://ispace.co.uk/my-workers")
        ToolStripStatusLabel1.Text = ("Finished Loading iSpace My Workers")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ToolStripStatusLabel1.Text = ("Loading iSpace Add New Pools...")
        WebBrowser1.Navigate("http://ispace.co.uk/my-mining/add-pool")
        ToolStripStatusLabel1.Text = ("Finished loading iSpace Add New Pools")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ToolStripStatusLabel1.Text = ("Loading iSpace Support...")
        WebBrowser1.Navigate("http://ispace.co.uk/support")
        ToolStripStatusLabel1.Text = ("Finished loading iSpace Support")
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ToolStripStatusLabel1.Text = ("Refreshing page, please wait...")
        WebBrowser1.Refresh()
        ToolStripStatusLabel1.Text = ("Page refresh complete!")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click, TextBox6.Enter
        ToolStripStatusLabel1.Text = ("Loading website " + TextBox6.Text)
        WebBrowser1.Navigate(TextBox6.Text)
        ToolStripStatusLabel1.Text = ("Finished loading " + TextBox6.Text)
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
        ToolStripStatusLabel1.Text = ("Loading Feature Request Form...")
        WebBrowser1.Navigate("https://docs.google.com/forms/d/18l8aMngVZ2P14x34UIIBzkJFdmEsfDhwfqoIljcBewQ/viewform")
        ToolStripStatusLabel1.Text = ("Thanks for your suggestions, they are much appreciated!")
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked
        ToolStripStatusLabel1.Text = ("")
    End Sub

    Private Sub ToolStripStatusLabel1_Click_1(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = ("")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        WebBrowser1.Navigate("https://raw.githubusercontent.com/luke-jr/bfgminer/bfgminer/README")
        ToolStripStatusLabel1.Text = ("Opened BFGMiner Readme.txt")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If ComboBox1.SelectedItem = "Bitcoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:9332 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "Terracoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:9322 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "Freicoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:9933 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "Zetacoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:17335 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "TigerCoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:15665 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "Unobtainium" Then
            Shell("bfgminer.exe -o http://p2pool.org:65533 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "AsicCoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:18335 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "ByteCoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:6335 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "BetaCoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:32335 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "Joulecoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:64533 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        ElseIf ComboBox1.SelectedItem = "FireFlyCoin" Then
            Shell("bfgminer.exe -o http://p2pool.org:5537 -u " + TextBox8.Text + " -p x " + " --scan-serial erupter:\\.\com" + erupterportbox.Text)
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub erupterportbox_TextChanged(sender As Object, e As EventArgs) Handles erupterportbox.TextChanged

    End Sub
End Class
