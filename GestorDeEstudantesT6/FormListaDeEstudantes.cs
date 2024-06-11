using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormListaDeEstudantes
            // 
            this.ClientSize = new System.Drawing.Size(649, 360);
            this.Name = "FormListaDeEstudantes";
            this.Load += new System.EventHandler(this.FormListaDeEstudantes_Load);
            this.ResumeLayout(false);

        }

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {

        }
    }
}
