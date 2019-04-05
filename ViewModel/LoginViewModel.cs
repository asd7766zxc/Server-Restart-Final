using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Server_Restart_Final
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set; }

        public bool LoginIsRunning { get; set; }


        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () => { 
            await Task.Delay(5000);

            var email = this.Email;
        
            });
        }
    }
}