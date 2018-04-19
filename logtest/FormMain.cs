using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using CefSharp;
using CefSharp.WinForms;
namespace logtest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Applog.LogDebug("log", "测试Log4Net日志是否写入");
            Applog.LogError("Error", "测试Log4Net日志是否写入");
            
            MessageBox.Show("打开成功", "按钮测试");
        }


        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.baidu.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }


    }
}
