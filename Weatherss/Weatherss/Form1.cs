using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Weatherss
{
    public partial class Form1 : Form
    {
        const string APPID = "585b2ee17dabee43a31f5d5e510baa4d";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();
           // getWeather("1566083");
            //geForast("1566083");

        }
        //void getWeather(string city)
        //{
        //    using (WebClient web = new WebClient())
        //    {
        //        string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}", city,APPID);

        //        var json = web.DownloadString(url);

        //        var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
        //        WeatherInfo.root outPut = result;

        //        lbl_textCity.Text = string.Format("{0}", outPut.name);
        //        lbl_textCountry.Text = string.Format("{0}", outPut.sys.country);
        //        lbl_DoCe.Text = string.Format("{0} \u00B0", outPut.main.temp)+ "*c";
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //void geForast(string city)
        //{
        //    string url = "";
        //    using (WebClient web = new WebClient())
        //    {
        //        var json = web.DownloadString(url);
        //        var Object = JsonConvert.DeserializeObject<WeatherForcasts>(json);
        //        WeatherForcasts forcasts = Object;
        //        lbl_Conditions.Text = string.Format("{0}", forcasts.list[1].weather[0].main);
        //        lbl_Description.Text = string.Format("{0}", forcasts.list[1].weather[0].descriptions);
        //        lbl_Des2.Text = string.Format("{0}  \u00B0", forcasts.list[1].temp);
        //        lbl_Speed.Text = string.Format("{0}  \u00B0", forcasts.list[1].speed);
        //    }

        //}

        private void label5_Click(object sender, EventArgs e)
        {
             
        }
    }
}
