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

            //dgv column names

            dgvFoaie.Columns[1].Name = "NAME";
            dgvFoaie.Columns[2].Name = "TYPE";
            dgvFoaie.Columns[3].Name = "DESC";
            dgvFoaie.Columns[4].Name = "BOXCOL";
            dgvFoaie.Columns[5].Name = "BOXNUM";
            dgvFoaie.Columns[6].Name = "QUANT";
            dgvFoaie.Columns[7].Name = "PRICE";
            dgvFoaie.Columns[8].Name = "COL";
            dgvFoaie.Columns[9].Name = "AGE";
        }
        DataSet ds = new DataSet();

        //variables for searching
        string name = "placehold";
        string type = "placehold";
        string desc = "placehold";
        string boxCol = "placehold";
        string boxNum = "placehold";
        int quant = Convert.ToInt32(1);
        int price = Convert.ToInt32(1);
        string col = "placehold";
        string age = "placehold";

        private void formStorageApp_Load(object sender, EventArgs e)
        {
            //data import in dgvFoaie
            this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);

            //default textboxes values imported from the first row
            tbName.Text = dgvFoaie.Rows[0].Cells[1].Value.ToString();   //NAME
            tbType.Text = dgvFoaie.Rows[0].Cells[2].Value.ToString();   //TYPE 
            tbDesc.Text = dgvFoaie.Rows[0].Cells[3].Value.ToString();   //DESC
            tbBoxCol.Text = dgvFoaie.Rows[0].Cells[4].Value.ToString(); //BOXCOL
            tbBoxNum.Text = dgvFoaie.Rows[0].Cells[5].Value.ToString(); //BOXNUM
            tbQuant.Text = dgvFoaie.Rows[0].Cells[6].Value.ToString();  //QUANT
            tbPrice.Text = dgvFoaie.Rows[0].Cells[7].Value.ToString();  //PRICE
            tbCol.Text = dgvFoaie.Rows[0].Cells[8].Value.ToString();    //COL
            tbAge.Text = dgvFoaie.Rows[0].Cells[9].Value.ToString();    //AGE

            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //variables for searching
            name = tbName.Text;
            type = tbType.Text;
            desc = tbDesc.Text;
            boxCol = tbBoxCol.Text;
            boxNum = tbBoxNum.Text;
            quant = Convert.ToInt32(tbQuant.Text);
            price = Convert.ToInt32(tbPrice.Text);
            col = tbCol.Text;
            age = tbAge.Text;


        }
    }
}
