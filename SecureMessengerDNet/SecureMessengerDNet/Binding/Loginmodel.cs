using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using Messages.NET.Utils;
using SecureMessengerDNet;
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SecureMessengerDNet
{
    class Loginmodel : INotifyPropertyChanged
    {

        private String _username;
        private String _password;

        public event PropertyChangedEventHandler PropertyChanged;



        public String Username
        {
            get => _username;
            set
            {

                if (_username != value)
                {
                    _username = value;
                    this.NotifyPropertyChanged("Username");
                }
            }
        }
        public String Password
        {
            get => _password;
            set
            {

                if (_password != value)
                {
                    _password = value;
                    this.NotifyPropertyChanged("Password");
                }
            }
        }

        public Loginmodel()
        {

            ConnexionCommand = new AppCommands(Connexion);
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public bool NotifyPropertyChanged<T>(ref T variable, T valeur, string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
            return true;
        }

        public ICommand ConnexionCommand { get; set; }

        private void Connexion()
        {
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("username", "admin");
            jsonValues.Add("password", "password");
          
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://baobab.tokidev.fr/api/login");
            client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://baobab.tokidev.fr/api/login");
            request.Content = new StringContent(JsonConvert.SerializeObject(jsonValues),
                                                Encoding.UTF8,
                                                "application/json");

            client.SendAsync(request)
                  .ContinueWith(responseTask =>
                  {
                  //responseTask.Result.EnsureSuccessStatusCode();

                  Console.WriteLine("Response: {0}",JsonConvert.DeserializeObject<object>(responseTask.Result.Content.ReadAsStringAsync().Result));
                  });

        }



    }
}
