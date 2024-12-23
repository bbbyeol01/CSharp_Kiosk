﻿using Coffee_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Kiosk.Controls
{
    public partial class DrinkTypeControl : UserControl
    {
        Drink drink;

        public DrinkTypeControl(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        private void radio_hot_CheckedChanged(object sender, EventArgs e)
        {
            this.drink.Type = "HOT";
        }
        private void radio_ice_CheckedChanged(object sender, EventArgs e)
        {
            this.drink.Type = "ICE";
        }

        public bool Radio_hot
        {
            get { return radio_hot.Enabled; }
            set { this.radio_hot.Enabled = value; }
        }

        public bool Radio_ice
        {
            get { return radio_ice.Enabled; }
            set { this.radio_ice.Enabled = value; }
        }

       
    }
}
