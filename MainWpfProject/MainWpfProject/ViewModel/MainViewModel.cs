using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MainWpfProject.Model;
using MainWpfProject.Navigation;

namespace MainWpfProject.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private FrameNavigationService _navigationService;

        public RelayCommand<Person> LoginCommand {get; private set;}

        private string _welcomeTitle = string.Empty;
        private string _loginMessage = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        public string loginMessage
        {
            get
            {
                return _loginMessage;
            }
            set
            {
                Set(ref _loginMessage, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService, IFrameNavigationService navigationService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
            LoginCommand = new RelayCommand<Person>(VerifyLoginAndLogin);
        }

        private void VerifyLoginAndLogin(Person obj)
        {
            loginMessage = "Login Atempt";
            _navigationService = FrameNavigationService.navigationInstance;
            _navigationService.NavigateTo("Account");
            //throw new NotImplementedException();
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}