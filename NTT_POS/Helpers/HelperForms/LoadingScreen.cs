using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NTT_POS.Helpers.HelperForms
{
    public partial class LoadingScreen : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        public int loadingValue {
            get { return pbCircle.Value; }
            set { pbCircle.Value = value; }
        }
        public string loadingValueText
        {
            get { return pbCircle.Text; }
            set { pbCircle.Text = value; }
        }

        public string statusValue {
            get { return lblStats.Text; }
            set { lblStats.Text = value; }
        }

        public void updateValues(int loadValue, string statValue)
        {
            loadingValue = loadValue;
            loadingValueText = string.Format("{0}%", loadValue);
            statusValue = statValue;

        }
        public LoadingScreen()
        {
            InitializeComponent();
        }
    }
}
