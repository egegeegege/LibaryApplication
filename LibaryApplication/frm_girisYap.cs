﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibaryApplication.Orm.Context;
using LibaryApplication.Orm.Entity;

namespace LibaryApplication
{
    public partial class frm_girisYap : Form
    {
        ProjectContext db = new ProjectContext();
        string Email = "";
        string Sifre = "";
        int ID;
        public frm_girisYap()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            List<Kullanıcı> kln = new List<Kullanıcı>();
            kln = db.Kullanıcıs.Where(y => y.Sifre == txt_sifre.Text).ToList();

            foreach (Kullanıcı kullanıcı in kln)
            {
                Sifre = kullanıcı.Sifre.ToString();
                Email = kullanıcı.Email.ToString();
                ID = kullanıcı.ID;
            }

            if (Sifre == txt_sifre.Text)
            {
                if (Email == txt_gmail.Text) 
                {
                    MessageBox.Show("Hoşgeldiniz");
                }
                else
                {
                    MessageBox.Show("Gmail Hatalı");
                }
            }
            else 
            {
                MessageBox.Show("Şifre hatalı");
            }
        }
    }
}
