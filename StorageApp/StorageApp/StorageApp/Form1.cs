<<<<<<< HEAD
﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
    
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
            this.foaieTableAdapter.Fill(this.dataDataSet.Foaie);
            
            bs.DataSource = dgvFoaie.DataSource;

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
            if(name == "")
            {
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    if (dgvFoaie.Rows[u].Cells[3].Value.ToString() == desc)
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
                this.foaieTableAdapter.Fill(this.dataDataSet.Foaie);
            }
            else
            {
                for (int u = 0; u < dgvFoaie.RowCount; u++)
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
        }
        private void nudBoxNum_ValueChanged(object sender, EventArgs e)
        {
            boxNum = nudBoxNum.Value;
            if (boxNum == 0)
            {
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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


      
        private void bAdd_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=data.accdb";

            try
            {
                conn.Open();
                string my_querry = "INSERT INTO foaie([NAME], [TYPE], [DESCRIPTION], [BOX_COLOR], [BOX_NUMBER], [QUANTITY], [PRICE], [COLOR], [AGE]) VALUES('" + tbName.Text + "','" + tbType.Text + "','" + tbDesc.Text + "','" + tbBoxCol.Text + "','" + nudBoxNum.Value + "','" + nudQuant.Value + "','" + nudPrice.Value + "','" + tbCol.Text + "','" + tbAge.Text + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data saved successfuly...!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }
            finally
            {
                conn.Close();
                File.Delete("../../data.accdb");
                File.Copy("data.accdb", "../../data.accdb");
                this.foaieTableAdapter.Fill(this.dataDataSet.Foaie);
                
            }
        }
    }
}
=======
﻿using System;
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
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=data.accdb";
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
            this.foaieTableAdapter.Fill(this.dataDataSet.Foaie);
            
            bs.DataSource = dgvFoaie.DataSource;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
            if(name == "")
            {
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
                //this.foaie___import_and_sort_hereTableAdapter.Fill(this.dataDataSet._Foaie___import_and_sort_here);
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
        private void add(string name, string type, string desc, string boxcol, decimal boxnum, decimal quant, decimal price, string color, string age)
        {
            //SQL STMT
            const string sql = "INSERT INTO foaie([NAME],[TYPE],[DESCRIPTION],[BOX_COLOR],[BOX_NUMBER],[QUANTITY],[PRICE],[COLOR],[AGE]) VALUES(@NAME,@TYPE,@DESCRIPTION,@BOX_COLOR,@BOX_NUMBER,@QUANTITY,@PRICE,@COLOR,@AGE)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@TYPE", type);
            cmd.Parameters.AddWithValue("@DESCRIPTION", desc);
            cmd.Parameters.AddWithValue("@BOX_COLOR", boxcol);
            cmd.Parameters.AddWithValue("@BOX_NUMBER", boxnum);
            cmd.Parameters.AddWithValue("@QUANTITY", quant);
            cmd.Parameters.AddWithValue("@PRICE", price);
            cmd.Parameters.AddWithValue("@COLOR", color);
            cmd.Parameters.AddWithValue("@AGE", age);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    tbName.Clear();
                    tbType.Clear();
                    tbDesc.Clear();
                    tbBoxCol.Clear();
                    nudBoxNum.Value = 0;
                    nudPrice.Value = 0;
                    nudQuant.Value = 0;
                    tbCol.Clear();
                    tbAge.Clear();
;                   MessageBox.Show(@"Successfully Inserted");
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

        private void retrieve()
        {
            dt.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM foaie";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), Convert.ToDecimal(row[5]), Convert.ToDecimal(row[6]), Convert.ToDecimal(row[7]), row[8].ToString(), row[9].ToString() );         
                }

                con.Close();
                //CLEAR DATATABLE
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void populate(int id, string name, string type, string desc, string boxCol, decimal boxNum, decimal quant, decimal price, string color, string age)
        {
            dt.Rows.Add(id, name, type, desc, boxCol, boxNum, quant, price, color, age);
            dgvFoaie.DataSource = dt;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            add(tbName.Text, tbType.Text, tbDesc.Text, tbBoxCol.Text, nudBoxNum.Value, nudQuant.Value, nudPrice.Value, tbCol.Text, tbAge.Text);
        }
    }
}
>>>>>>> 616b6e867ed019aad2b3ae83a2b658489052b45d
