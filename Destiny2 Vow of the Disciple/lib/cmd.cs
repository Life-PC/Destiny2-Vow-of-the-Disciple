﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2_Vow_of_the_Disciple.lib
{
    public class cmd
    {
        public void Start()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = @"root.bat";

            proc.StartInfo.Verb = "RunAs";

            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }
    }
}