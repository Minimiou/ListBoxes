﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class frmMain : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();

        public frmMain()
        {
            InitializeComponent();

            for (int i = 0; i < 30; i++)
            {
                numbers.Add(generator.Next(100));
            }
                
            lstNumbers.DataSource = numbers;

            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: numbers sorted";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: heroes sorted";
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            btnRemoveNumber.Enabled = true;
            numbers.Clear();
            for (int i = 0; i < 30; i++)
            {
                numbers.Add(generator.Next(100));
            }
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: new numbers list";
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: new heroes list";
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {

            if (numbers.Count > 1)
            {
                numbers.Remove((Int32)lstNumbers.SelectedItem);
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = "Status: number removed";
            }
            else if (numbers.Count <= 1)
            {
                lblStatus.Text = "Status: Cannot remove\nanymore numbers";
                btnRemoveNumber.Enabled = false;
            }

        }
//lstHeroes.Remove((Int32)txtRemoveHero.Text);
        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            int num = (Int32)lstNumbers.SelectedItem;

            while (numbers.Remove(num))
            {
                 
            }
            lblStatus.Text = $"Status: {30 - numbers.Count} numbers were removed";
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            txtRemoveHero.Text = txtRemoveHero.Text.Trim();
            string deletehero = (txtRemoveHero.Text);

            if (heroes.Contains(deletehero))
            {
                while (heroes.Remove(deletehero))
                {
                    lblStatus.Text = $"Status: hero was removed";
                }
            }
            else
            {
                lblStatus.Text = $"Status: that is an \ninvalid hero";
            }

            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            txtRemoveHero.Clear();
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            txtAddHero.Text = txtAddHero.Text.Trim();
            string addhero = txtAddHero.Text;
            
            if (!heroes.Contains(addhero))
            {
                heroes.Add(addhero);
                lblStatus.Text = $"Status: hero has been \nadded to the list";

            }
            else
            {
                lblStatus.Text = $"Status: this hero is \nalready in the list";
            }
            if (txtAddHero.Text.Equals(""))
            {
                lblStatus.Text = "This is an invalid hero";
                if (heroes.Contains(""))
                {
                    heroes.Remove("");
                }

            }
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            txtAddHero.Clear();
        }
    }
}
