using POS_Andy.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace POS_Andy
{
    public partial class frmImportProduct : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text'";
        DataTable dt = new DataTable();
        DataTable dtMaster = new DataTable();
        DataTable dtMerged = new DataTable();
        DataTable dtMatchedValues = new DataTable();
        DataTable dtNewValues = new DataTable();
        string errorMessage;

        public frmImportProduct()
        {
            InitializeComponent();
        }

        private void btn_pilih_file_Click(object sender, EventArgs e)
        {
            hideProperties();

            openFileDialog1.ShowDialog();
        }

        private void hideProperties()
        {
            dgv_result.DataSource = null;
            dt.Clear();
            dtMaster.Clear();
            btnImport.Visible = false;
            lbl_total_barang_value.Text = "";
            lbl_tbh_stok_value.Text = "";
            lbl_barang_baru_value.Text = "";
            dt.Dispose();
            dtMaster.Dispose();
            dtMatchedValues.Dispose();
            dtMerged.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dt = new DataTable();
            dtMaster = new DataTable();
            string filePath = openFileDialog1.FileName;
            filePath = filePath.Replace("\\", "/");
            string extension = Path.GetExtension(filePath);
            //string header = rbHeaderYes.Checked ? "YES" : "NO";
            string conStr, sheetName;
            sheetName = "Universal$";

            conStr = string.Empty;
            try
            {
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, "YES");
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, "YES");
                        break;
                }

                //Read Data from the Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);

                            DataRow rowDel = dt.Rows[0];
                            dt.Rows.Remove(rowDel);

                            dt.Columns[0].ColumnName = "Nama Barang";
                            dt.Columns[1].ColumnName = "Stok";
                            dt.Columns[2].ColumnName = "Harga Cost";
                            dt.Columns[3].ColumnName = "Harga Eceran";
                            dt.Columns[4].ColumnName = "Harga Grosir";
                            dt.Columns[5].ColumnName = "Min. Qty Grosir";
                            dt.Columns[6].ColumnName = "Nama Vendor";
                            dt.Columns[7].ColumnName = "Kategori";
                            dt.Columns[8].ColumnName = "Satuan";
                            dt.Columns[9].ColumnName = "Isi";
                            dt.Columns.Add("key", typeof(string));

                            con.Close();

                            //delete last blank row on datatable
                            //int x = 0;
                            //foreach (DataRow row in dt.Rows)
                            //{
                            //    if (x == dt.Rows.Count)
                            //        row.Delete();

                            //    x++;
                            //}
                            //dt.AcceptChanges();
                            int i = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                dr["key"] = dt.Rows[i]["Nama Barang"].ToString() + "##" + dt.Rows[i]["Nama Vendor"].ToString();

                                i++;
                            }

                            dtMaster = Core.ListProduct_ALL();

                            //var compareSameValues = dt.AsEnumerable().Select(r => r.Field<string>("key"))
                            //                    .Except(dtMaster.AsEnumerable().Select(r => r.Field<string>("key")));
                            //DataTable dtUpdateItem = (from row in dt.AsEnumerable()
                            //                    join key in compareSameValues
                            //                    on row.Field<string>("key") equals key
                            //                    select row).CopyToDataTable();

                            var joinTables = from dt in dt.AsEnumerable()
                                          join dtMaster in dtMaster.AsEnumerable() on dt.Field<string>("key") equals dtMaster.Field<string>("key")
                                          select dt;

                            var matchedValues = from dt in dt.AsEnumerable()
                                          join dtMaster in dtMaster.AsEnumerable() on dt.Field<string>("key") equals dtMaster.Field<string>("key")
                                          select dt;

                            var newValues = from dt in dt.AsEnumerable()
                                          where !matchedValues.Contains(dt)
                                          select dt;

                            dtMatchedValues = new DataTable();
                            dtNewValues = new DataTable();
                            dtMerged = new DataTable();

                            dtMatchedValues = (from dt in dt.AsEnumerable()
                                              join dtMaster in dtMaster.AsEnumerable() on dt.Field<string>("key") equals dtMaster.Field<string>("key")
                                              select dt).CopyToDataTable();
                            
                            if (newValues.Any(v => v != null))
                                dtNewValues = (from newVal in newValues.AsEnumerable()
                                                select newVal).CopyToDataTable();

                            if (dtMatchedValues.Rows.Count > 0)
                            {
                                Image updateImg;
                                
                                updateImg = Image.FromFile(@"C:\temp\icon-update.gif");

                                dtMatchedValues.Columns.Add("status", typeof(byte[]));
                                dtMatchedValues.Columns.Add("remarks", typeof(string));

                                // Add Image to column
                                foreach (DataRow dr in dtMatchedValues.Rows)
                                {
                                    dr["status"] = imageToByteArray(updateImg);
                                    dr["remarks"] = "update";
                                }
                            }

                            if (dtNewValues.Rows.Count > 0)
                            {
                                Image newImg;

                                newImg = Image.FromFile(@"C:\temp\new.gif");
                                
                                dtNewValues.Columns.Add("status", typeof(byte[]));
                                dtNewValues.Columns.Add("remarks", typeof(string));

                                // Add Image to column
                                foreach (DataRow dr in dtNewValues.Rows)
                                {
                                    dr["status"] = imageToByteArray(newImg);
                                    dr["remarks"] = "new";
                                }
                            }
                            
                            dtMerged = dtMatchedValues.Copy();
                            dtMerged.Merge(dtNewValues);

                            dtMerged.Columns.Remove("key");
                            
                            //dtNewValues = (DataTable)newValues;


                            //Populate DataGridView.
                            dgv_result.DataSource = dtMerged;
                            dgv_result.Columns[dgv_result.Rows[0].Cells.Count - 1].Visible = false;

                            if (dtMerged.Rows.Count > 0)
                            {
                                btnImport.Visible = true;
                                lbl_total_barang_value.Text = dtMerged.Rows.Count.ToString();
                                lbl_barang_baru_value.Text = dtNewValues.Rows.Count.ToString();
                                lbl_tbh_stok_value.Text = dtMatchedValues.Rows.Count.ToString();
                            }
                            else
                                btnImport.Visible = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private void frmImportProduct_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnImport.Visible = false;
            
            dgv_result.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_result.AllowUserToOrderColumns = true;
            dgv_result.AllowUserToResizeColumns = true;
        }

        private void dgv_result_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";

                for (int i = 0; i < dtMerged.Rows.Count; i++)
                {
                    if (dtMerged.Rows[i]["Nama Barang"].ToString() == "" || dtMerged.Rows[i]["Stok"].ToString() == ""
                        || dtMerged.Rows[i]["Harga Cost"].ToString() == "" || dtMerged.Rows[i]["Harga Eceran"].ToString() == ""
                        || dtMerged.Rows[i]["Nama Vendor"].ToString() == "" || dtMerged.Rows[i]["Kategori"].ToString() == ""
                        || dtMerged.Rows[i]["Satuan"].ToString() == "" || dtMerged.Rows[i]["Isi"].ToString() == "")
                    {
                        errorMessage = "Nama Barang / Stok / Harga Cost / Harga Eceran / Nama Vendor / Kategori " +
                                        "/ Satuan / Isi tidak boleh kosong, silahkan memeriksa kembali excel anda";
                        break;
                    }
                    else
                    {
                        string namaBarang = dtMerged.Rows[i]["Nama Barang"].ToString();
                        int stok = int.Parse(dtMerged.Rows[i]["Stok"].ToString());
                        int hargaCost = int.Parse(dtMerged.Rows[i]["Harga Cost"].ToString());
                        int hargaEceran = int.Parse(dtMerged.Rows[i]["Harga Eceran"].ToString());
                        int hargaGrosir = int.Parse(dtMerged.Rows[i]["Harga Grosir"].ToString());
                        int minQtyNumber = int.Parse(dtMerged.Rows[i]["Min. Qty Grosir"].ToString());
                        string namaVendor = dtMerged.Rows[i]["Nama Vendor"].ToString();
                        string kategori = dtMerged.Rows[i]["Kategori"].ToString();
                        string satuan = dtMerged.Rows[i]["Satuan"].ToString();
                        int isi = int.Parse(dtMerged.Rows[i]["Isi"].ToString());
                        string remarks = dtMerged.Rows[i]["remarks"].ToString();

                        if(remarks == "new")
                            result = Core.ImportProduk(namaBarang, stok, hargaCost, hargaEceran, hargaGrosir, minQtyNumber
                                                    , namaVendor, kategori, satuan, isi);
                        else
                            result = Core.UpdateProduk(namaBarang, stok, hargaCost, hargaEceran, hargaGrosir, minQtyNumber
                                                    , namaVendor, kategori, satuan, isi, namaBarang + "##" + namaVendor);

                    }
                }
                if (result != "")
                    MessageBox.Show(result);
                else
                    MessageBox.Show("Import Barang berhasil.");

                hideProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }            
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
