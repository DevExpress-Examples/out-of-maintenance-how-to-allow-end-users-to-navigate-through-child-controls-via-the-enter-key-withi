using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            Control activeControl = ActiveControl;
            while (activeControl is ContainerControl)
                activeControl = (activeControl as ContainerControl).ActiveControl;

            if (keyData == Keys.Return && (activeControl is TextBoxMaskBox || activeControl is BaseEdit))
            {
                bool result = SelectNextControl(activeControl, true, false, true, false);
                if (result)
                    return result;
                return base.ProcessDialogKey(keyData);
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
