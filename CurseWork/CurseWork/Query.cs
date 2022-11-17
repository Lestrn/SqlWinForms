﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Query : Form
    {
        public Query(string selectedQuery)
        {
            InitializeComponent();
            SelectedQuery = selectedQuery;
            Text = selectedQuery;
        }

        public string SelectedQuery { get; }
    }
}
