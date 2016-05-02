﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Models;

namespace Kurs.Forms
{
    public partial class DeleteCR : Form
    {
        public int el;
        public DeleteCR(int a)
        {
            InitializeComponent();
            el = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Lists crl = new Lists();
            crl.ls.Remove(crl.ls[el]);
            crl.ls[el].Delete();            
            Close();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
