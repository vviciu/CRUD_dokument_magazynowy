using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumentMagazynowy.View
{
    public partial class Form_repozytoriumProjektowe : Form
    {
        public Form_repozytoriumProjektowe()
        {
            InitializeComponent();
            ZaladujDaneNaFormularz();
        }

        private void ZaladujDaneNaFormularz()
        {
            ExecuteAsync();
        }


        public void ExecuteAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com");
            var token = "6264bcc9f0488232a6661851dd97ceb56a3786f5";

            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("DokumentMagazynowy", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", token);

            var response = client.GetAsync("/repos/vviciu/CRUD_dokument_magazynowy").Result;

            if (response.IsSuccessStatusCode)
            {
                string rezultat = response.Content.ReadAsStringAsync().Result;

                JObject rss = JObject.Parse(rezultat);

                string uzytkownik = (string)rss["owner"]["login"];
                string pelnaNazwa = (string)rss["full_name"];
                string dataUtworzenia = (string)rss["created_at"];
                //MessageBox.Show($@"{uzytkownik} {pelnaNazwa} {dataUtworzenia}");


                richTextBox_infoRepozytorium.AppendText($"\r\n Użytkownik: {uzytkownik}");
                richTextBox_infoRepozytorium.AppendText($"\r\n Nazwa repo: {pelnaNazwa}");
                richTextBox_infoRepozytorium.AppendText($"\r\n Data utworzenia: {dataUtworzenia}");

            }
            else
            {
                richTextBox_infoRepozytorium.Text = "Nie można pobrać danych o repozytorium : " + response.StatusCode.ToString();
            }
        }

        private void Button_zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
