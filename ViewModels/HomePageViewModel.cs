using MembersApp.Models;
using MembersApp.Views;
using System.Collections.ObjectModel;

namespace MembersApp.ViewModels
{
    public class HomePageViewModel : BindableObject
    {
        public Command MemberSelectedCommand { get; set; }

        public ObservableCollection<Member> Members { get; set; } = new ObservableCollection<Member>();

        private Member selectedMember;

        public Member SelectedMember
        {
            get => selectedMember;
            set
            {
                selectedMember = value;
                OnPropertyChanged(nameof(SelectedMember));
            }
        }

        public HomePageViewModel()
        {
            LoadMembers();

            MemberSelectedCommand = new Command(OnMemberSelected);
        }

        private void LoadMembers()
        {
            Members.Add(new Member
            {
                Constituency = "Hackney North and Stoke Newington",
                Id = 172,
                NameAddressAs = "Ms Abbot",
                NameDisplayAs = "Ms Diane Abbott",
                PartyColour = Color.FromHex("#ff0000"),
                PartyName = "Labour",
                TeaserText = "The Rt Hon Ms Diane Abbott is the Labour MP for Hackney North and Stoke Newington, and has been an MP continuously since 11 June 1987.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/172/Thumbnail"
            });

            Members.Add(new Member
            {
                Constituency = "Oldham East and Saddleworth",
                Id = 4212,
                NameAddressAs = "Debbie Abrahams",
                NameDisplayAs = "Debbie Abrahams",
                PartyColour = Color.FromHex("#ff0000"),
                PartyName = "Labour",
                TeaserText = "Debbie Abrahams is the Labour MP for Oldham East and Saddleworth, and has been an MP continuously since 13 January 2011.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/4212/Thumbnail"
            });

            Members.Add(new Member
            {
                Constituency = "Selby and Ainsty",
                Id = 4057,
                NameAddressAs = "Nigel Adams",
                NameDisplayAs = "Nigel Adams",
                PartyColour = Color.FromHex("#0000ff"),
                PartyName = "Conservative",
                TeaserText = "The Rt Hon Nigel Adams is the Conservative MP for Selby and Ainsty, and has been an MP continuously since 6 May 2010.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/4057/Thumbnail"
            });

            Members.Add(new Member
            {
                Constituency = "Hitchin and Harpenden",
                Id = 4639,
                NameAddressAs = "Bim Afolami",
                NameDisplayAs = "Bim Afolami",
                PartyColour = Color.FromHex("#0000ff"),
                PartyName = "Conservative",
                TeaserText = "Bim Afolami is the Conservative MP for Hitchin and Harpenden, and has been an MP continuously since 8 June 2017.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/4639/Thumbnail"
            });

            Members.Add(new Member
            {
                Constituency = "Windsor",
                Id = 1586,
                NameAddressAs = "Adam Afriyie",
                NameDisplayAs = "Adam Afriyie",
                PartyColour = Color.FromHex("#0000ff"),
                PartyName = "Conservative",
                TeaserText = "Adam Afriyie is the Conservative MP for Windsor, and has been an MP continuously since 5 May 2005.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/1586/Thumbnail"
            });

            Members.Add(new Member
            {
                Constituency = "Cities of London and Westminster",
                Id = 4741,
                NameAddressAs = "Nickie Aiken",
                NameDisplayAs = "Nickie Aiken",
                PartyColour = Color.FromHex("#0000ff"),
                PartyName = "Conservative",
                TeaserText = "Nickie Aiken is the Conservative MP for Cities of London and Westminster, and has been an MP continuously since 12 December 2019.",
                ThumbnailUrl = "https://members-api.parliament.uk/api/Members/4741/Thumbnail"
            });
        }

        private void OnMemberSelected()
        {
            var detailPage = new DetailPage();
            var viewModel = new DetailPageViewModel();
            viewModel.Member = SelectedMember;
            detailPage.BindingContext = viewModel;
            App.Current.MainPage.Navigation.PushAsync(detailPage);
        }
    }
}
