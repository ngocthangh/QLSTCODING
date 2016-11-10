using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLiSieuThi
{
    class AddTab
    {
        public void AddTabControl(XtraTabControl xtraTabParent, string xtraItemName, Form form)
        {
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = "";
            xtraTabPage.Text = xtraItemName;
            xtraTabPage.Dock = DockStyle.Fill;
            xtraTabPage.Controls.Add(form);
            xtraTabParent.TabPages.Add(xtraTabPage);
        }
    }
}
