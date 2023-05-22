using System.ComponentModel.DataAnnotations;

namespace TAH1.Models
{
    public class personaldetailViewModel
    {
        private string? _fullname;
        private string? _birthday;
        private string? _email;
        private int _phone;
        private int _mobile;

        [Required(ErrorMessage = "Full Name is required")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value ?? string.Empty; }
        }

        [Required(ErrorMessage = "Birthday is required")]
        public string birthday
        {
            get { return _birthday; }
            set { _birthday = value ?? string.Empty; }
        }

        [Required(ErrorMessage = "Email is required")]
        public string email
        {
            get { return _email; }
            set { _email = value ?? string.Empty; }
        }

        [Required(ErrorMessage = "Phone is required")]
        public int phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [Required(ErrorMessage = "Mobile is required")]
        public int mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
    }
}
