Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:4443 -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:4441 -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:4444 -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:4442 -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:4445 -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o stratum+tcp://ispace.co.uk:" + TextBox2.Text + " -u " + TextBox1.Text + " -p x")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("C:\Users\Chronic\Documents\visual studio 2013\Projects\WindowsApplication1\WindowsApplication1\bfg\bfgminer.exe -o " + TextBox3.Text + " -u " + TextBox1.Text + " -p " + TextBox4.Text)
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
End Class
