﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuyenLoiKhackHang f = new QuyenLoiKhackHang();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheLoaiDoiDiem f = new TheLoaiDoiDiem();
            f.ShowDialog();
        }
    }
}
