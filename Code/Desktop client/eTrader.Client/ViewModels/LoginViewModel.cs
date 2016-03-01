using eTrader.Windows;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Headers;

namespace eTrader.Client.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost:62702/api";


        public LoginViewModel()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string username;
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                NotifyPropertyChanged();
            }
        }

        private string password;
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Username);
            }
        }

        public ActionCommand LoginCommand
        {
            get
            {
                return new ActionCommand(t => Login(Username, Password), t => IsValid);
            }
        }

        private async void Login(string username, string password)
        {
            var login = new { UserName = "mantonijevic", Password = "Beograd2043" };

            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url + "/login/signin", login);
            if (responseMessage.IsSuccessStatusCode)
            {
                
            }
        }
    }
}
