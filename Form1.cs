using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        string result = null;
        string city = null;
        WebResponse response = null;
        StreamReader reader = null;
        string iconUrl = null;
        string appid = "6306a2e7be850774238c11925d0cb7aa";
        string url;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Weather";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {
            city = cityid.Text;
            if(city != null)
                url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid="+appid+"&units=metric";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            response = request.GetResponse();
            reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            result = reader.ReadToEnd();
            dynamic weatherData = JsonConvert.DeserializeObject(result);
            temp.Text = weatherData.main.temp;
            weather.Text = weatherData.weather[0].description;
            iconUrl = "http://openweathermap.org/img/w/"+ weatherData.weather[0].icon+".png";
            icon.Load(iconUrl);
        }
    }
}
