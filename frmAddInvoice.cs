using POS_Andy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy
{
    public partial class frmAddInvoice : Form
    {
        int ctrTab = 0;
        bool flag = false;
        bool delGridview = true;

        DataTable dtVendor;
          
        //ComboBox cbVendorName;
        //ComboBox cbItemName;

        //DataGridView dgv_invoice = new DataGridView();

        Button btnAdd = new Button();
        Button btnClear = new Button();


        public frmAddInvoice()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            createControls();
            btnDelTab.Enabled = true;
        }

        void createControls()
        {
            try
            {
                var provider = new System.Globalization.CultureInfo("id-ID");

                TabPage t = new TabPage();
                DataGridView dgv_invoice = new DataGridView();
                dtVendor = new DataTable();
                DataTable dtItem = new DataTable();

                dtVendor = Core.ListVendorName();

                if (flag != false)
                {
                    t.Name = "Tab-" + (ctrTab + 2).ToString();
                    t.Text = "Tab-" + (ctrTab + 2).ToString();
                }
                else
                {
                    t.Name = "Tab-" + (ctrTab + 1).ToString();
                    t.Text = "Tab-" + (ctrTab + 1).ToString();
                }


                GroupBox[] groupBoxDataPembeli = new GroupBox[1];

                GroupBox groupBoxDataPembeli_ = new GroupBox();
                GroupBox groupBoxListInvoice = new GroupBox();
                GroupBox groupBoxPembayaran = new GroupBox();

                Label lblCustomerName_ = new Label();
                Label lblAddress_ = new Label();
                Label lblCompanyName_ = new Label();
                Label lblContactNo_ = new Label();
                Label lblMetodePembayaran = new Label();
                Label lblTanggalPembayaran = new Label();
                Label lblNamaVendor = new Label();
                Label lblNamaBarang = new Label();

                TextBox txtCustomerName_ = new TextBox();
                RichTextBox rtbAlamat_ = new RichTextBox();
                TextBox txtCompanyName_ = new TextBox();
                TextBox txtContactNo_ = new TextBox();
                RichTextBox rtbMetodePembayaran = new RichTextBox();
                //TextBox txtNamaBarang = new TextBox();
                //ListBox listNamaBarang = new ListBox();
                AutoCompleteTextbox listNamaBarang = new AutoCompleteTextbox();
                TextBox txtTotHarga = new TextBox();
                txtTotHarga.Font = new Font(txtTotHarga.Font.FontFamily, 24);
                txtTotHarga.ReadOnly = true;
                txtTotHarga.TextAlign = HorizontalAlignment.Right;

                dtItem = Core.ListProduct();

                List<string> source = dtItem.AsEnumerable().Select(x => x[0].ToString()).ToList();

                listNamaBarang.AutoCompleteList = source;

                dgv_invoice = new DataGridView();

                //cbVendorName = new ComboBox();
                //cbItemName = new ComboBox();
                Button btnSave = new Button();
                btnAdd = new Button();
                btnClear = new Button();

                DateTimePicker dtpPembayaran = new DateTimePicker();

                //cbVendorName.Items.Clear();
                //cbItemName.Items.Clear();

                //cbVendorName.DataSource = null;
                //cbItemName.DataSource = null;

                //BindingSource bs = new BindingSource();
                //bs.DataSource = null;

                //cbVendorName.DataSource = bs;
                //bs.DataSource = dtVendor;
                //cbVendorName.DisplayMember = "vendor_name";
                //cbVendorName.ValueMember = "vendor_name";
                //cbVendorName.DropDownStyle = ComboBoxStyle.DropDownList;



                //groupBoxDataPembeli[ctrTab].Name = "groupBoxDataPembeli" + ctrTab.ToString();

                lblCustomerName_.Name = "lblCustomerName" + ctrTab.ToString();
                lblAddress_.Name = "lblAddress" + ctrTab.ToString();
                lblCompanyName_.Name = "lblCompanyName" + ctrTab.ToString();
                lblContactNo_.Name = "lblContactNo" + ctrTab.ToString();
                lblMetodePembayaran.Name = "lblMetodePembayaran" + ctrTab.ToString();
                lblTanggalPembayaran.Name = "lblTanggalPembayaran" + ctrTab.ToString();
                lblNamaVendor.Name = "lblNamaVendor" + ctrTab.ToString();
                lblNamaBarang.Name = "lblNamaBarang" + ctrTab.ToString();

                btnAdd.Name = "btnAdd" + ctrTab.ToString();
                btnClear.Name = "btnClear" + ctrTab.ToString();

                txtCustomerName_.Name = "txtCustomerName" + ctrTab.ToString();
                rtbAlamat_.Name = "rtbAlamat" + ctrTab.ToString();
                txtCompanyName_.Name = "txtCompanyName" + ctrTab.ToString();
                txtContactNo_.Name = "txtContactNo" + ctrTab.ToString();
                rtbMetodePembayaran.Name = "rtbMetodePembayaran" + ctrTab.ToString();
                //txtNamaBarang.Name = "txtNamaBarang" + ctrTab.ToString();
                listNamaBarang.Name = "listNamaBarang" + ctrTab.ToString();
                txtTotHarga.Name = "txtTotHarga" + ctrTab.ToString();

                btnSave.Name = "btnSave" + ctrTab.ToString();
                btnSave.Text = "Proses";

                //cbVendorName.Name = "cbVendorName" + ctrTab.ToString();
                //cbItemName.Name = "cbItemName" + ctrTab.ToString();

                dgv_invoice.Name = "dgv_invoice" + ctrTab.ToString();

                dtpPembayaran.Name = "dtpPembayaran" + ctrTab.ToString();

                groupBoxDataPembeli_.Text = "Data Pembeli";
                groupBoxListInvoice.Text = "List Invoice";
                groupBoxPembayaran.Text = "Pembayaran";

                lblCustomerName_.Text = "Nama Pembeli";
                lblAddress_.Text = "Alamat Pembeli";
                lblCompanyName_.Text = "Nama Perusahaan";
                lblContactNo_.Text = "No. Telp/HP";
                lblMetodePembayaran.Text = "Metode Pembayaran";
                lblTanggalPembayaran.Text = "Tanggal Pembayaran";
                lblNamaVendor.Text = "Nama Vendor";
                lblNamaBarang.Text = "Nama Barang";
                btnAdd.Text = "Tambah";
                btnClear.Text = "Hapus";

                dtpPembayaran.Format = DateTimePickerFormat.Custom;
                dtpPembayaran.CustomFormat = "dd-MM-yyyy";

                groupBoxDataPembeli[0] = groupBoxDataPembeli_;

                groupBoxDataPembeli_.Location = new System.Drawing.Point(16, 31);
                //groupBoxDataPembeli_.Size = new System.Drawing.Size(400, 200);
                groupBoxDataPembeli_.Dock = DockStyle.Fill;
                groupBoxListInvoice.Size = new System.Drawing.Size(870, 400);
                groupBoxListInvoice.Location = new System.Drawing.Point(19, 180);
                groupBoxPembayaran.Size = new System.Drawing.Size(560, 160);
                groupBoxPembayaran.Location = new System.Drawing.Point(330, 20);

                lblCustomerName_.Location = new System.Drawing.Point(19, 25);
                lblAddress_.Location = new System.Drawing.Point(19, 50);
                lblCompanyName_.Location = new System.Drawing.Point(19, 120);
                lblContactNo_.Location = new System.Drawing.Point(19, 147);
                lblMetodePembayaran.Location = new System.Drawing.Point(350, 50);
                lblMetodePembayaran.Size = new System.Drawing.Size(120, 20);
                lblTanggalPembayaran.Location = new System.Drawing.Point(350, 120);
                lblTanggalPembayaran.Size = new System.Drawing.Size(120, 20);

                txtCustomerName_.Location = new System.Drawing.Point(125, 25);
                txtCustomerName_.Size = new System.Drawing.Size(160, 50);
                rtbAlamat_.Location = new System.Drawing.Point(125, 50);
                rtbAlamat_.Size = new System.Drawing.Size(180, 60);
                txtCompanyName_.Location = new System.Drawing.Point(125, 120);
                txtCompanyName_.Size = new System.Drawing.Size(160, 50);
                txtContactNo_.Location = new System.Drawing.Point(125, 147);
                txtContactNo_.Size = new System.Drawing.Size(160, 50);
                rtbMetodePembayaran.Location = new System.Drawing.Point(480, 50);
                rtbMetodePembayaran.Size = new System.Drawing.Size(180, 60);

                dtpPembayaran.Location = new System.Drawing.Point(480, 120);
                dtpPembayaran.Size = new System.Drawing.Size(180, 60);

                //cbVendorName.Size = new System.Drawing.Size(250, 20);
                //cbVendorName.Location = new System.Drawing.Point(40, 230);
                //cbItemName.Size = new System.Drawing.Size(250, 20);
                //cbItemName.Location = new System.Drawing.Point(380, 230);
                //lblNamaVendor.Size = new System.Drawing.Size(120, 20);
                //lblNamaVendor.Location = new System.Drawing.Point(40, 210);
                lblNamaBarang.Size = new System.Drawing.Size(120, 20);
                lblNamaBarang.Location = new System.Drawing.Point(40, 210);
                dgv_invoice.Location = new System.Drawing.Point(40, 260);
                dgv_invoice.Size = new System.Drawing.Size(830, 155);
                //btnAdd.Size = new System.Drawing.Size(100, 20);
                //btnAdd.Location = new System.Drawing.Point(770, 230);
                btnClear.Size = new System.Drawing.Size(100, 20);
                btnClear.Location = new System.Drawing.Point(770, 230);
                btnSave.Size = new System.Drawing.Size(100, 20);
                btnSave.Location = new System.Drawing.Point(770, 470);
                txtTotHarga.Size = new System.Drawing.Size(300, 50);
                txtTotHarga.Location = new System.Drawing.Point(570, 420);
                listNamaBarang.Size = new System.Drawing.Size(400, 20);
                listNamaBarang.Location = new System.Drawing.Point(40, 230);
                dtpPembayaran.BringToFront();

                groupBoxDataPembeli[0].Controls.Add(listNamaBarang);
                groupBoxDataPembeli[0].Controls.Add(btnClear);
                groupBoxDataPembeli[0].Controls.Add(btnSave);
                groupBoxDataPembeli[0].Controls.Add(txtTotHarga);
                //groupBoxDataPembeli[0].Controls.Add(btnAdd);
                groupBoxDataPembeli[0].Controls.Add(lblNamaVendor);
                groupBoxDataPembeli[0].Controls.Add(lblNamaBarang);
                //groupBoxDataPembeli[0].Controls.Add(cbVendorName);
                //groupBoxDataPembeli[0].Controls.Add(cbItemName);
                groupBoxDataPembeli[0].Controls.Add(dtpPembayaran);
                groupBoxDataPembeli[0].Controls.Add(lblCustomerName_);
                groupBoxDataPembeli[0].Controls.Add(lblAddress_);
                groupBoxDataPembeli[0].Controls.Add(lblCompanyName_);
                groupBoxDataPembeli[0].Controls.Add(lblContactNo_);
                groupBoxDataPembeli[0].Controls.Add(lblMetodePembayaran);
                groupBoxDataPembeli[0].Controls.Add(lblTanggalPembayaran);
                groupBoxDataPembeli[0].Controls.Add(txtCustomerName_);
                groupBoxDataPembeli[0].Controls.Add(rtbAlamat_);
                groupBoxDataPembeli[0].Controls.Add(rtbMetodePembayaran);
                groupBoxDataPembeli[0].Controls.Add(txtCompanyName_);
                groupBoxDataPembeli[0].Controls.Add(txtContactNo_);
                groupBoxDataPembeli[0].Controls.Add(dgv_invoice);
                groupBoxDataPembeli[0].Controls.Add(groupBoxListInvoice);
                groupBoxDataPembeli[0].Controls.Add(groupBoxPembayaran);

                t.Controls.Add(groupBoxDataPembeli_);

                tabControl1.TabPages.Add(t);

                //if (dtVendor.Rows.Count > 0)
                //    dtItem = Core.ListProduct_FilterByVendorName(cbVendorName.SelectedValue.ToString());

                if (dtItem.Rows.Count > 0)
                {
                    btnAdd.Enabled = true;
                    //cbItemName.DataSource = dtItem;
                    //cbItemName.DisplayMember = "item_name";
                    //cbItemName.ValueMember = "item_name";
                    //cbItemName.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                //else
                //    btnAdd.Enabled = false;

                //cbVendorName.SelectedIndexChanged +=
                //    new System.EventHandler(cbVendorName_SelectedIndexChanged);

                //btnAdd.Click += (sender, e) => { btnAdd_Click(sender, e, dgv_invoice, dtItem, listNamaBarang.Text.ToString()); };
                btnClear.Click += (sender, e) => { btnClear_Click(sender, e, dgv_invoice, dtItem, listNamaBarang.Text.ToString()); };
                listNamaBarang.KeyPress += (sender, e) => { listNamaBarang_KeyDown(sender, e, dgv_invoice, dtItem, listNamaBarang.Text.ToString()); };
                //new System.EventHandler(btnAdd_Click, dgv_invoice);
                dgv_invoice.CellEndEdit += new DataGridViewCellEventHandler((s, e1) => dgv_invoice_CellEndEdit(s, e1, txtTotHarga));

                //button.Click += (sender, e) => { MyHandler(sender, e, s1, s2); };

                if (flag != false)
                {
                    ctrTab++;
                    btnDelTab.Enabled = true;
                }
                else
                    flag = true;

                populateComboBox();


            }
            catch (Exception ex)
            {

            }
        }

        //private void cbVendorName_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //    ComboBox comboBox = (ComboBox)sender;

        //    // Save the selected employee's name, because we will remove
        //    // the employee's name from the list.
        //    string selectedValue = comboBox.SelectedValue.ToString();
        //    dtItem = new DataTable();
        //    if (dtVendor.Rows.Count > 0)
        //        dtItem = Core.ListProduct_FilterByVendorName(selectedValue);

        //    if (dtItem.Rows.Count > 0)
        //    {
        //        btnAdd.Enabled = true;
        //        //cbItemName.DataSource = null;
        //        //cbItemName.Items.Clear();
        //        //cbItemName.DataSource = dtItem;
        //        //cbItemName.DisplayMember = "item_name";
        //        //cbItemName.ValueMember = "item_name";
        //        //cbItemName.DropDownStyle = ComboBoxStyle.DropDownList;
        //    }
        //    else
        //    {
        //        //cbItemName.DataSource = null;
        //        //cbItemName.Items.Clear();
        //        btnAdd.Enabled = false;
        //    }

        //}

        private void btnAdd_Click(object sender, System.EventArgs e, DataGridView dgv_invoice, DataTable dtItem, string itemName)
        {
            Button btnAdd = (Button)sender;
            DataTable dtCopy = new DataTable();
            bool isExist = false;

            if(dgv_invoice.DataSource != null)
                dtCopy = (DataTable)(dgv_invoice.DataSource);

            if (dtItem.Rows.Count > 0)
            {
                dtItem = Core.ListProduct_FilterByItemName(itemName);

                if (dtCopy.Rows.Count == 0)
                    dtCopy = dtItem.Copy();
                else
                    dtCopy.Merge(dtItem);

                if (dtCopy.Rows.Count > 0)
                {
                    DataColumnCollection columns = dtCopy.Columns;                    

                    if (!columns.Contains("Jumlah Beli"))
                    {
                        dtCopy.Columns.Add("Jumlah Beli");
                        dtCopy.Columns.Add("Total Harga");
                    }

                    dgv_invoice.DataSource = dtCopy;
                    // Get all rows entered on each press of Enter.
                    var collection = dgv_invoice.Rows;
                    //dgv_invoice.Rows.Clear();
                    string output = "";
                    foreach (DataGridViewRow row in collection)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                output += cell.Value.ToString() + " ";
                            }
                        }
                    }

                    //DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                    DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
                    dgv_invoice.Columns["Nama Vendor"].Visible = false;
                    dgv_invoice.Columns["Kategori"].Visible = false;
                    dgv_invoice.Columns["Satuan"].Visible = false;
                    dgv_invoice.Columns["Isi"].Visible = false;
                    dgv_invoice.Columns["Harga Cost"].Visible = false;
                    dgv_invoice.Columns["Harga Eceran"].Visible = false;
                    dgv_invoice.Columns["Harga Grosir"].Visible = false;
                    dgv_invoice.Columns["Min. Qty Grosir"].Visible = false;

                    DataGridViewColumnCollection dgvColumns = dgv_invoice.Columns;
                    dgv_invoice.AllowUserToAddRows = false;

                    if (!dgvColumns.Contains("Checkbox"))
                    {
                        //btnColumn.Name = "Action";
                        //btnColumn.HeaderText = "Action";
                        //btnColumn.Text = "Hapus";
                        //btnColumn.UseColumnTextForButtonValue = true;
                        //dgv_invoice.Columns.Insert(dtCopy.Columns.Count, btnColumn);
                        chkColumn.Name = "Checkbox";
                        chkColumn.HeaderText = "";
                        dgv_invoice.Columns.Insert(dtCopy.Columns.Count, chkColumn);
                    }

                    if(dgv_invoice.Rows.Count > 0)
                    {
                        // disable edit on column 1 & 2
                        for (int i = 0; i < dgv_invoice.Rows.Count; i++)
                        {
                            dgv_invoice.Rows[i].Cells[0].ReadOnly = true;
                            dgv_invoice.Rows[i].Cells[1].ReadOnly = true;
                            dgv_invoice.Rows[i].Cells[11].ReadOnly = true;
                        }

                        dgv_invoice.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv_invoice.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv_invoice.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv_invoice.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;

                        dgv_invoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        dgv_invoice.Columns[11].ValueType = Type.GetType("System.Decimal");
                        dgv_invoice.Columns[11].DefaultCellStyle.Format = "c";
                    }

                    // Display.
                    this.Text = output;

                    //dgv_invoice.CellContentClick += new DataGridViewCellEventHandler(dgv_invoice_CellClick);
                    //btnClear.Click += (sender, e) => { btnClear_Click(sender, e, dgv_invoice, dtItem, listNamaBarang.Text.ToString()); };

                    //dgv_invoice.CellEndEdit += new DataGridViewCellEventHandler((s, e1) => dgv_invoice_CellEndEdit(s, e1, txtCompanyName));
                }

            }
            else
            {
                MessageBox.Show("Nama Barang harus dipilih");
                btnAdd.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e, DataGridView dgv_invoice, DataTable dtItem, string itemName)
        {
            Button btnClear = (Button)sender;
            DataTable dtCopy = new DataTable();

            if (dgv_invoice.DataSource != null)
                dtCopy = (DataTable)(dgv_invoice.DataSource);

            if (dgv_invoice.Rows.Count > 0)
            {
                if (dgv_invoice.SelectedRows.Count == dgv_invoice.Rows.Count)
                {
                    dgv_invoice.Rows.Clear();
                }
                foreach (DataGridViewRow row in dgv_invoice.SelectedRows)
                {
                    dgv_invoice.Rows.Remove(row);
                }
                List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgv_invoice.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Checkbox"].Value) == true)
                    {
                        rows_with_checked_column.Add(row);
                    }
                }

                if(rows_with_checked_column.Count > 0)
                {
                    foreach (DataGridViewRow row in rows_with_checked_column)
                    {
                        dgv_invoice.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void listNamaBarang_KeyDown(object sender, KeyPressEventArgs e, DataGridView dgv_invoice, DataTable dtItem, string itemName)
        {
            DataTable dtCopy = new DataTable();
            
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (dgv_invoice.DataSource != null)
                    dtCopy = (DataTable)(dgv_invoice.DataSource);

                if (dtItem.Rows.Count > 0)
                {
                    dtItem = Core.ListProduct_FilterByItemName(itemName);

                    if (dtCopy.Rows.Count == 0)
                        dtCopy = dtItem.Copy();
                    else
                        dtCopy.Merge(dtItem);

                    if (dtCopy.Rows.Count > 0)
                    {
                        DataColumnCollection columns = dtCopy.Columns;

                        if (!columns.Contains("Jumlah Beli"))
                        {
                            dtCopy.Columns.Add("Jumlah Beli");
                            dtCopy.Columns.Add("Total Harga");
                        }

                        dgv_invoice.DataSource = dtCopy;
                        // Get all rows entered on each press of Enter.
                        var collection = dgv_invoice.Rows;
                        //dgv_invoice.Rows.Clear();
                        string output = "";
                        foreach (DataGridViewRow row in collection)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    output += cell.Value.ToString() + " ";
                                }
                            }
                        }

                        //DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                        DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
                        dgv_invoice.Columns["Nama Vendor"].Visible = false;
                        dgv_invoice.Columns["Kategori"].Visible = false;
                        dgv_invoice.Columns["Satuan"].Visible = false;
                        dgv_invoice.Columns["Isi"].Visible = false;
                        dgv_invoice.Columns["Harga Cost"].Visible = false;
                        dgv_invoice.Columns["Harga Eceran"].Visible = false;
                        dgv_invoice.Columns["Harga Grosir"].Visible = false;
                        dgv_invoice.Columns["Min. Qty Grosir"].Visible = false;

                        DataGridViewColumnCollection dgvColumns = dgv_invoice.Columns;
                        dgv_invoice.AllowUserToAddRows = false;

                        if (!dgvColumns.Contains("Checkbox"))
                        {
                            //btnColumn.Name = "Action";
                            //btnColumn.HeaderText = "Action";
                            //btnColumn.Text = "Hapus";
                            //btnColumn.UseColumnTextForButtonValue = true;
                            //dgv_invoice.Columns.Insert(dtCopy.Columns.Count, btnColumn);
                            chkColumn.Name = "Checkbox";
                            chkColumn.HeaderText = "";
                            dgv_invoice.Columns.Insert(dtCopy.Columns.Count, chkColumn);
                        }

                        if (dgv_invoice.Rows.Count > 0)
                        {
                            // disable edit on column 1 & 2
                            for (int i = 0; i < dgv_invoice.Rows.Count; i++)
                            {
                                dgv_invoice.Rows[i].Cells[0].ReadOnly = true;
                                dgv_invoice.Rows[i].Cells[1].ReadOnly = true;
                                dgv_invoice.Rows[i].Cells[11].ReadOnly = true;
                            }

                            dgv_invoice.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dgv_invoice.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dgv_invoice.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dgv_invoice.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;

                            dgv_invoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }

                        // Display.
                        this.Text = output;

                        //dgv_invoice.CellContentClick += new DataGridViewCellEventHandler(dgv_invoice_CellClick);
                        //dgv_invoice.CellEndEdit += new DataGridViewCellEventHandler(dgv_invoice_CellEndEdit);
                    }

                }
                else
                {
                    MessageBox.Show("Nama Barang harus dipilih");
                    btnAdd.Enabled = false;
                }
            }
        }

        void populateComboBox()
        {
            cbTabPages.DataSource = null;
            cbTabPages.Items.Clear();

            foreach (TabPage tab in tabControl1.TabPages)
            {
                cbTabPages.Items.Add(tab.Name.ToString());
            }
            //cbTabPages.DisplayMember = "Value";
            //cbTabPages.ValueMember = "Key";
            if (flag != false)
                cbTabPages.SelectedIndex = 1;

            cbTabPages.Items.Remove("Tab-1");
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            createControls();
            cbTabPages.DropDownStyle = ComboBoxStyle.DropDownList;
            btnDelTab.Enabled = false;
            WindowState = FormWindowState.Maximized;
        }

        private void btnDelTab_Click(object sender, EventArgs e)
        {
            string tabToRemove = cbTabPages.Text.ToString();

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Name.Equals(tabToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }


            if (flag != false)
            {
                ctrTab--;
                if (ctrTab == 0)
                {
                    flag = false;
                    btnDelTab.Enabled = false;
                    ctrTab = 1;
                }
            }

            populateComboBox();
        }

        void retrieveControlsInTabPage()
        {
            foreach (TabPage t in tabControl1.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c is GroupBox)
                    {
                        foreach (Control cc in c.Controls)
                        {
                            if (cc is TextBox)
                            {
                                MessageBox.Show(cc.Name);
                            }
                        }
                    }
                }
            }
        }

        private void dgv_invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_invoice = (DataGridView)sender;
            {
                    //DataGridViewRow delrow = dgv_invoice.Rows[e.RowIndex];
                    //if (delrow.Selected == true)
                    //{
                    //    dgv_invoice.Rows.RemoveAt(e.RowIndex);
                    //}
                    //foreach (DataGridViewRow item in dgv_invoice.SelectedRows)
                    //{
                    //    for (int i = 0; i < dgv_invoice.Rows.Count; i++)
                    //    {
                    //        if (Convert.ToBoolean(dgv_invoice.Rows[i]
                    //                              .Cells[e.ColumnIndex].Value) == true)
                    //        {
                    //            dgv_invoice.Rows.RemoveAt(i);
                    //        }
                    //    }
                    //}
                    //if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                    //{
                    //    if(e.RowIndex >= 0)
                    //    {
                    //        for(int i = 0; i < dgv_invoice.Rows.Count; i++)
                    //        {
                    //            dgv_invoice.Rows[i].Cells[0].ReadOnly = true;
                    //            dgv_invoice.Rows[i].Cells[1].ReadOnly = true;
                    //        }                        
                    //    }                    
                    //}

                    if (dgv_invoice.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        if (e.RowIndex < dgv_invoice.Rows.Count)
                            dgv_invoice.Rows.RemoveAt(e.RowIndex);
                    }

                //delete row from persisted storage

                //rebind data to persisted storage or remove row directly:
                //if (delGridview == true)
                //    dgv_invoice.Rows.RemoveAt(cRow);
                //else
                //    delGridview = true;
            }
        }

        void dgv_invoice_CellEndEdit(object sender, DataGridViewCellEventArgs e, TextBox txtTotHarga)
        {
            try
            {
                // Clear the row error in case the user presses ESC.   
                DataGridView dgv_invoice = (DataGridView)sender;
                dgv_invoice.Rows[e.RowIndex].ErrorText = String.Empty;

                int hargaGrosir = 0;
                int minQtyGrosir = 0;
                int jmlBeli = 0;
                int total = 0;
                int subTotal = 0;

                DataGridViewRow row = dgv_invoice.Rows[e.RowIndex];
                int hargaEceran = int.Parse(row.Cells[3].Value.ToString()); // Harga grosir
                if(row.Cells[4].Value.ToString() != "")
                    hargaGrosir = int.Parse(row.Cells[4].Value.ToString()); // Harga grosir
                if (row.Cells[5].Value.ToString() != "")
                    minQtyGrosir = int.Parse(row.Cells[5].Value.ToString()); // Min qty grosir
                if (row.Cells[10].Value.ToString() != "")
                    jmlBeli = int.Parse(row.Cells[10].Value.ToString()); // Jumlah Beli
                if (row.Cells[11].Value.ToString() != "")
                    total = int.Parse(row.Cells[11].Value.ToString()); // Total

                if(jmlBeli > 0)
                {
                    if (jmlBeli >= minQtyGrosir)
                    {
                        total = hargaGrosir * jmlBeli;
                    }
                    else
                    {
                        total = hargaEceran * jmlBeli;
                    }

                    row.Cells[11].Value = total.ToString();
                }
                else
                {
                    row.Cells[11].Value = "0";
                }

                for (int i = 0; i < dgv_invoice.Rows.Count; ++i)
                {
                    subTotal += Convert.ToInt32(dgv_invoice.Rows[i].Cells[11].Value);
                }

                if (dgv_invoice.Rows.Count == 0)
                    subTotal = 0;

                //txtTotHarga.Text = subTotal.ToString();
                txtTotHarga.Text = subTotal.ToString("C3", CultureInfo.CreateSpecificCulture("id-ID"));
                string[] stringSeparators = new string[] { "Rp" };
                if (txtTotHarga.Text.Contains("Rp") == true)
                    txtTotHarga.Text = "Rp " + txtTotHarga.Text.Split(stringSeparators, StringSplitOptions.None)[1];

            }
            catch (Exception ex)
            {

            }            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            