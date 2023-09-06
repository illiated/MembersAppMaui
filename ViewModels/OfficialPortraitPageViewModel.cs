using MembersApp.Models;

namespace MembersApp.ViewModels
{
    public class OfficialPortraitPageViewModel : BindableObject
    {
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
    }
}
