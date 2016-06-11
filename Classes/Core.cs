using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Andy.Classes
{
    class Core
    {
        #region Login
        public static string Login(string un, string pw)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            

            try
            {
                con.Open();

                cmd.CommandText =   "SELECT *                                           " + 
                                    "FROM ms_user                                       " +
                                    "WHERE username = @un AND password = md5(@pw)       ";

                cmd.Parameters.AddWithValue("@un", un);
                cmd.Parameters.AddWithValue("@pw", pw);


                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    result = "Selamat datang, " + un;
                    Core.LogInfo.roles_id = dt.Rows[0]["roles_id"].ToString();
                }
                else
                    result = "Login gagal. Pastikan username dan password yang anda input sudah benar.";

                con.Close();                
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region TambahStaff
        public static string TambahStaff(string un, string pw, string first_name, string last_name,
                                        string address, string mobile_no, string level)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText =   "INSERT                                             " +
                                    "INTO ms_user                                       " +
                                    "(username                                          " +
                                    ",password                                          " +
                                    ",first_name                                        " +
                                    ",last_name                                         " +
                                    ",address                                           " +
                                    ",mobile_no                                         " +
                                    ",level                                             " +
                                    ",created_dt                                            " +
                                    ",created_by                                     " +
                                    ",last_modified_dt                                              " +
                                    ",modified_by                                              " +
                                    ",is_active                                                 " +
                                    ") VALUES                                           " +
                                    "(@un                                               " +
                                    ",md5(@pw)                                               " +
                                    ",@first_name                                               " +
                                    ",@last_name                                               " +
                                    ",@address                                               " +
                                    ",@mobile_no                                               " +
                                    ",@level                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ",1                                               " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@un", un);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();
                               
                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region TambahVendor
        public static string TambahVendor(string vendor_name, string address, string mobile_no
                                        , string email)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_vendor                                       " +
                                    "(vendor_name                                          " +
                                    ",address                                          " +
                                    ",mobile_no                                        " +
                                    ",email                                         " +
                                    ",created_dt                                           " +
                                    ",created_by                                         " +
                                    ",last_modified_dt                                             " +
                                    ",modified_by                                            " +
                                    ",is_active                                     " +
                                    ") VALUES                                           " +
                                    "(@vn                                               " +
                                    ",@address                                               " +
                                    ",@mobile_no                                               " +
                                    ",@email                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ",1                                               " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@vn", vendor_name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region TambahKategori
        public static string TambahKategori(string category_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_kategori                                      " +
                                    "(category_name                                          " +
                                    ",created_dt                                           " +
                                    ",created_by                                         " +
                                    ",last_modified_dt                                             " +
                                    ",modified_by                                            " +
                                    ") VALUES                                           " +
                                    "(@category_name                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@category_name", category_name);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString();
            }

            return result;
        }
        #endregion

        #region TambahSatuan
        public static string TambahSatuan(string nama_satuan)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_satuan                                      " +
                                    "(nama_satuan                                         " +
                                    ",created_dt                                           " +
                                    ",created_by                                         " +
                                    ",last_modified_dt                                             " +
                                    ",modified_by                                            " +
                                    ") VALUES                                           " +
                                    "(@nama_satuan                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@nama_satuan", nama_satuan);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString();
            }

            return result;
        }
        #endregion

        #region TambahProduk
        public static string TambahProduk(string item_name, int stock, int cost_price, int retail_price
                                        , int wholesale_price, int wholesale_number, string vendor_name
                                        , string category, string satuan, int isi)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_item                                       " +
                                    "(item_name                                          " +
                                    ",stock                                          " +
                                    ",cost_price                                          " +
                                    ",retail_price                                        " +
                                    ",wholesale_price                                         " +
                                    ",wholesale_number                                           " +
                                    ",vendor_name                                         " +
                                    ",category                                          " +
                                    ",satuan                                          " +
                                    ",isi                                          " +
                                    ",created_dt                                             " +
                                    ",created_by                                            " +
                                    ",last_modified_dt                                     " +
                                    ",modified_by                                     " +
                                    ") VALUES                                           " +
                                    "(@in                                               " +
                                    ",@stock                                               " +
                                    ",@costPrice                                               " +
                                    ",@rp                                               " +
                                    ",@wp                                               " +
                                    ",@wn                                               " +
                                    ",@vendor_name                                               " +
                                    ",@category                                               " +
                                    ",@satuan                                               " +
                                    ",@isi                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@in", item_name);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@costPrice", cost_price);
                cmd.Parameters.AddWithValue("@rp", retail_price);
                cmd.Parameters.AddWithValue("@wp", wholesale_price);
                cmd.Parameters.AddWithValue("@wn", wholesale_number);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@satuan", satuan);
                cmd.Parameters.AddWithValue("@isi", isi);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region TambahInvoice
        //public static string TambahInvoice(string invoice_no, string buyer_name, string buyer_address, string company_name
        //                                , string buyer_contact_no, string payment_method, string item_name, string vendor_name
        //                                , int is_TO, int is_DP, int is_Palet)
        public static string TambahInvoice(string invoice_name, string buyer_name, string buyer_address, string company_name
                                        , string buyer_contact_no, string payment_method, int purchase_total)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_invoice                                       " +
                                    "(invoice_name                                          " +
                                    ",buyer_name                                          " +
                                    ",buyer_address                                          " +
                                    ",company_name                                        " +
                                    ",buyer_contact_no                                         " +
                                    ",payment_method                                           " +
                                    ",purchase_total                                           " +
                                    ",invoice_dt                                           " +
                                    ",created_by                                           " +
                                    ") VALUES                                           " +
                                    "(@invoice_name                       " +
                                    ",@buyer_name                                               " +
                                    ",@buyer_address                                               " +
                                    ",@company_name                                               " +
                                    ",@buyer_contact_no                                               " +
                                    ",@payment_method                                               " +
                                    ",@purchase_total                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@invoice_name", invoice_name);
                cmd.Parameters.AddWithValue("@buyer_name", buyer_name);
                cmd.Parameters.AddWithValue("@buyer_address", buyer_address);
                cmd.Parameters.AddWithValue("@company_name", company_name);
                cmd.Parameters.AddWithValue("@buyer_contact_no", buyer_contact_no);
                cmd.Parameters.AddWithValue("@payment_method", payment_method);
                cmd.Parameters.AddWithValue("@purchase_total", purchase_total);
                //cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                //cmd.Parameters.AddWithValue("@category", category);
                //cmd.Parameters.AddWithValue("@satuan", satuan);
                //cmd.Parameters.AddWithValue("@isi", isi);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();


                cmd.CommandText = "select last_insert_id()";
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                
                

                result = id.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region TambahInvoiceDetail
        public static string TambahInvoiceDetail(int invoice_id, string invoice_no, string item_name, string vendor_name, int item_total
                                        , int is_TO, int is_DP, int is_Palet, int item_price)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_invoice_detail                                       " +
                                    "(invoice_id                                          " +
                                    ",invoice_name                                          " +
                                    ",item_name                                          " +
                                    ",vendor_name                                        " +
                                    ",item_total                                        " +
                                    ",item_price                                       " +
                                    ",is_TO                                         " +
                                    ",is_DP                                           " +
                                    ",is_Palet                                           " +
                                    ",invoice_dt                                           " +
                                    ",created_by                                           " +
                                    ") VALUES                                           " +
                                    "(@invoice_id                                               " +
                                    ",@invoice_no                       " +
                                    ",@item_name                                               " +
                                    ",@vendor_name                                               " +
                                    ",@item_total                                               " +
                                    ",@item_price                                              " +
                                    ",@is_TO                                               " +
                                    ",@is_DP                                               " +
                                    ",@is_Palet                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@invoice_id", invoice_id);
                cmd.Parameters.AddWithValue("@invoice_no", invoice_no);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@item_total", item_total);
                cmd.Parameters.AddWithValue("@item_price", item_price);
                cmd.Parameters.AddWithValue("@is_TO", is_TO);
                cmd.Parameters.AddWithValue("@is_DP", is_DP);
                cmd.Parameters.AddWithValue("@is_Palet", is_Palet);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);
                
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE ms_item " +
                                    "SET stock = stock - @item_total " +
                                    "WHERE item_name = @item_name " + Environment.NewLine +
                                    "AND vendor_name = @vendor_name ";

                cmd.ExecuteNonQuery();



                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return result;
        }
        #endregion

        #region ImportProduk
        public static string ImportProduk(string item_name, int stock, int cost_price, int retail_price
                                        , int wholesale_price, int wholesale_number, string vendor_name
                                        , string category, string satuan, int isi)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERT                                             " +
                                    "INTO ms_item                                       " +
                                    "(item_name                                          " +
                                    ",stock                                          " +
                                    ",cost_price                                          " +
                                    ",retail_price                                        " +
                                    ",wholesale_price                                         " +
                                    ",wholesale_number                                           " +
                                    ",vendor_name                                         " +
                                    ",category                                          " +
                                    ",satuan                                          " +
                                    ",isi                                          " +
                                    ",created_dt                                             " +
                                    ",created_by                                            " +
                                    ",last_modified_dt                                     " +
                                    ",modified_by                                     " +
                                    ") VALUES                                           " +
                                    "(@in                                               " +
                                    ",@stock                                               " +
                                    ",@costPrice                                               " +
                                    ",@rp                                               " +
                                    ",@wp                                               " +
                                    ",@wn                                               " +
                                    ",@vendor_name                                               " +
                                    ",@category                                               " +
                                    ",@satuan                                               " +
                                    ",@isi                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ",NULL                                               " +
                                    ",NULL                                              " +
                                    ")                                               ";

                cmd.Parameters.AddWithValue("@in", item_name);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@costPrice", cost_price);
                cmd.Parameters.AddWithValue("@rp", retail_price);
                cmd.Parameters.AddWithValue("@wp", wholesale_price);
                cmd.Parameters.AddWithValue("@wn", wholesale_number);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@satuan", satuan);
                cmd.Parameters.AddWithValue("@isi", isi);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }
        #endregion

        #region UpdateProduk
        public static string UpdateProduk(string item_name, int stock, int cost_price, int retail_price
                                        , int wholesale_price, int wholesale_number, string vendor_name
                                        , string category, string satuan, int isi, string key)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "UPDATE ms_item " +
                                    "SET    " +
                                    " item_name = @in " +
                                    ",stock = @stock " +
                                    ",cost_price = @costPrice " +
                                    ",retail_price = @rp " +
                                    ",wholesale_price = @wp " +
                                    ",wholesale_number = @wn " +
                                    ",vendor_name = @vendor_name " +
                                    ",Category = @category " +
                                    ",Satuan = @satuan " +
                                    ",Isi = @isi " +
                                    ",last_modified_dt = NOW() " +
                                    ",modified_by = @superadmin " +
                                    "WHERE CONCAT(item_name, '##', vendor_name) = @key ";

                cmd.Parameters.AddWithValue("@in", item_name);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@costPrice", cost_price);
                cmd.Parameters.AddWithValue("@rp", retail_price);
                cmd.Parameters.AddWithValue("@wp", wholesale_price);
                cmd.Parameters.AddWithValue("@wn", wholesale_number);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@satuan", satuan);
                cmd.Parameters.AddWithValue("@isi", isi);
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }
        #endregion

        #region UpdateInvoice_VOID
        public static string UpdateInvoice_VOID(string invoice_name, string item_name, string void_remarks, int stock)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "UPDATE ms_invoice_detail " +
                                    "SET    " +
                                    " is_void = 1 " +
                                    ",void_dt = NOW() " +
                                    ",void_remarks = @void_remarks " +
                                    ",void_by = @superadmin " +
                                    "WHERE invoice_name = @invoice_name AND item_name = @item_name ";

                cmd.Parameters.AddWithValue("@invoice_name", invoice_name);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@void_remarks", void_remarks);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE ms_item " +
                                    "SET    " +
                                    " stock = stock + @stock " +
                                    ",last_modified_dt = NOW() " +
                                    ",modified_by = @superadmin " +
                                    "WHERE item_name = @item_name ";

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }
        #endregion

        #region UpdateUserPassword
        public static string UpdateUserPassword(string userid, string password)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "UPDATE ms_user " +
                                    "SET    " +
                                    " password = md5(@password) " +
                                    ",last_modified_dt = NOW() " +
                                    ",modified_by = @superadmin " +
                                    "WHERE username = @userid";

                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@superadmin", Core.LogInfo.userid);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }
        #endregion

        #region ListStaff
        public static DataTable ListStaff() 
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText =   "SELECT username, first_name,last_name    " +
                                    ",address, mobile_no, level, created_by             " +
                                    ",CASE is_active WHEN 0 THEN 'NOTACTIVE'             " +
                                    "WHEN 1 THEN 'ACTIVE' END as 'status'               " +
                                    "FROM ms_user                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListVendor
        public static DataTable ListVendor()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT vendor_name, address,mobile_no    " +
                                    ",email, created_by             " +
                                    ",CASE is_active WHEN 0 THEN 'NOTACTIVE'             " +
                                    "WHEN 1 THEN 'ACTIVE' END as 'status'               " +
                                    "FROM ms_vendor                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListVendorName
        public static DataTable ListVendorName()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT vendor_name " +
                                    "FROM ms_vendor                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListKategori
        public static DataTable ListKategori()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT category_name " +
                                    "FROM ms_kategori WHERE is_deleted = 0                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString();
            }

            return dt;
        }
        #endregion

        #region ListSatuan
        public static DataTable ListSatuan()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT nama_satuan " +
                                    "FROM ms_satuan WHERE is_deleted = 0                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString();
            }

            return dt;
        }
        #endregion

        #region ListEkspedisi
        public static DataTable ListEkspedisi()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT nama_ekspedisi " +
                                    "FROM ms_ekspedisi WHERE is_deleted = 0 ORDER BY nama_ekspedisi                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString();
            }

            return dt;
        }
        #endregion

        #region ListProduct
        public static DataTable ListProduct()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT item_name, stock, cost_price, retail_price    " +
                                    ",wholesale_price, wholesale_number, vendor_name, category, satuan, isi             " +
                                    "FROM ms_item where is_deleted = 0 order by stock                                    ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListProduct_FilterByVendorName
        public static DataTable ListProduct_FilterByVendorName(string vendor_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT item_name, stock, cost_price, retail_price    " +
                                    ",wholesale_price, wholesale_number, vendor_name, category, satuan, isi             " +
                                    "FROM ms_item where is_deleted = 0 AND vendor_name = @vendor_name order by stock                                    ";

                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListProduct_FilterByItemName
        public static DataTable ListProduct_FilterByItemName(string item_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT item_name as 'Nama Barang', stock as 'Stok', cost_price as 'Harga Cost', retail_price as 'Harga Eceran'    " +
                                    ",wholesale_price as 'Harga Grosir', wholesale_number as 'Min. Qty Grosir', vendor_name as 'Nama Vendor', category as 'Kategori', satuan as 'Satuan', isi as 'Isi'            " +
                                    "FROM ms_item where is_deleted = 0 AND item_name = @item_name order by stock                                    ";
                
                cmd.Parameters.AddWithValue("@item_name", item_name);


                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region ListProduct_ALL
        public static DataTable ListProduct_ALL()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT item_name as 'Nama Barang', stock as 'Stok', cost_price as 'Harga Cost' " +
                                   " , retail_price as 'Harga Eceran', wholesale_price as 'Harga Grosir' " +
                                    ", wholesale_number as 'Min. Qty Grosir', vendor_name as 'Nama Vendor', category as 'Kategori' "+
                                    ", satuan as 'Satuan', isi as 'Isi'" +
                                    ",CONCAT(item_name, '##', vendor_name) as 'key' " +
                                    "FROM ms_item                                       ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString(); ;
            }

            return dt;
        }
        #endregion

        #region ListInvoice_ALL
        public static DataTable ListInvoice_ALL()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT a.invoice_id, a.invoice_name 'Invoice Name', a.buyer_name 'Nama Pembeli' " +
                                   ", a.purchase_total 'Total Pembelian', a.invoice_dt 'Tanggal Invoice' " +
                                    "FROM ms_invoice a ORDER BY invoice_dt DESC                                      ";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString(); ;
            }

            return dt;
        }
        #endregion

        #region ListInvoiceMaster_FilterByInvoiceName
        public static DataTable ListInvoiceMaster_FilterByInvoiceName(string invoice_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT a.invoice_id, a.invoice_name 'Invoice Name', a.buyer_name 'Nama Pembeli' " +
                                   ", a.purchase_total 'Total Pembelian', a.invoice_dt 'Tanggal Invoice', a.company_name, a.buyer_address, a.buyer_contact_no, a.payment_method " +
                                    "FROM ms_invoice a WHERE a.invoice_name = @invoice_name ORDER BY invoice_dt DESC                                      ";

                cmd.Parameters.AddWithValue("@invoice_name", invoice_name);

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString(); ;
            }

            return dt;
        }
        #endregion

        #region ListInvoice_FilterByInvoiceName
        public static DataTable ListInvoice_FilterByInvoiceName(string invoice_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT a.invoice_id, a.invoice_name 'Invoice Name', a.item_name 'Nama Barang' " +
                                   ", a.item_total 'Total Barang' " +
                                    "FROM ms_invoice_detail a WHERE invoice_name = @invoice_name and is_void = 0 ORDER BY invoice_dt DESC                                      ";

                cmd.Parameters.AddWithValue("@invoice_name", invoice_name);

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString(); ;
            }

            return dt;
        }
        #endregion

        #region ListInvoiceReport_FilterByInvoiceName
        public static DataTable ListInvoiceReport_FilterByInvoiceName(string invoice_name)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT a.invoice_id, a.invoice_name 'Invoice Name', a.item_name 'Nama Barang' " +
                                   ", a.item_total 'Total Barang', a.invoice_dt " +
                                    "FROM ms_invoice_detail a WHERE invoice_name = @invoice_name and is_void = 0 ORDER BY invoice_dt DESC                                      ";

                cmd.Parameters.AddWithValue("@invoice_name", invoice_name);

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error : " + ex.ToString(); ;
            }

            return dt;
        }
        #endregion

        #region SelectInvoice
        public static DataTable SelectInvoice()
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                cmd.CommandText = "SELECT invoice_id, invoice_name    " +
                                    "FROM ms_invoice where DAY(invoice_dt) = DAY(NOW())                                " +
                                    " AND MONTH(invoice_dt) = MONTH(NOW()) " +
                                    " AND YEAR(invoice_dt) = YEAR(NOW()) ORDER BY invoice_dt DESC LIMIT 1";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        #region SelectProfit
        public static DataTable SelectProfit(string filter_type, string day, string month, string year)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();
            MySqlDataAdapter da;

            try
            {
                con.Open();

                if(filter_type == "Harian")
                {
                    cmd.CommandText = "SELECT sum((a.item_total * a.item_price)) as total_penjualan, sum((a.item_total * x.cost_price)) as total_modal " +
                                    "FROM ms_invoice_detail a " +
                                    "LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name " +
                                    ", (select cost_price, item_name, vendor_name from ms_item) as x " +
                                    "where x.item_name = a.item_name AND x.vendor_name = a.vendor_name " +
                                    "AND day(a.invoice_dt) = @day AND month(a.invoice_dt) = @month  AND year(a.invoice_dt) = @year";
                }
                else if (filter_type == "Mingguan")
                {
                    cmd.CommandText = "SELECT sum((a.item_total * a.item_price)) as total_penjualan, sum((a.item_total * x.cost_price)) as total_modal " +
                                    "FROM ms_invoice_detail a " +
                                    "LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name " +
                                    ", (select cost_price, item_name, vendor_name from ms_item) as x " +
                                    "where x.item_name = a.item_name AND x.vendor_name = a.vendor_name " +
                                    "AND DATE(invoice_dt) = DATE_SUB(CURDATE(), INTERVAL 7 DAY) ";
                }
                else if (filter_type == "Bulanan")
                {
                    cmd.CommandText = "SELECT sum((a.item_total * a.item_price)) as total_penjualan, sum((a.item_total * x.cost_price)) as total_modal " +
                                    "FROM ms_invoice_detail a " +
                                    "LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name " +
                                    ", (select cost_price, item_name, vendor_name from ms_item) as x " +
                                    "where x.item_name = a.item_name AND x.vendor_name = a.vendor_name " +
                                    "DATE(edit_date) = DATE_SUB(CURDATE(), INTERVAL 7 DAY) ";
                }

                cmd.Parameters.AddWithValue("@day", int.Parse(day));
                cmd.Parameters.AddWithValue("@month", int.Parse(month));
                cmd.Parameters.AddWithValue("@year", int.Parse(year));


                // ini kalo mau di breakdown detail pembelian item apa aja
                //SELECT a.item_name, a.item_total, a.item_price, x.cost_price, (a.item_total * a.item_price) as total_penjualan, (a.item_total * x.cost_price) as total_modal
                //FROM ms_invoice_detail a
                //LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name
                //, (select cost_price, item_name, vendor_name from ms_item) as x
                //where x.item_name = a.item_name AND x.vendor_name = a.vendor_name
                //AND day(a.invoice_dt) = 10
                //group by a.item_name




                //SELECT(
                //FROM ms_invoice_detail a
                //LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name
                //, (select cost_price, item_name, vendor_name from ms_item) as x
                //where x.item_name = a.item_name AND x.vendor_name = a.vendor_name
                //AND day(a.invoice_dt) = 10

                //                                    SELECT *
                //FROM ms_invoice_detail a
                //LEFT JOIN ms_invoice b ON b.invoice_name = a.invoice_name
                //, (select cost_price, item_name, vendor_name from ms_item) as x
                //where x.item_name = a.item_name AND x.vendor_name = a.vendor_name
                ////AND day(a.invoice_dt) = 10
                //                                    where DAY(invoice_dt) = DAY(NOW())                                " +
                //                                    " AND MONTH(invoice_dt) = MONTH(NOW()) " +
                //                                    " AND YEAR(invoice_dt) = YEAR(NOW()) ORDER BY invoice_dt DESC LIMIT 1";

                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                result = "Error";
            }

            return dt;
        }
        #endregion

        //wb 20160610
        #region BackupDB
        public static void BackupDB()
        {
            string conStr = "server=localhost;user=root;pwd=;database=pos_andy;";
            string day, month, year, hour, minute, second;
            string date;
            string milliseconds = (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond).ToString();

            date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            year = date.Split('-')[0];
            month = date.Split('-')[1];
            day = date.Split('-')[2];
            hour = date.Split('-')[3];
            minute = date.Split('-')[4];
            second = date.Split('-')[5];

            string combineTime = year + month + day + hour + minute + second;

            string file = "C:\\Backup Database\\" + "pos_" + combineTime + milliseconds.Substring(0,3) + ".sql";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conStr))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();

                            MessageBox.Show("Backup Berhasil");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Teknikal Error, Backup Gagal");
            }           
        }
        #endregion

        //wb 20160610
        #region LogInfo
        public static class LogInfo
        {
            public static string userid;
            public static string roles_id;
        }
        #endregion

    }
}
