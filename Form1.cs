using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace RIOFLIX123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Admin a=new Admin();
            a.setdata("Ruhal","0 ","03421470676" ,"Misri street", "k190315@nu.edu.pk","Rklohana123");
            SetResponse response = await a.client.SetAsync("Admin DATA/" + 2, a);
            Admin result = response.ResultAs<Admin>();
        }
    }
}
