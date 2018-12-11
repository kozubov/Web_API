using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.ModelJson;
using Newtonsoft.Json;

namespace Exam
{
    public partial class Form1 : Form
    {
        private string responseJson;
        private string flag;
        private List<Country> countries = new List<Country>();
        private List<City> cities = new List<City>();
        private List<Hotels> hotelses = new List<Hotels>();
        private List<CityandCountries> cityandCountrieses = new List<CityandCountries>();
        private List<Hotels_2> hotels2S = new List<Hotels_2>();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            this.button_hotel.Click += Button_hotel_Click;
            this.button_country.Click += Button_country_Click;
            this.button_city.Click += Button_city_Click;
            this.button_main.Click += Button_main_Click;
            this.button_main_country.Click += Button_main_country_Click;
            this.button_main_city.Click += Button_main_city_Click;
            this.button_Country_Add.Click += Button_Country_Add_Click;
            this.textBox1_Country.TextChanged += TextBox1_Country_TextChanged;
            this.button_Country_Delete.Click += Button_Country_Delete_Click;
            this.button_City_Add_City.Click += Button_City_Add_City_Click;
            this.textBox1_City.TextChanged += TextBox1_City_TextChanged;
            this.button_City_Delete.Click += Button_City_Delete_Click;
            this.button_Hotel_Add.Click += Button_Hotel_Add_Click;

            this.textBox1_Hotel.TextChanged += TextBox1_Hotel_TextChanged;
            this.textBox1_Description.TextChanged += TextBox1_Hotel_TextChanged;
            this.textBox1_star.TextChanged += TextBox1_Hotel_TextChanged;
            this.textBox2_cost.TextChanged += TextBox1_Hotel_TextChanged;
            this.button_Hotel_Delete.Click += Button_Hotel_Delete_Click;
        }

        private async void Button_Hotel_Delete_Click(object sender, EventArgs e)
        {
            this.label_Error_Hotel_listView.Visible = false;
            int count = 0;
            foreach (ListViewItem VARIABLE in this.listView1_hotel.Items)
            {
                if (VARIABLE.Checked)
                {
                    count++;
                    var hotel = hotels2S.Find(z => z.hotelName == VARIABLE.Text);
                    string data = $"token=ps_rpo_2&param=deleteHotel&hotel={hotel.id}";
                    await LoadComboboxCountriHome(data);
                }
            }

            if (count == 0)
            {
                this.label_Error_Hotel_listView.Visible = true;
                return;
            }

            if (responseJson == "200")
            {
                Show_Information_Hotel();
            }
        }

        private void TextBox1_Hotel_TextChanged(object sender, EventArgs e)
        {
            label__Error_hotel_label.Visible = false;
        }

        private async void Button_Hotel_Add_Click(object sender, EventArgs e)
        {
            if (textBox1_Hotel.Text == "" || textBox1_Description.Text == "" || textBox1_star.Text == "" ||
                textBox2_cost.Text == "")
            {
                label__Error_hotel_label.Text = "Fill all fields";
                label__Error_hotel_label.Visible = true;
                return;
            }
            try
            {
                int star = Convert.ToInt32(textBox1_star.Text);
                int cost = Convert.ToInt32(textBox2_cost.Text);
            }
            catch (Exception exception)
            {
                label__Error_hotel_label.Text = "Wrong input";
                label__Error_hotel_label.Visible = true;
                return;
            }

            string[] cit_coun = comboBox1_HotelCityCountry.SelectedItem.ToString().Split(':');
            var city = cityandCountrieses.Find(z => z.cityName == cit_coun[0]);
            string data =
                $"token=ps_rpo_2&param=addHotel&hotal={textBox1_Hotel.Text}&city={city.id}&country={city.countryId}&star={Convert.ToInt32(textBox1_star.Text)}&cost={Convert.ToInt32(textBox2_cost.Text)}&info={textBox1_Description.Text}";
            await LoadComboboxCountriHome(data);
            if (responseJson == "200")
            {
                textBox1_Hotel.Text = "";
                textBox1_star.Text = "";
                textBox2_cost.Text = "";
                textBox1_Description.Text = "";
                Show_Information_Hotel();
            }
        }

