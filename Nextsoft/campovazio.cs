﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextsoft
{
    class campovazio
    {
        public bool senha(Control controle, string campo)

        {
            if (controle.Text == "")

            {
                MessageBox.Show("O campo " + campo + " é obrigatório!");
                controle.Focus();
                return true;

            }

            else
            {
                return false;
            }

        }
    }
}
