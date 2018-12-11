namespace Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.listView1_Hotels = new System.Windows.Forms.ListView();
            this.Hotel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_error_home_button_city = new System.Windows.Forms.Label();
            this.button_main_city = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_home_city = new System.Windows.Forms.ComboBox();
            this.label_error_home_button_country = new System.Windows.Forms.Label();
            this.button_main_country = new System.Windows.Forms.Button();
            this.comboBox1_home_country = new System.Windows.Forms.ComboBox();
            this.button_main = new System.Windows.Forms.Button();
            this.button_country = new System.Windows.Forms.Button();
            this.button_city = new System.Windows.Forms.Button();
            this.button_hotel = new System.Windows.Forms.Button();
            this.panel_country = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1_Country = new System.Windows.Forms.ListView();
            this.Country1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7_Error_Country_listView = new System.Windows.Forms.Label();
            this.textBox1_Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Country_Add = new System.Windows.Forms.Button();
            this.label__Error_Country_textBox = new System.Windows.Forms.Label();
            this.button_Country_Delete = new System.Windows.Forms.Button();
            this.panel_city = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1_City = new System.Windows.Forms.ListView();
            this.City1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Error_City_listView = new System.Windows.Forms.Label();
            this.textBox1_City = new System.Windows.Forms.TextBox();
            this.comboBox1_City_City = new System.Windows.Forms.ComboBox();
            this.label_Error_City_textBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_City_Add_City = new System.Windows.Forms.Button();
            this.button_City_Delete = new System.Windows.Forms.Button();
            this.panel_hotel = new System.Windows.Forms.Panel();
            this.button_Hotel_Delete = new System.Windows.Forms.Button();
            this.button_Hotel_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label__Error_hotel_label = new System.Windows.Forms.Label();
            this.label_Error_Hotel_listView = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1_hotel = new System.Windows.Forms.ListView();
            this.hotel1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_country1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1_Hotel = new System.Windows.Forms.TextBox();
            this.textBox1_star = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2_cost = new System.Windows.Forms.TextBox();
            this.comboBox1_HotelCityCountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_Description = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_country.SuspendLayout();
            this.panel_city.SuspendLayout();
            this.panel_hotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.listView1_Hotels);
            this.panel_main.Controls.Add(this.label_error_home_button_city);
            this.panel_main.Controls.Add(this.button_main_city);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.comboBox1_home_city);
            this.panel_main.Controls.Add(this.label_error_home_button_country);
            this.panel_main.Controls.Add(this.button_main_country);
            this.panel_main.Controls.Add(this.comboBox1_home_country);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(672, 490);
            this.panel_main.TabIndex = 0;
            // 
            // listView1_Hotels
            // 
            this.listView1_Hotels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hotel,
            this.Country,
            this.City,
            this.Price,
            this.Stars});
            this.listView1_Hotels.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1_Hotels.FullRowSelect = true;
            this.listView1_Hotels.GridLines = true;
            this.listView1_Hotels.Location = new System.Drawing.Point(9, 179);
            this.listView1_Hotels.Name = "listView1_Hotels";
            this.listView1_Hotels.Size = new System.Drawing.Size(650, 293);
            this.listView1_Hotels.TabIndex = 13;
            this.listView1_Hotels.UseCompatibleStateImageBehavior = false;
            this.listView1_Hotels.View = System.Windows.Forms.View.Details;
            // 
            // Hotel
            // 
            this.Hotel.Text = "Hotel";
            this.Hotel.Width = 184;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 164;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 159;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 89;
            // 
            // Stars
            // 
            this.Stars.Text = "Stars";
            this.Stars.Width = 49;
            // 
            // label_error_home_button_city
            // 
            this.label_error_home_button_city.AutoSize = true;
            this.label_error_home_button_city.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error_home_button_city.ForeColor = System.Drawing.Color.Red;
            this.label_error_home_button_city.Location = new System.Drawing.Point(486, 137);
            this.label_error_home_button_city.Name = "label_error_home_button_city";
            this.label_error_home_button_city.Size = new System.Drawing.Size(62, 16);
            this.label_error_home_button_city.TabIndex = 12;
            this.label_error_home_button_city.Text = "Select city!";
            this.label_error_home_button_city.Visible = false;
            // 
            // button_main_city
            // 
            this.button_main_city.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_city.Location = new System.Drawing.Point(366, 133);
            this.button_main_city.Name = "button_main_city";
            this.button_main_city.Size = new System.Drawing.Size(98, 25);
            this.button_main_city.TabIndex = 11;
            this.button_main_city.Text = "Select City";
            this.button_main_city.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cuprum", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "MAIN";
            // 
            // comboBox1_home_city
            // 
            this.comboBox1_home_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_home_city.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1_home_city.FormattingEnabled = true;
            this.comboBox1_home_city.Location = new System.Drawing.Point(19, 133);
            this.comboBox1_home_city.Name = "comboBox1_home_city";
            this.comboBox1_home_city.Size = new System.Drawing.Size(327, 24);
            this.comboBox1_home_city.TabIndex = 9;
            // 
            // label_error_home_button_country
            // 
            this.label_error_home_button_country.AutoSize = true;
            this.label_error_home_button_country.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error_home_button_country.ForeColor = System.Drawing.Color.Red;
            this.label_error_home_button_country.Location = new System.Drawing.Point(486, 96);
            this.label_error_home_button_country.Name = "label_error_home_button_country";
            this.label_error_home_button_country.Size = new System.Drawing.Size(81, 16);
            this.label_error_home_button_country.TabIndex = 7;
            this.label_error_home_button_country.Text = "Select country!";
            this.label_error_home_button_country.Visible = false;
            // 
            // button_main_country
            // 
            this.button_main_country.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_country.Location = new System.Drawing.Point(366, 93);
            this.button_main_country.Name = "button_main_country";
            this.button_main_country.Size = new System.Drawing.Size(98, 25);
            this.button_main_country.TabIndex = 6;
            this.button_main_country.Text = "Select Country";
            this.button_main_country.UseVisualStyleBackColor = true;
            // 
            // comboBox1_home_country
            // 
            this.comboBox1_home_country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_home_country.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1_home_country.FormattingEnabled = true;
            this.comboBox1_home_country.Location = new System.Drawing.Point(19, 93);
            this.comboBox1_home_country.Name = "comboBox1_home_country";
            this.comboBox1_home_country.Size = new System.Drawing.Size(327, 24);
            this.comboBox1_home_country.TabIndex = 5;
            // 
            // button_main
            // 
            this.button_main.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main.Location = new System.Drawing.Point(693, 17);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(98, 35);
            this.button_main.TabIndex = 2;
            this.button_main.Text = "Main";
            this.button_main.UseVisualStyleBackColor = true;
            // 
            // button_country
            // 
            this.button_country.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_country.Location = new System.Drawing.Point(693, 68);
            this.button_country.Name = "button_country";
            this.button_country.Size = new System.Drawing.Size(98, 35);
            this.button_country.TabIndex = 3;
            this.button_country.Text = "Country";
            this.button_country.UseVisualStyleBackColor = true;
            // 
            // button_city
            // 
            this.button_city.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_city.Location = new System.Drawing.Point(693, 119);
            this.button_city.Name = "button_city";
            this.button_city.Size = new System.Drawing.Size(98, 35);
            this.button_city.TabIndex = 4;
            this.button_city.Text = "City";
            this.button_city.UseVisualStyleBackColor = true;
            // 
            // button_hotel
            // 
            this.button_hotel.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hotel.Location = new System.Drawing.Point(693, 171);
            this.button_hotel.Name = "button_hotel";
            this.button_hotel.Size = new System.Drawing.Size(98, 35);
            this.button_hotel.TabIndex = 5;
            this.button_hotel.Text = "Hotel";
            this.button_hotel.UseVisualStyleBackColor = true;
            // 
            // panel_country
            // 
            this.panel_country.Controls.Add(this.button_Country_Delete);
            this.panel_country.Controls.Add(this.label__Error_Country_textBox);
            this.panel_country.Controls.Add(this.button_Country_Add);
            this.panel_country.Controls.Add(this.label3);
            this.panel_country.Controls.Add(this.textBox1_Country);
            this.panel_country.Controls.Add(this.label7_Error_Country_listView);
            this.panel_country.Controls.Add(this.listView1_Country);
            this.panel_country.Controls.Add(this.label2);
            this.panel_country.Location = new System.Drawing.Point(12, 12);
            this.panel_country.Name = "panel_country";
            this.panel_country.Size = new System.Drawing.Size(672, 490);
            this.panel_country.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cuprum", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "COUNTRY";
            // 
            // listView1_Country
            // 
            this.listView1_Country.CheckBoxes = true;
            this.listView1_Country.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Country1});
            this.listView1_Country.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1_Country.FullRowSelect = true;
            this.listView1_Country.GridLines = true;
            this.listView1_Country.Location = new System.Drawing.Point(30, 69);
            this.listView1_Country.Name = "listView1_Country";
            this.listView1_Country.Size = new System.Drawing.Size(320, 403);
            this.listView1_Country.TabIndex = 16;
            this.listView1_Country.UseCompatibleStateImageBehavior = false;
            this.listView1_Country.View = System.Windows.Forms.View.Details;
            // 
            // Country1
            // 
            this.Country1.Text = "Country";
            this.Country1.Width = 314;
            // 
            // label7_Error_Country_listView
            // 
            this.label7_Error_Country_listView.AutoSize = true;
            this.label7_Error_Country_listView.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7_Error_Country_listView.ForeColor = System.Drawing.Color.Red;
            this.label7_Error_Country_listView.Location = new System.Drawing.Point(225, 40);
            this.label7_Error_Country_listView.Name = "label7_Error_Country_listView";
            this.label7_Error_Country_listView.Size = new System.Drawing.Size(125, 16);
            this.label7_Error_Country_listView.TabIndex = 17;
            this.label7_Error_Country_listView.Text = "Select country to delete";
            // 
            // textBox1_Country
            // 
            this.textBox1_Country.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Country.Location = new System.Drawing.Point(366, 104);
            this.textBox1_Country.Name = "textBox1_Country";
            this.textBox1_Country.Size = new System.Drawing.Size(293, 22);
            this.textBox1_Country.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(363, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Country";
            // 
            // button_Country_Add
            // 
            this.button_Country_Add.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Country_Add.Location = new System.Drawing.Point(367, 159);
            this.button_Country_Add.Name = "button_Country_Add";
            this.button_Country_Add.Size = new System.Drawing.Size(98, 35);
            this.button_Country_Add.TabIndex = 6;
            this.button_Country_Add.Text = "Add";
            this.button_Country_Add.UseVisualStyleBackColor = true;
            // 
            // label__Error_Country_textBox
            // 
            this.label__Error_Country_textBox.AutoSize = true;
            this.label__Error_Country_textBox.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label__Error_Country_textBox.ForeColor = System.Drawing.Color.Red;
            this.label__Error_Country_textBox.Location = new System.Drawing.Point(520, 72);
            this.label__Error_Country_textBox.Name = "label__Error_Country_textBox";
            this.label__Error_Country_textBox.Size = new System.Drawing.Size(139, 16);
            this.label__Error_Country_textBox.TabIndex = 20;
            this.label__Error_Country_textBox.Text = "Select or enter the country";
            // 
            // button_Country_Delete
            // 
            this.button_Country_Delete.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Country_Delete.Location = new System.Drawing.Point(561, 159);
            this.button_Country_Delete.Name = "button_Country_Delete";
            this.button_Country_Delete.Size = new System.Drawing.Size(98, 35);
            this.button_Country_Delete.TabIndex = 21;
            this.button_Country_Delete.Text = "Delete";
            this.button_Country_Delete.UseVisualStyleBackColor = true;
            // 
            // panel_city
            // 
            this.panel_city.Controls.Add(this.button_City_Delete);
            this.panel_city.Controls.Add(this.button_City_Add_City);
            this.panel_city.Controls.Add(this.label5);
            this.panel_city.Controls.Add(this.label_Error_City_textBox);
            this.panel_city.Controls.Add(this.comboBox1_City_City);
            this.panel_city.Controls.Add(this.textBox1_City);
            this.panel_city.Controls.Add(this.label_Error_City_listView);
            this.panel_city.Controls.Add(this.listView1_City);
            this.panel_city.Controls.Add(this.label7);
            this.panel_city.Location = new System.Drawing.Point(15, 9);
            this.panel_city.Name = "panel_city";
            this.panel_city.Size = new System.Drawing.Size(672, 490);
            this.panel_city.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cuprum", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "CITY";
            // 
            // listView1_City
            // 
            this.listView1_City.CheckBoxes = true;
            this.listView1_City.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.City1,
            this.Country2});
            this.listView1_City.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1_City.FullRowSelect = true;
            this.listView1_City.GridLines = true;
            this.listView1_City.Location = new System.Drawing.Point(30, 56);
            this.listView1_City.Name = "listView1_City";
            this.listView1_City.Size = new System.Drawing.Size(366, 416);
            this.listView1_City.TabIndex = 16;
            this.listView1_City.UseCompatibleStateImageBehavior = false;
            this.listView1_City.View = System.Windows.Forms.View.Details;
            // 
            // City1
            // 
            this.City1.Text = "City";
            this.City1.Width = 188;
            // 
            // Country2
            // 
            this.Country2.Text = "Country";
            this.Country2.Width = 171;
            // 
            // label_Error_City_listView
            // 
            this.label_Error_City_listView.AutoSize = true;
            this.label_Error_City_listView.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Error_City_listView.ForeColor = System.Drawing.Color.Red;
            this.label_Error_City_listView.Location = new System.Drawing.Point(290, 24);
            this.label_Error_City_listView.Name = "label_Error_City_listView";
            this.label_Error_City_listView.Size = new System.Drawing.Size(106, 16);
            this.label_Error_City_listView.TabIndex = 17;
            this.label_Error_City_listView.Text = "Select city to delete";
            // 
            // textBox1_City
            // 
            this.textBox1_City.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_City.Location = new System.Drawing.Point(415, 96);
            this.textBox1_City.Name = "textBox1_City";
            this.textBox1_City.Size = new System.Drawing.Size(242, 22);
            this.textBox1_City.TabIndex = 18;
            // 
            // comboBox1_City_City
            // 
            this.comboBox1_City_City.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1_City_City.FormattingEnabled = true;
            this.comboBox1_City_City.Location = new System.Drawing.Point(415, 137);
            this.comboBox1_City_City.Name = "comboBox1_City_City";
            this.comboBox1_City_City.Size = new System.Drawing.Size(242, 24);
            this.comboBox1_City_City.TabIndex = 19;
            // 
            // label_Error_City_textBox
            // 
            this.label_Error_City_textBox.AutoSize = true;
            this.label_Error_City_textBox.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Error_City_textBox.ForeColor = System.Drawing.Color.Red;
            this.label_Error_City_textBox.Location = new System.Drawing.Point(602, 64);
            this.label_Error_City_textBox.Name = "label_Error_City_textBox";
            this.label_Error_City_textBox.Size = new System.Drawing.Size(55, 16);
            this.label_Error_City_textBox.TabIndex = 20;
            this.label_Error_City_textBox.Text = "Enter city";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(413, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "City";
            // 
            // button_City_Add_City
            // 
            this.button_City_Add_City.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_City_Add_City.Location = new System.Drawing.Point(415, 200);
            this.button_City_Add_City.Name = "button_City_Add_City";
            this.button_City_Add_City.Size = new System.Drawing.Size(98, 35);
            this.button_City_Add_City.TabIndex = 22;
            this.button_City_Add_City.Text = "Add";
            this.button_City_Add_City.UseVisualStyleBackColor = true;
            // 
            // button_City_Delete
            // 
            this.button_City_Delete.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_City_Delete.Location = new System.Drawing.Point(559, 200);
            this.button_City_Delete.Name = "button_City_Delete";
            this.button_City_Delete.Size = new System.Drawing.Size(98, 35);
            this.button_City_Delete.TabIndex = 23;
            this.button_City_Delete.Text = "Delete";
            this.button_City_Delete.UseVisualStyleBackColor = true;
            // 
            // panel_hotel
            // 
            this.panel_hotel.Controls.Add(this.label12);
            this.panel_hotel.Controls.Add(this.textBox1_Description);
            this.panel_hotel.Controls.Add(this.label11);
            this.panel_hotel.Controls.Add(this.comboBox1_HotelCityCountry);
            this.panel_hotel.Controls.Add(this.textBox2_cost);
            this.panel_hotel.Controls.Add(this.label10);
            this.panel_hotel.Controls.Add(this.label8);
            this.panel_hotel.Controls.Add(this.textBox1_star);
            this.panel_hotel.Controls.Add(this.textBox1_Hotel);
            this.panel_hotel.Controls.Add(this.listView1_hotel);
            this.panel_hotel.Controls.Add(this.button_Hotel_Delete);
            this.panel_hotel.Controls.Add(this.button_Hotel_Add);
            this.panel_hotel.Controls.Add(this.label4);
            this.panel_hotel.Controls.Add(this.label__Error_hotel_label);
            this.panel_hotel.Controls.Add(this.label_Error_Hotel_listView);
            this.panel_hotel.Controls.Add(this.label9);
            this.panel_hotel.Location = new System.Drawing.Point(12, 12);
            this.panel_hotel.Name = "panel_hotel";
            this.panel_hotel.Size = new System.Drawing.Size(672, 490);
            this.panel_hotel.TabIndex = 24;
            // 
            // button_Hotel_Delete
            // 
            this.button_Hotel_Delete.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hotel_Delete.Location = new System.Drawing.Point(563, 437);
            this.button_Hotel_Delete.Name = "button_Hotel_Delete";
            this.button_Hotel_Delete.Size = new System.Drawing.Size(98, 35);
            this.button_Hotel_Delete.TabIndex = 23;
            this.button_Hotel_Delete.Text = "Delete";
            this.button_Hotel_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Hotel_Add
            // 
            this.button_Hotel_Add.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hotel_Add.Location = new System.Drawing.Point(429, 437);
            this.button_Hotel_Add.Name = "button_Hotel_Add";
            this.button_Hotel_Add.Size = new System.Drawing.Size(98, 35);
            this.button_Hotel_Add.TabIndex = 22;
            this.button_Hotel_Add.Text = "Add";
            this.button_Hotel_Add.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(427, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hotel";
            // 
            // label__Error_hotel_label
            // 
            this.label__Error_hotel_label.AutoSize = true;
            this.label__Error_hotel_label.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label__Error_hotel_label.ForeColor = System.Drawing.Color.Red;
            this.label__Error_hotel_label.Location = new System.Drawing.Point(589, 64);
            this.label__Error_hotel_label.Name = "label__Error_hotel_label";
            this.label__Error_hotel_label.Size = new System.Drawing.Size(68, 16);
            this.label__Error_hotel_label.TabIndex = 20;
            this.label__Error_hotel_label.Text = "Fill all fields";
            // 
            // label_Error_Hotel_listView
            // 
            this.label_Error_Hotel_listView.AutoSize = true;
            this.label_Error_Hotel_listView.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Error_Hotel_listView.ForeColor = System.Drawing.Color.Red;
            this.label_Error_Hotel_listView.Location = new System.Drawing.Point(283, 24);
            this.label_Error_Hotel_listView.Name = "label_Error_Hotel_listView";
            this.label_Error_Hotel_listView.Size = new System.Drawing.Size(113, 16);
            this.label_Error_Hotel_listView.TabIndex = 17;
            this.label_Error_Hotel_listView.Text = "Select hotel to delete";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cuprum", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(26, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "HOTEL";
            // 
            // listView1_hotel
            // 
            this.listView1_hotel.CheckBoxes = true;
            this.listView1_hotel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hotel1,
            this.city_country1});
            this.listView1_hotel.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1_hotel.FullRowSelect = true;
            this.listView1_hotel.GridLines = true;
            this.listView1_hotel.Location = new System.Drawing.Point(9, 56);
            this.listView1_hotel.Name = "listView1_hotel";
            this.listView1_hotel.Size = new System.Drawing.Size(410, 416);
            this.listView1_hotel.TabIndex = 24;
            this.listView1_hotel.UseCompatibleStateImageBehavior = false;
            this.listView1_hotel.View = System.Windows.Forms.View.Details;
            // 
            // hotel1
            // 
            this.hotel1.Text = "Hotel";
            this.hotel1.Width = 204;
            // 
            // city_country1
            // 
            this.city_country1.Text = "City:Country";
            this.city_country1.Width = 201;
            // 
            // textBox1_Hotel
            // 
            this.textBox1_Hotel.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Hotel.Location = new System.Drawing.Point(431, 91);
            this.textBox1_Hotel.Name = "textBox1_Hotel";
            this.textBox1_Hotel.Size = new System.Drawing.Size(230, 22);
            this.textBox1_Hotel.TabIndex = 25;
            // 
            // textBox1_star
            // 
            this.textBox1_star.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_star.Location = new System.Drawing.Point(431, 153);
            this.textBox1_star.Name = "textBox1_star";
            this.textBox1_star.Size = new System.Drawing.Size(100, 22);
            this.textBox1_star.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(428, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stars";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(556, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Price";
            // 
            // textBox2_cost
            // 
            this.textBox2_cost.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_cost.Location = new System.Drawing.Point(559, 153);
            this.textBox2_cost.Name = "textBox2_cost";
            this.textBox2_cost.Size = new System.Drawing.Size(100, 22);
            this.textBox2_cost.TabIndex = 29;
            // 
            // comboBox1_HotelCityCountry
            // 
            this.comboBox1_HotelCityCountry.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1_HotelCityCountry.FormattingEnabled = true;
            this.comboBox1_HotelCityCountry.Location = new System.Drawing.Point(431, 216);
            this.comboBox1_HotelCityCountry.Name = "comboBox1_HotelCityCountry";
            this.comboBox1_HotelCityCountry.Size = new System.Drawing.Size(228, 24);
            this.comboBox1_HotelCityCountry.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(428, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "City";
            // 
            // textBox1_Description
            // 
            this.textBox1_Description.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Description.Location = new System.Drawing.Point(431, 275);
            this.textBox1_Description.Multiline = true;
            this.textBox1_Description.Name = "textBox1_Description";
            this.textBox1_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_Description.Size = new System.Drawing.Size(228, 121);
            this.textBox1_Description.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cuprum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(428, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.panel_city);
            this.Controls.Add(this.panel_hotel);
            this.Controls.Add(this.button_hotel);
            this.Controls.Add(this.button_city);
            this.Controls.Add(this.button_country);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_country);
            this.Name = "Form1";
            this.Text = "Travel Agency";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_country.ResumeLayout(false);
            this.panel_country.PerformLayout();
            this.panel_city.ResumeLayout(false);
            this.panel_city.PerformLayout();
            this.panel_hotel.ResumeLayout(false);
            this.panel_hotel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ListView listView1_Hotels;
        private System.Windows.Forms.ColumnHeader Hotel;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stars;
        private System.Windows.Forms.Label label_error_home_button_city;
        private System.Windows.Forms.Button button_main_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_home_city;
        private System.Windows.Forms.Label label_error_home_button_country;
        private System.Windows.Forms.Button button_main_country;
        private System.Windows.Forms.ComboBox comboBox1_home_country;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Button button_country;
        private System.Windows.Forms.Button button_city;
        private System.Windows.Forms.Button button_hotel;
        private System.Windows.Forms.Panel panel_country;
        private System.Windows.Forms.TextBox textBox1_Country;
        private System.Windows.Forms.Label label7_Error_Country_listView;
        private System.Windows.Forms.ListView listView1_Country;
        private System.Windows.Forms.ColumnHeader Country1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Country_Delete;
        private System.Windows.Forms.Label label__Error_Country_textBox;
        private System.Windows.Forms.Button button_Country_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_city;
        private System.Windows.Forms.ListView listView1_City;
        private System.Windows.Forms.ColumnHeader City1;
        private System.Windows.Forms.ColumnHeader Country2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1_City_City;
        private System.Windows.Forms.TextBox textBox1_City;
        private System.Windows.Forms.Label label_Error_City_listView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Error_City_textBox;
        private System.Windows.Forms.Button button_City_Delete;
        private System.Windows.Forms.Button button_City_Add_City;
        private System.Windows.Forms.Panel panel_hotel;
        private System.Windows.Forms.TextBox textBox2_cost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1_star;
        private System.Windows.Forms.TextBox textBox1_Hotel;
        private System.Windows.Forms.ListView listView1_hotel;
        private System.Windows.Forms.ColumnHeader hotel1;
        private System.Windows.Forms.ColumnHeader city_country1;
        private System.Windows.Forms.Button button_Hotel_Delete;
        private System.Windows.Forms.Button button_Hotel_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label__Error_hotel_label;
        private System.Windows.Forms.Label label_Error_Hotel_listView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1_Description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1_HotelCityCountry;
    }
}

