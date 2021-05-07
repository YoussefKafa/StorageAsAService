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
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox23;
        private Button button11;
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1030, 16);
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
            this.button2.Location = new System.Drawing.Point(257, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(720, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(720, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Find All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add File";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "RemoveFile";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Get File";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(85, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Find All";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(85, 149);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 46);
            this.button10.TabIndex = 9;
            this.button10.Text = "Update Customer";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 24);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "type";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 24);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "size";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(358, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 24);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "subject";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(579, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 24);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "customerID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(198, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 24);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "file ID";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(198, 123);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(74, 24);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "file ID";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(358, 149);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(74, 24);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "maxQuota";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(438, 149);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(74, 24);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "currentQuota";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(278, 149);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(74, 24);
            this.textBox10.TabIndex = 19;
            this.textBox10.Text = "email";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(198, 149);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(74, 24);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "full Name";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(278, 175);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(74, 24);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "customer ID";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(198, 175);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(74, 24);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "Photo URI";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(518, 149);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(74, 24);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "serviceClass";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(198, 209);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(74, 24);
            this.textBox15.TabIndex = 24;
            this.textBox15.Text = "customer ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(686, 244);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(704, -22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 629);
            this.label1.TabIndex = 26;
            this.label1.Text = " ";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(822, 69);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(74, 24);
            this.textBox16.TabIndex = 27;
            this.textBox16.Text = "full Name";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1062, 69);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(74, 24);
            this.textBox17.TabIndex = 28;
            this.textBox17.Text = "currentQuota";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(982, 70);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(74, 24);
            this.textBox18.TabIndex = 29;
            this.textBox18.Text = "maxQuota";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(902, 70);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(74, 24);
            this.textBox19.TabIndex = 30;
            this.textBox19.Text = "email";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(822, 99);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(74, 24);
            this.textBox20.TabIndex = 31;
            this.textBox20.Text = "serviceClass";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(902, 98);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(74, 24);
            this.textBox21.TabIndex = 32;
            this.textBox21.Text = "photo URI";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(822, 155);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(74, 24);
            this.textBox22.TabIndex = 33;
            this.textBox22.Text = "customer ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(720, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(639, 244);
            this.dataGridView2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.comboBox1.Location = new System.Drawing.Point(438, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1113, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1185, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 38;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(1185, 191);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 24);
            this.textBox23.TabIndex = 39;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1196, 220);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 40;
            this.button11.Text = "Login";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(1371, 505);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
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
            //try { Boolean s = proxy.checkAdmin("admin", "admin"); }
            //  catch (System.Net.WebException)
            //{
            //    Console.WriteLine("Unable to connect to server, please try again later..");
            //}
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            //try
            //{
            //    Boolean s = proxy.checkAdmin("adamin", "admin");
            //    if (s)
            //    {
            //        Console.WriteLine("Connected to Admin Services.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong user name or password");
            //    }
            //}
            //catch (System.Net.WebException)
            //{
            //    Console.WriteLine("Unable to connect to server, please try again later..");
            //}
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            File file = new File();
            file.customerId = Int32.Parse(textBox5.Text);
            if (comboBox1.SelectedIndex == 1)
            {
                file.availability = true;
            }
            else
            {
                file.availability = false;
            }
            file.subject = textBox3.Text;
            file.size = textBox2.Text;
            file.type = textBox1.Text;
            proxy.addFile(file);
            }
            catch { }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { proxy.removeFile(Int32.Parse(textBox6.Text));} catch { }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource= proxy.getFile(Int32.Parse(textBox7.Text));} catch { }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Customer customer = new Customer();
            customer.fullName = textBox11.Text;
            customer.email = textBox10.Text;
            customer.maxQuota = textBox8.Text;
            customer.currentQuota = textBox9.Text;
            customer.serviceClass = textBox14.Text;
            customer.photo = textBox13.Text;
            customer.id = textBox12.Text;
            try {proxy.updateCustomer(customer); } catch { }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try {dataGridView1.DataSource = proxy.findAll(Int32.Parse(textBox15.Text)); }
            catch { }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.fullName = textBox16.Text;
            customer.email = textBox19.Text;
            customer.maxQuota = textBox18.Text;
            customer.currentQuota = textBox17.Text;
            customer.serviceClass = textBox20.Text;
            customer.photo = textBox21.Text;
            try { proxy2.addCustomer(customer);} catch { }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {proxy2.removeCustomer(Int32.Parse(textBox22.Text)); } catch { }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { dataGridView2.DataSource = proxy2.findAll();} catch { }
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean s = proxy.checkAdmin(textBox4.Text, textBox23.Text);
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
    }
}
