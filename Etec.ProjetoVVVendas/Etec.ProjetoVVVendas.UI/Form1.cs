﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.ProjetoVVVendas.UI
{
    public partial class Login_UI : Form
    {
        public Login_UI()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

        }
    }
}
