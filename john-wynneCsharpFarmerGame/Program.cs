﻿using Wynne_ITDEV115_501_Assignment7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wynne_ITDEV115_501_Assignment7
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FarmerGameApp());
        }
    }
}
