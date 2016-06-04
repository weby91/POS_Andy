using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

            try
            {
                con.Open();

                cmd.CommandText =   "SELECT *                                           " + 
                                    "FROM ms_user                                       " +
                                    "WHERE username = @un AND password = md5(@pw)       ";

                cmd.Parameters.AddWithValue("@un", un);
                cmd.Parameters.AddWithValue("@pw", pw);
                
                int? recordCount = (int?)cmd.ExecuteScalar();

                if (recordCount != null)
                    result = "Selamat datang, " + un;
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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                                        , int is_TO, int is_DP, int is_Palet)
        {
            string result = "";
            string conStr = "server=localhost;database=pos_andy;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "INSERTs                                             " +
                                    "INTO ms_invoice_detail                                       " +
                                    "(invoice_id                                          " +
                                    ",invoice_name                                          " +
                                    ",item_name                                          " +
                                    ",vendor_name                                        " +
                                    ",item_total                                        " +
                                    ",is_TO                                         " +
                                    ",is_DP                                           " +
                                    ",is_Palet                                           " +
                                    ",invoice_dt                                           " +
                                    ",created_by                                           " +
                                    ") VALUES                                           " +
                                    "(@invoice_id                                               " +
                                    ",CONCAT('INV',YEAR(NOW()), MONTH(NOW()), DAY(NOW()), @invoice_no)                       " +
                                    ",@item_name                                               " +
                                    ",@vendor_name                                               " +
                                    ",@item_total                                               " +
                                    ",@is_TO                                               " +
                                    ",@is_DP                                               " +
                                    ",@is_Palet                                               " +
                                    ",NOW()                                              " +
                                    ",@superadmin                                               " +
                                    ")                                               " + Environment.NewLine +
                                    "UPDATE ms_item " +
                                    "SET stock = stock - @item_total " +
                                    "WHERE item_name = @item_name AND vendor_name = @vendor_name ";

                cmd.Parameters.AddWithValue("@invoice_id", invoice_id);
                cmd.Parameters.AddWithValue("@invoice_no", invoice_no);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@item_total", item_total);
                cmd.Parameters.AddWithValue("@is_TO", is_TO);
                cmd.Parameters.AddWithValue("@is_DP", is_DP);
                cmd.Parameters.AddWithValue("@is_Palet", is_Palet);
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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
                cmd.Parameters.AddWithValue("@superadmin", "andy");

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


    }
}
