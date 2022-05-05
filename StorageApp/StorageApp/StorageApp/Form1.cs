using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class formStorageApp : Form
    {
        public formStorageApp()
        {
            InitializeComponent();
        }

        private void formStorageApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet._Foaie___import_and_sort_here' table. You can move, or remove it, as needed.
            this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);

        }
    }
}