        private async void Button_City_Delete_Click(object sender, EventArgs e)
        {
            this.label_Error_City_listView.Visible = false;
            int count = 0;
            foreach (ListViewItem VARIABLE in this.listView1_City.Items)
            {
                if (VARIABLE.Checked)
                {
                    count++;
                    var city = cityandCountrieses.Find(z => z.cityName == VARIABLE.Text);
                    string data = $"token=ps_rpo_2&param=deleteCity&city={city.id}";
                    await LoadComboboxCountriHome(data);
                }
            }

            if (count == 0)
            {
                this.label_Error_City_listView.Visible = true;
                return;
            }

            if (responseJson == "200")
            {
                Show_Global_City();
            }
        }

        private void TextBox1_City_TextChanged(object sender, EventArgs e)
        {
            this.label_Error_City_textBox.Visible = false;
        }

        private async void Button_City_Add_City_Click(object sender, EventArgs e)
        {
            if (textBox1_City.Text == "")
            {
                this.label_Error_City_textBox.Visible = true;
                return;
            }
            string strCountry = comboBox1_City_City.SelectedItem.ToString();
            var idCity = countries.Find(z => z.countryName == strCountry);
            string data = $"token=ps_rpo_2&param=addCity&city={textBox1_City.Text}&country={idCity.id}";
            await LoadComboboxCountriHome(data);
            if (responseJson == "200")
            {
                Show_Global_City();
            }
        }

        private async void Button_Country_Delete_Click(object sender, EventArgs e)
        {
            this.label7_Error_Country_listView.Visible = false;
            int count = 0;
            foreach (ListViewItem VARIABLE in listView1_Country.Items)
            {
                if (VARIABLE.Checked)
                {
                    count++;
                    var country = countries.Find(z => z.countryName == VARIABLE.Text);
                    string data = $"token=ps_rpo_2&param=deleteCountry&country={country.id}";
                    await LoadComboboxCountriHome(data);
                }
            }

            if (count == 0)
            {
                this.label7_Error_Country_listView.Visible = true;
                return;
            }
            Insert_Country();
        }

        private void TextBox1_Country_TextChanged(object sender, EventArgs e)
        {
            this.label__Error_Country_textBox.Visible = false;
        }

