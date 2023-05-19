using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _path = RSRC.Setting.GlobalPath;
        static string _fileAddress = $"{Directory.GetCurrentDirectory()}\\links\\_{DateUtility.MiladiToShamsi(DateTime.Now)}.txt";

        public void GetPath()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = RSRC.Farsi.SelectFile;
            fdlg.InitialDirectory = RSRC.Setting.InitialPath;
            fdlg.FileName = txtFileName.Text;
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                _path = txtFileName.Text = fdlg.FileName;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            GetPath();
        }

        private void btnGetHtmlFileLinks_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length < 1)
            {
                MessageBox.Show("txtFileName.Text.Length");
                return;
            }
            var strHtml = Util.Mining.GetStrHtml(_path);

            var lst = Util.Mining.GetNewLinks(strHtml);
            StringBuilder sb = new StringBuilder();

            foreach (var item in lst)
            {
                sb.AppendLine(item);
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\links\\"))
                {
                    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\links\\");
                }
                File.AppendAllLines(_fileAddress, new List<string> { sb.ToString() });

            }
            else
            {
                File.AppendAllLines(saveFileDialog1.FileName, new List<string> { sb.ToString() });

            }

            MessageBox.Show(RSRC.Farsi.success);
        }

        private void btnMp4_Click(object sender, EventArgs e)
        {
            string UrlDomain = Util.Mining.GetDomainFromTxtBox(txtUrl.Text);

            var strHtml = Util.Mining.GetHtmlURL(txtUrl.Text);

            var lst = Util.Mining.GetMp4(strHtml);
            if (lst.Count < 1)
            {
                MessageBox.Show(RSRC.Farsi.MsgEmptyList);
                return;
            }
            StringBuilder sb = new StringBuilder();

            foreach (var item in lst)
            {
                sb.AppendLine(item);
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\links\\"))
                {
                    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\links\\");
                }
                File.AppendAllLines(_fileAddress, new List<string> { sb.ToString() });

            }
            else
            {
                File.AppendAllLines(saveFileDialog1.FileName, new List<string> { sb.ToString() });

            }

            MessageBox.Show(RSRC.Farsi.success);
        }
        private void btnGetPageLinks_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Length < 1)
            {
                MessageBox.Show(RSRC.Farsi.MsgLengthTxt);
                return;
            }
            try
            {
                string UrlDomain = Util.Mining.GetDomainFromTxtBox(txtUrl.Text);

                var strHtml = Util.Mining.GetHtmlURL(txtUrl.Text);

                var lst = Util.Mining.GetNewLinks(strHtml);
                StringBuilder sb = new StringBuilder();

                foreach (var item in lst)
                {
                    sb.AppendLine(item);
                }

                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\links\\"))
                    {
                        Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\links\\");
                    }
                    File.AppendAllLines(_fileAddress, new List<string> { sb.ToString() });

                }
                else
                {
                    File.AppendAllLines(
                        saveFileDialog1.FileName, 
                        new List<string> { sb.ToString() });

                }
                MessageBox.Show(RSRC.Farsi.success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex, ex.Message);
            }
        }

        private void btnGetCapital_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length < 1)
            {
                MessageBox.Show(RSRC.Farsi.MsgLengthTxt);
                return;
            }
            var strHtml = Util.Mining.GetStrHtml(_path);

            var lst = Util.Mining.GetCapital(strHtml);
            StringBuilder sb = new StringBuilder();

            foreach (var item in lst)
            {
                sb.AppendLine(item);
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                if (!Directory.Exists(
                    $"{Directory.GetCurrentDirectory()}\\links\\"))
                {
                    Directory.CreateDirectory(
                        $"{Directory.GetCurrentDirectory()}\\links\\");
                }
                File.AppendAllLines(
                    _fileAddress, new List<string> { sb.ToString() });
            }
            else
            {
                File.AppendAllLines(
                    saveFileDialog1.FileName, 
                    new List<string> { sb.ToString() });
            }

            MessageBox.Show(RSRC.Farsi.success);
        }

        private void btnTdTags_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length < 1)
            {
                MessageBox.Show(RSRC.Farsi.MsgLengthTxt);
                return;
            }
            var strHtml = Util.Mining.GetStrHtml(_path);

            var lst = Util.Mining.GetTdTags(strHtml);
            StringBuilder sb = new StringBuilder();

            foreach (var item in lst)
            {
                sb.AppendLine(item);
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                if (!Directory.Exists(
                    $"{Directory.GetCurrentDirectory()}\\links\\"))
                {
                    Directory.CreateDirectory(
                        $"{Directory.GetCurrentDirectory()}\\links\\");
                }
                File.AppendAllLines(
                    _fileAddress, new List<string> { sb.ToString() });

            }
            else
            {
                File.AppendAllLines(
                    saveFileDialog1.FileName, new List<string> { sb.ToString() });
            }

            MessageBox.Show(RSRC.Farsi.success);
        }

        private void btnGetNDgt_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length < 1 || txtNNbr.Text.Length < 1)
            {
                MessageBox.Show(RSRC.Farsi.MsgLengthTxt);
                return;
            }
            var strHtml = Util.Mining.GetStrHtml(_path);

            var lst = Util.Mining.GetNDgtNbr(strHtml, txtNNbr.Text);
            StringBuilder sb = new StringBuilder();

            foreach (var item in lst)
            {
                sb.AppendLine(item);
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                if (!Directory.Exists(
                    $"{Directory.GetCurrentDirectory()}\\links\\"))
                    Directory.CreateDirectory(
                        $"{Directory.GetCurrentDirectory()}\\links\\");
                File.AppendAllLines(
                    _fileAddress, new List<string> { sb.ToString() });

            }
            else
            {
                File.AppendAllLines(
                    saveFileDialog1.FileName, 
                    new List<string> { sb.ToString() });
            }
            MessageBox.Show(RSRC.Farsi.success);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
