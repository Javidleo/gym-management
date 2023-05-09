using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManagement.Service;

namespace GymManagement
{
    public partial class MenuUserControl : UserControl
    {
        private readonly UserService _service = new UserService();
        public MenuUserControl()
        {
            InitializeComponent();
        }

        
    }
}
