using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
    
    //unused - remove if grayed out before final build
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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

        //Selection
            dgvFoaie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoaie.MultiSelect = false;
        }

        //Database tools
        private const string conString = "Provider=Microsoft.Jet.OLEDB.12.0;Data Source=../data.accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        
        BindingSource bs = new BindingSource();

        //variables for searching
        string name = "placehold";
        string type = "placehold";
        string desc = "placehold";
        string boxCol = "placehold";
        decimal boxNum = 0;
        decimal quant = 0;
        decimal price = 0;
        string col = "placehold";
        string age = "placehold";

        private void formStorageApp_Load(object sender, EventArgs e)
        {
            //data import in dgvFoaie
            this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            bs.DataSource = dgvFoaie.DataSource;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
            if(name == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[1].Value.ToString() == name)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                } 
            }
        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {
            type = tbType.Text;
            if (type == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[2].Value.ToString() == type)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        private void tbDesc_TextChanged(object sender, EventArgs e)
        {
            desc = tbDesc.Text;
            if (desc == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[2].Value.ToString() == desc)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        private void tbBoxCol_TextChanged(object sender, EventArgs e)
        {
            boxCol = tbBoxCol.Text;
            if (boxCol == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[4].Value.ToString() == boxCol)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }
        private void nudBoxNum_ValueChanged(object sender, EventArgs e)
        {
            boxNum = nudBoxNum.Value;
            if (boxNum == 0)
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (Convert.ToDecimal(dgvFoaie.Rows[u].Cells[5].Value) == boxNum)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }
        private void nudQuant_ValueChanged(object sender, EventArgs e)
        {
            quant = nudQuant.Value;
            if (quant == 0)
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (Convert.ToDecimal(dgvFoaie.Rows[u].Cells[6].Value) == quant)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            price = nudPrice.Value;
            if (price == 0)
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (Convert.ToDecimal(dgvFoaie.Rows[u].Cells[7].Value) == price)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        private void tbCol_TextChanged(object sender, EventArgs e)
        {
            col = tbCol.Text;
            if (col == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[8].Value.ToString() == col)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            age = tbAge.Text;
            if (age == "")
            {
                this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[9].Value.ToString() == age)
                    {
                        dgvFoaie.Rows[u].Visible = true;
                    }
                    else
                    {
                        dgvFoaie.CurrentCell = null;
                        dgvFoaie.Rows[u].Visible = false;
                    }
                }
            }
        }

        //----------------//
        //  Database Add  //
        //----------------//
        private void add(string name, string type, string desc, string boxcol, string boxnum, string quant, string price, string color, string age)
        {
            //SQL STMT
            const string sql = "INSERT INTO foaie___import_and_sort_here(NAME,TYPE,DESC,BOXCOL,BOXNUM,QUANT,PRICE,COLOR,AGE) VALUES(@NAME,@TYPE,@DESC,@BOXCOL,@BOXNUM,@QUANT,@PRICE,@COLOR,@AGE)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@TYPE", type);
            cmd.Parameters.AddWithValue("@DESC", desc);
            cmd.Parameters.AddWithValue("@BOXCOL", boxcol);
            cmd.Parameters.AddWithValue("@BOXNUM", boxnum);
            cmd.Parameters.AddWithValue("@QUANT", quant);
            cmd.Parameters.AddWithValue("@PRICE", price);
            cmd.Parameters.AddWithValue("@COLOR", color);
            cmd.Parameters.AddWithValue("@AGE", age);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
