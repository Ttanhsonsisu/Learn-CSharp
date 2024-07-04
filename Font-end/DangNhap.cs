using Microsoft.EntityFrameworkCore;
using QLCHVLXD.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLCHVLXD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
           //Init();

        }
        private void Init()
        {
            
                using (var dbContext = new DataContext())
                {
                    try
                    {
                     string nameDb = dbContext.Database.GetDbConnection().Database;
                        dbContext.Database.EnsureCreated();
                    }
                    catch (Exception ex)
                    {  
                        Console.WriteLine(ex.ToString());
                    }
                }
                //Console.WriteLine(nameDb);
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
