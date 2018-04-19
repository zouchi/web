using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
namespace logtest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Applog.LogDebug("log", "测试Log4Net日志是否写入");
            Applog.LogError("Error", "测试Log4Net日志是否写入");
        }
    }
}