        private  async void Button_Country_Add_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Country.Text == "")
            {
                this.label__Error_Country_textBox.Visible = true;
                return;
            }
            // данные для отправки
            string data = $"token=ps_rpo_2&param=insertCountry&country={textBox1_Country.Text}";
            await LoadComboboxCountriHome(data);
            Insert_Country();
        }

        private void Insert_Country()
        {
            if (responseJson == "200")
            {
                listView1_Country.Items.Clear();
                Buuton_Country();
            }
        }

        private async void Button_main_city_Click(object sender, EventArgs e)
        {
            this.label_error_home_button_city.Visible = false;
            if (this.comboBox1_home_city.SelectedItem.ToString() == "")
            {
                this.label_error_home_button_city.Visible = true;
                return;
            }
            listView1_Hotels.Items.Clear();
            string strCity = comboBox1_home_city.SelectedItem.ToString();
            var idCity = cities.Find(z => z.cityName == strCity);
            this.label_error_home_button_country.Visible = false;
            string data = $"token=ps_rpo_2&param=getHotels&country={idCity.countryId}&city={idCity.id}";
            await LoadComboboxCountriHome(data);
            Show_Hotels();
        }

        private void Show_Hotels()
        {
            hotelses = JsonConvert.DeserializeObject<List<Hotels>>(responseJson);
            string[] row = new string[5];
            ListViewItem item;
            listView1_Hotels.Visible = true;
            foreach (var VARIABLE in hotelses)
            {
                row[0] = VARIABLE.hotelName;
                row[1] = VARIABLE.cityName;
                row[2] = VARIABLE.countryName;
                row[3] = VARIABLE.cost.ToString();
                row[4] = VARIABLE.stars.ToString();
                item = new ListViewItem(row);
                listView1_Hotels.Items.Add(item);
            }
        }

        private async void Button_main_country_Click(object sender, EventArgs e)
        {
            this.label_error_home_button_city.Visible = false;
            this.label_error_home_button_country.Visible = false;
            this.comboBox1_home_city.SelectedValue = "";
            this.comboBox1_home_city.Items.Clear();
            if (comboBox1_home_country.SelectedItem == null)
            {
                this.label_error_home_button_country.Visible = true;
                return;
            }
            string str = comboBox1_home_country.SelectedItem.ToString();
            var idCountry = countries.Find(z => z.countryName == str);
            this.label_error_home_button_country.Visible = false;
            // данные для отправки
            string data = $"token=ps_rpo_2&param=getCitys&country={idCountry.id}";
            await LoadComboboxCountriHome(data);
            Show_Cityes();
        }

        private void Show_Cityes()
        {
            cities = JsonConvert.DeserializeObject<List<City>>(responseJson);
            this.comboBox1_home_city.Visible = true;
            this.button_main_city.Visible = true;
            foreach (City VARIABLE in cities)
            {
                comboBox1_home_city.Items.Add(VARIABLE.cityName);
            }

            if (cities.Count != 0)
            {
                comboBox1_home_city.SelectedIndex = 0;
            }
            else
            {
                comboBox1_home_city.Items.Add("");
                comboBox1_home_city.SelectedIndex = 0;
            }
        }

        private void Button_main_Click(object sender, EventArgs e)
        {
            this.comboBox1_home_city.Items.Clear();
            this.listView1_Hotels.Items.Clear();
            this.comboBox1_home_country.Items.Clear();
            panel_country.Visible = false;
            this.panel_city.Visible = false;
            this.panel_hotel.Visible = false;
            panel_main.Visible = true;

            Start_Program();
        }

        private void Button_city_Click(object sender, EventArgs e)
        {
            Show_Global_City();
        }

        private async void Show_Global_City()
        {
            this.panel_main.Visible = false;
            this.panel_country.Visible = false;
            this.panel_hotel.Visible = false;
            this.label_Error_City_textBox.Visible = false;
            this.label_Error_City_listView.Visible = false;
            this.panel_city.Visible = true;
            textBox1_City.Text = "";
            string data = "token=ps_rpo_2&param=getCountries";
            await LoadComboboxCountriHome(data);
            Show_Combobx_Country_to_City();
            string data2 = "token=ps_rpo_2&param=CityandCountries";
            await LoadComboboxCountriHome(data2);
            Shov_List_View_City();
        }

        private void Show_Combobx_Country_to_City()
        {
            countries = JsonConvert.DeserializeObject<List<Country>>(responseJson);
            foreach (Country VARIABLE in countries)
            {
                comboBox1_City_City.Items.Add(VARIABLE.countryName);
            }

            if (countries.Count != 0)
            {
                comboBox1_City_City.SelectedIndex = 0;
            }
            else
            {
                comboBox1_City_City.Items.Add("");
                comboBox1_City_City.SelectedIndex = 0;
            }
        }

        private void Shov_List_View_City()
        {
            cityandCountrieses = JsonConvert.DeserializeObject<List<CityandCountries>>(responseJson);
            listView1_City.Items.Clear();
            string[] masCity = new string[2];
            ListViewItem item;
            foreach (CityandCountries VARIABLE in cityandCountrieses)
            {
                masCity[0] = VARIABLE.cityName;
                masCity[1] = VARIABLE.countryName;
                item = new ListViewItem(masCity);
                listView1_City.Items.Add(item);
            }
        }
        private void Button_country_Click(object sender, EventArgs e)
        {
            panel_main.Visible = false;
            this.panel_city.Visible = false;
            this.panel_hotel.Visible = false;
            label__Error_Country_textBox.Visible = false;
            label7_Error_Country_listView.Visible = false;
            panel_country.Visible = true;
            listView1_Country.Items.Clear();
            Buuton_Country();
        }

        private void Button_hotel_Click(object sender, EventArgs e)
        {
            panel_country.Visible = false;
            this.panel_city.Visible = false;
            panel_main.Visible = false;
            this.label_Error_Hotel_listView.Visible = false;
            this.label__Error_hotel_label.Visible = false;
            this.panel_hotel.Visible = true;
            Show_Information_Hotel();
        }

        private async void Buuton_Country()
        {
            textBox1_Country.Text = "";
            string data = "token=ps_rpo_2&param=getCountries";
            await LoadComboboxCountriHome(data);
            countries = JsonConvert.DeserializeObject<List<Country>>(responseJson);
            string[] masCountris = new string[1];
            ListViewItem item;
            foreach (Country VARIABLE in countries)
            {
                masCountris[0] = VARIABLE.countryName;
                item = new ListViewItem(masCountris);
                listView1_Country.Items.Add(item);
            }
        }
        private async void Show_Information_Hotel()
        {
            string data = $"token=ps_rpo_2&param=hotels";
            await LoadComboboxCountriHome(data);
            Insert_ListView_Hotels_2();
            string data2 = "token=ps_rpo_2&param=CityandCountries";
            await LoadComboboxCountriHome(data2);
            Show_Ciry_Country_inHotels();
        }

        private async Task LoadComboboxCountriHome(string param)
        {
            WebRequest request = WebRequest.Create("http://travelagancy/apiExem/api.php");
            request.Method = "POST"; // для отправки используется метод Post

            // преобразуем данные в массив байтов
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(param);
            // устанавливаем тип содержимого - параметр ContentType
            request.ContentType = "application/x-www-form-urlencoded";
            // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseJson = reader.ReadToEnd();
                }
            }
            response.Close();
        }

        private void Insert_ListView_Hotels_2()
        {
            hotels2S = JsonConvert.DeserializeObject<List<Hotels_2>>(responseJson);
            this.listView1_hotel.Items.Clear();
            string[] columHotels = new string[2];
            ListViewItem item;
            foreach (Hotels_2 VARIABLE in hotels2S)
            {
                columHotels[0] = VARIABLE.hotelName;
                columHotels[1] = VARIABLE.cityName + " : " + VARIABLE.countryName;
                item = new ListViewItem(columHotels);
                this.listView1_hotel.Items.Add(item);
            }
        }
        private void Show_Ciry_Country_inHotels()
        {
            cityandCountrieses = JsonConvert.DeserializeObject<List<CityandCountries>>(responseJson);
            foreach (CityandCountries VARIABLE in cityandCountrieses)
            {
                comboBox1_HotelCityCountry.Items.Add(VARIABLE.cityName + ":" + VARIABLE.countryName);
            }

            if (countries.Count != 0)
            {
                comboBox1_HotelCityCountry.SelectedIndex = 0;
            }
            else
            {
                comboBox1_HotelCityCountry.Items.Add("");
                comboBox1_HotelCityCountry.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_country.Visible = false;
            this.panel_city.Visible = false;
            this.panel_hotel.Visible = false;
            panel_main.Visible = true;
            Start_Program();
        }
        private async void Start_Program()
        {
            this.comboBox1_home_city.Visible = false;
            this.button_main_city.Visible = false;
            this.label_error_home_button_city.Visible = false;
            this.label_error_home_button_country.Visible = false;
            this.listView1_Hotels.Visible = false;
            string data = "token=ps_rpo_2&param=getCountries";
            await LoadComboboxCountriHome(data);
            Add_Combobox_Cantri_Home();
        }

        private void Add_Combobox_Cantri_Home()
        {
            countries = JsonConvert.DeserializeObject<List<Country>>(responseJson);
            foreach (Country VARIABLE in countries)
            {
                comboBox1_home_country.Items.Add(VARIABLE.countryName);
            }

            if (countries.Count != 0)
            {
                comboBox1_home_country.SelectedIndex = 0;
            }
            else
            {
                comboBox1_home_country.Items.Add("");
                comboBox1_home_country.SelectedIndex = 0;
            }
        }
    }
}
