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
        ICustomerManager proxy = (ICustomerManager)Activator.GetObject(typeof(ICustomerManager), "http://localhost:5000/MyCustomerService.soap");
        IAdminManager proxy2 = (IAdminManager)Activator.GetObject(typeof(IAdminManager), "http://localhost:5000/MyAdminService.soap");
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private DataGridView dataGridView2;
        private Button button2;

        public Program()
        {
            HttpChannel httpChannel = new HttpChannel();
            ChannelServices.RegisterChannel(httpChannel, false);
            InitializeComponent();
        }
        static void Main(string[] args) 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(729, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Customer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove Customer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(509, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Find All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add File";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "RemoveFile";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Get File";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Find All";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 46);
            this.button10.TabIndex = 9;
            this.button10.Text = "Update Customer";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "type";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "size";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "subject";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "availability";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(413, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "customerID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(93, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "file ID";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(93, 126);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(74, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "file ID";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(253, 152);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(74, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "maxQuota";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(333, 152);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(74, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "currentQuota";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(173, 152);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(74, 20);
            this.textBox10.TabIndex = 19;
            this.textBox10.Text = "email";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(93, 152);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(74, 20);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "full Name";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(173, 178);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(74, 20);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "customer ID";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(93, 178);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(74, 20);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "Photo URI";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(413, 152);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(74, 20);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "serviceClass";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(93, 215);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(74, 20);
            this.textBox15.TabIndex = 24;
            this.textBox15.Text = "customer ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 244);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(493, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 629);
            this.label1.TabIndex = 26;
            this.label1.Text = " ";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(611, 67);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(74, 20);
            this.textBox16.TabIndex = 27;
            this.textBox16.Text = "full Name";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(851, 67);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(74, 20);
            this.textBox17.TabIndex = 28;
            this.textBox17.Text = "currentQuota";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(771, 68);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(74, 20);
            this.textBox18.TabIndex = 29;
            this.textBox18.Text = "maxQuota";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(691, 68);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(74, 20);
            this.textBox19.TabIndex = 30;
            this.textBox19.Text = "email";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(611, 97);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(74, 20);
            this.textBox20.TabIndex = 31;
            this.textBox20.Text = "serviceClass";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(691, 96);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(74, 20);
            this.textBox21.TabIndex = 32;
            this.textBox21.Text = "photo URI";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(611, 153);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(74, 20);
            this.textBox22.TabIndex = 33;
            this.textBox22.Text = "customer ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(509, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(475, 244);
            this.dataGridView2.TabIndex = 34;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(993, 505);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { Boolean s = proxy.checkAdmin("admin", "admin"); }
              catch (System.Net.WebException)
            {
                Console.WriteLine("Unable to connect to server, please try again later..");
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                Boolean s = proxy.checkAdmin("adamin", "admin");
                if (s)
                {
                    Console.WriteLine("Connected to Admin Services.");
                }
                else
                {
                    Console.WriteLine("Wrong user name or password");
                }
            }
            catch (System.Net.WebException)
            {
                Console.WriteLine("Unable to connect to server, please try again later..");
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
