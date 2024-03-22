namespace AppLock
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.siticoneGroupBox1 = new ns1.SiticoneGroupBox();
            this.lollipopSmallCard1 = new LollipopSmallCard();
            this.textBox1 = new ns1.SiticoneTextBox();
            this.siticoneGroupBox2 = new ns1.SiticoneGroupBox();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rulesHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 3;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(10, 386);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(654, 34);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "Kuralı Ekle";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneGroupBox1.BorderRadius = 3;
            this.siticoneGroupBox1.Controls.Add(this.lollipopSmallCard1);
            this.siticoneGroupBox1.Controls.Add(this.textBox1);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton1);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(674, 430);
            this.siticoneGroupBox1.TabIndex = 8;
            this.siticoneGroupBox1.Text = "Kural Ekleme Bölümü";
            this.siticoneGroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lollipopSmallCard1
            // 
            this.lollipopSmallCard1.BackColor = System.Drawing.Color.White;
            this.lollipopSmallCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lollipopSmallCard1.FontColor = "191; 191; 191";
            this.lollipopSmallCard1.Image = null;
            this.lollipopSmallCard1.Info = "";
            this.lollipopSmallCard1.Location = new System.Drawing.Point(10, 97);
            this.lollipopSmallCard1.Name = "lollipopSmallCard1";
            this.lollipopSmallCard1.Size = new System.Drawing.Size(654, 52);
            this.lollipopSmallCard1.TabIndex = 12;
            this.lollipopSmallCard1.Text = "Uygulama Seçin";
            this.lollipopSmallCard1.Click += new System.EventHandler(this.lollipopSmallCard1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 3;
            this.textBox1.BorderThickness = 0;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.Parent = this.textBox1;
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedState.Parent = this.textBox1;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.textBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.HoveredState.Parent = this.textBox1;
            this.textBox1.Location = new System.Drawing.Point(10, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.textBox1.PlaceholderText = "Kuralın ismini girin";
            this.textBox1.SelectedText = "";
            this.textBox1.ShadowDecoration.Parent = this.textBox1;
            this.textBox1.Size = new System.Drawing.Size(654, 40);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneGroupBox2.BorderRadius = 3;
            this.siticoneGroupBox2.Controls.Add(this.siticoneButton2);
            this.siticoneGroupBox2.Controls.Add(this.listView1);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.siticoneGroupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(674, 430);
            this.siticoneGroupBox2.TabIndex = 12;
            this.siticoneGroupBox2.Text = "Kural Kaldırma Bölümü";
            this.siticoneGroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 3;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(10, 386);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(654, 34);
            this.siticoneButton2.TabIndex = 6;
            this.siticoneButton2.Text = "Kuralı Sil";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rulesHeader1});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(10, 51);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(653, 330);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // rulesHeader1
            // 
            this.rulesHeader1.Text = "Kurallar";
            this.rulesHeader1.Width = 630;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this.listView1;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(838, 444);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.DimGray;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.DarkGray;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(150, 40);
            this.guna2TabControl1.TabIndex = 13;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage1.Controls.Add(this.siticoneGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kural Ekle";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage2.Controls.Add(this.siticoneGroupBox2);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kural Kaldır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.guna2TabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AppLock";
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox2.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneGroupBox siticoneGroupBox1;
        private ns1.SiticoneTextBox textBox1;
        private ns1.SiticoneGroupBox siticoneGroupBox2;
        private ns1.SiticoneButton siticoneButton2;
        private LollipopSmallCard lollipopSmallCard1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader rulesHeader1;
        private ns1.SiticoneElipse siticoneElipse1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

