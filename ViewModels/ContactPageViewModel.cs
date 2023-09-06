using MembersApp.Models;

namespace MembersApp.ViewModels
{
    public class ContactPageViewModel : BindableObject
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
