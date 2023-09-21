using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    internal class Magazine : OutputManager
    {
        private string _title;
        private string _year;
        private string _description;
        private string _phone;
        private string _email;
        public string Title
        {
            get => _title;
            set
            {
                CheckInput(nameof(Title), value);
                _title = value;
            }
        }
        public string Year
        {
            get => _year;
            set
            {
                CheckInput(nameof(Year), value);
                _year = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                CheckInput(nameof(Description), value);
                _description = value;
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                CheckInput(nameof(Phone), value);
                _phone = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                CheckInput(nameof(Email), value);
                _email = value;
            }
        }
        public override string ToString()
        {
            var input = new StringBuilder();
            input.AppendLine($"Title: {_title}");
            input.AppendLine($"Year of foundation: {_year}");
            input.AppendLine($"Description: {_description}");
            input.AppendLine($"Phone number: {_phone}");
            input.AppendLine($"Email adress: {_email}");
            return input.ToString();
        }
    }
}
