using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dwelly.Models;
using System.Data.SqlClient;
using Dwelly.ModelViews;

namespace Dwelly.Views
{
    public partial class UsersView : Form
    {
        private UsersMV userMV;
        public UsersView()
        {
            InitializeComponent();
            userMV = new UsersMV();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = userMV.Users;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
