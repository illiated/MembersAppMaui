using MembersApp.Models;
using MembersApp.Views;

namespace MembersApp.ViewModels
{
    public class DetailPageViewModel : BindableObject
    {
        public Command ContactInformationCommand { get; set; }

        public Command OfficialPortraitCommand { get; set; }

        public Command ParliamentaryCareerCommand { get; set; }

        private Member member;

        public Member Member
        {
            get => member;
            set
            {
                member = value;
                OnPropertyChanged(nameof(Member));
            }
        }

        public DetailPageViewModel()
        {
            ContactInformationCommand = new Command(OnContactInformationClicked);
            OfficialPortraitCommand = new Command(OnOfficialPortraitClicked);
            ParliamentaryCareerCommand = new Command(OnParliamentaryCareerClicked);
        }

        private void OnContactInformationClicked()
        {
            var contactPage = new ContactPage();
            var viewModel = new ContactPageViewModel();
            viewModel.Member = Member;
            contactPage.BindingContext = viewModel;
            App.Current.MainPage.Navigation.PushAsync(contactPage);
        }

        private void OnOfficialPortraitClicked()
        {
            var officialPortraitPage = new OfficialPortraitPage();
            var viewModel = new OfficialPortraitPageViewModel();
            viewModel.Member = Member;
            officialPortraitPage.BindingContext = viewModel;
            App.Current.MainPage.Navigation.PushAsync(officialPortraitPage);
        }

        private void OnParliamentaryCareerClicked()
        {
            var careerPage = new CareerPage();
            var viewModel = new CareerPageViewModel();
            viewModel.Member = Member;
            careerPage.BindingContext = viewModel;
            App.Current.MainPage.Navigation.PushAsync(careerPage);
        }
    }
}
