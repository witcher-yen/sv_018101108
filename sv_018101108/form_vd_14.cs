﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sv_018101108
{
    public partial class form_vd_14 : Form
    {
        int time;
        public form_vd_14()
        {
            InitializeComponent();            
        }
        

        private void btn_start_Click(object sender, EventArgs e)
        {
            time = ((int)hour.Value) * 3600 + ((int)minute.Value) * 60 + ((int)second.Value);
            lb_tgcl.Text = "Còn lại " + time.ToString() + " giây";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                lb_tgcl.Text = "Còn lại " + time.ToString() + " giây";
            }
        }

        private void form_vd_14_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
