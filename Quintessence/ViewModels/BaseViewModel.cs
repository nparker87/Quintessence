namespace Quintessence.ViewModels
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            CurrentTab = "Home";
        }

        public BaseViewModel(string currentTab)
        {
            CurrentTab = currentTab;
        }

        public string CurrentTab { get; set; }
    }
}