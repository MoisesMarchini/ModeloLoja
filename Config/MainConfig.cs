using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloLoja.Config
{
    static class MainConfig
    {
        public static Size LoginFormSize = new Size(346, 259);
        public static Size DefaultLayoutSize = new Size(514, 450);

        public static void SetDefaultSize(Form form, Size size)
        {
            form.MaximumSize = size;
            form.MinimumSize = size;
            form.Size = size;
        }
    }
}
