using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace WcfClient
{
    class AdminForm : Form
    {
        private Label label1;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "خدمات الأدمن:";
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(285, 298);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
