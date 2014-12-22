﻿/*
NBack, and application that implements dual N-Back training.
Copyright (C) 2008 Erik Mork and Monica Mork
Contact us at: http://www.silverbaylabs.org/

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace NBack
{
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the progress.
        /// </summary>
        /// <param name="prog">0-100</param>
        public void setProgress(double prog)
        {
            Debug.Assert((prog >= 0) && (prog <= 100), "Progress bar set out of bounds");
            if ((prog > 100) || (prog < 0))
                return;

            GreenPart.Width = new GridLength(prog, GridUnitType.Star);
            NonGreenPart.Width = new GridLength(100 - prog, GridUnitType.Star);
        }
    }
}
