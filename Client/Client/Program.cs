using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using General;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Client
{
   public partial class Program :Form
    {
        private Button button1;
        private Button button2;

        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args) 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());


           //HttpChannel httpChannel = new HttpChannel();
           //ChannelServices.RegisterChannel(httpChannel, false);
           //ICustomerManager proxy = (ICustomerManager)Activator.GetObject(typeof(ICustomerManager), "http://localhost:5000/MyService.soap");
           //Console.WriteLine("proxy is ready to use");
           //proxy.findAll();
            Console.ReadKey();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(786, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            this.ResumeLayout(false);

        }
    }
}
