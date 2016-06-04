using POS_Andy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy
{
    public partial class frmListStaff : Form
    {
        public frmListStaff()
        {
            InitializeComponent();
        }

        private void frmListStaff_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            DataTable dt = new DataTable();

            dt = Core.ListStaff();
            dgv_staff.DataSource = dt;
            //lst_staff.Columns.Add("Username");
            //lst_staff.Columns.Add("Nama Depan");
            //lst_staff.Columns.Add("Nama Belakang");
            //lst_staff.Columns.Add("Alamat");
            //lst_staff.Columns.Add("No. Handphone");
            //lst_staff.Columns.Add("Level");
            //lst_staff.Columns.Add("Dibuat oleh");
            //lst_staff.Columns.Add("Status");

            //foreach (DataRow row in dt.Rows)
            //{
            //    //WHAT TYPE HERE? 
            //    lst_staff.Items.Add(new ListViewItem(new string[]{
            //        row["username"].ToString() ,
            //        row["first_name"].ToString() ,
            //        row["address"].ToString() ,
            //        row["mobile_no"].ToString() ,
            //        row["level"].ToString() ,
            //        row["created_by"].ToString() ,
            //        row["status"].ToString() 
            //    }));
            //}

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];
            //    ListViewItem listitem = new ListViewItem(dr["username"].ToString());
            //    listitem.SubItems.Add(dr["first_name"].ToString());
            //    listitem.SubItems.Add(dr["last_name"].ToString());
            //    listitem.SubItems.Add(dr["address"].ToString());
            //    listitem.SubItems.Add(dr["mobile_no"].ToString());
            //    listitem.SubItems.Add(dr["level"].ToString());
            //    listitem.SubItems.Add(dr["created_by"].ToString());
            //    listitem.SubItems.Add(dr["status"].ToString());

            //    lst_staff.Items.Add(listitem);
            //}
        }
    }
}
