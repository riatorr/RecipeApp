using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string selectRecipe = "SELECT * FROM recipes";
            SQLiteCommand cmd = new SQLiteCommand(selectRecipe);
            cmd.Connection = sqLiteConnection;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.gvRecipe.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                sqLiteConnection.Close();
            }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            //string selectRecipe = "SELECT * FROM recipes";
            //SQLiteCommand cmd = new SQLiteCommand(selectRecipe);
            //cmd.Connection = sqLiteConnection;
            //SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            //DataSet ds = new DataSet();
            //try
            //{
            //    da.Fill(ds);
            //    DataTable dt = ds.Tables[0];
            //    this.gvRecipe.DataSource = dt;
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    cmd.Dispose();
            //    sqLiteConnection.Close();
            //}
        }

        private void btnaddrecipe_Click(object sender, EventArgs e)
        {
            SQLiteTransaction trans;

            string insert = "INSERT INTO recipes (name, servings, preparation_time) VALUES";
            insert += "(@name, @servings, @preparation_time)";

            SQLiteCommand cmd = new SQLiteCommand(insert);
            cmd.Parameters.AddWithValue("@name", this.txtRecipeName.Text);
            cmd.Parameters.AddWithValue("@servings", this.txtNumServings.Text);
            cmd.Parameters.AddWithValue("@preparation_time", this.txtPrepTime.Text);

            cmd.Connection = sqLiteConnection;
            sqLiteConnection.Open();
            trans = sqLiteConnection.BeginTransaction();
            int retval = 0;

            try
            {
                retval = cmd.ExecuteNonQuery();
                if (retval == 1)
                {
                    MessageBox.Show("Recipe successfully added!");
                }
                else
                {
                    MessageBox.Show("Recipe was not added.");
                }
            }
            catch (Exception ex)
            {

                trans.Rollback();
            }
            finally
            {
                trans.Commit();
                cmd.Dispose();
                sqLiteConnection.Close();
            }
        }
    }
}
