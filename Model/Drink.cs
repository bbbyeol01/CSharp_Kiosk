﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_build.Model
{
    public class Drink
    {
        
        
        public Drink()
        {

        }
        
        public string Name 
        {
            get; set;
        }

        public int Price 
        {
            get; set; 
        }
        public string Type
        {
            get; set;
        }
        public List<string> Options
        {
            get; set;
        }

        public Image DrinkImage
        {
            get; set;
        }

        public void AddOption(string option)
        {
            this.Options.Add(option);
        }
    }
}