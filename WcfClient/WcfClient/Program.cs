using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceReference1;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace WcfClient
{
    class Program : Form
    {
        CustomerWcfClient client = new CustomerWcfClient();
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Button button3;
        private Button button2;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox6;
        private Button button4;
        private Label label13;
        private Label label14;
        private Button button5;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;

        public Program()
        {
            InitializeComponent();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            button3.Hide();
            button5.Hide();
            textBox3.Hide();
            textBox4.Hide();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(1014, 240);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "خدمات الزبون المتاحة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 6);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(269, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "لإستخدام خدمات الادمن يرجى ادخال ما يلي:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(913, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 24);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(913, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 24);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1063, 37);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المستخدم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1085, 63);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "كلمة السر:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1044, 120);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "يرجى ادخال معلومات صحيحة.";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(953, 143);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(301, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "للحصول على المستخدمين الذين تجاوزو 90 بالمئة:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(953, 165);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(303, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "لتغيير المساحة المخصصة لمستخدم ادخل ما يلي :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(816, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1051, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1157, 205);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "رقم المعرف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(922, 205);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "المساحة الجديدة";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(826, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "اضغط هنا";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(689, 325);
            this.dataGridView1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(866, 273);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(384, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "للحصول على اخر عشر ملفات بخصوص موضوع معين ادخل ما يلي:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1090, 294);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "الموضوع المطلوب";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(978, 291);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 24);
            this.textBox5.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1097, 349);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "رقم معرف الملف";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(985, 346);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 24);
            this.textBox6.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(644, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 24);
            this.button4.TabIndex = 22;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(979, 319);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(260, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "لتغيير اتاحية ملف معين يرجى ادخال ما يلي:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(881, 346);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "الاتاحية الجديدة";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(728, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 26);
            this.button5.TabIndex = 28;
            this.button5.Text = "تغيير";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.comboBox1.Location = new System.Drawing.Point(754, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(1266, 395);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
            static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Boolean res= client.checkAdmin(textBox1.Text, textBox2.Text);
            if (res)
            {
                label5.Hide();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                button3.Show();
                button5.Show();
                textBox3.Show();
                textBox4.Show();
            }
            else
            {
                label5.Show();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                button3.Hide();
                button5.Hide();
                textBox3.Hide();
                textBox4.Hide();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getCustomersWith90Quota();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client.updateCustomerQuota(textBox3.Text, textBox4.Text);
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getTheNewest10PublicFilesBySubject(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.updateFileAvailability(comboBox1.SelectedIndex.ToString(), textBox6.Text);
            textBox6.Text = "";
            comboBox1.Text = "";
        }
    }
}
