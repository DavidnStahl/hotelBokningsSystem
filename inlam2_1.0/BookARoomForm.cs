using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam2_1._0
{
    public partial class BookARoomForm : Form
    {
        private readonly MainMenuForm mainForm;

        public BookARoomForm(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
