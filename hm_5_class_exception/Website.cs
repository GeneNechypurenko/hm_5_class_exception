using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    internal class Website : OutputManager
    {
        private string _title;
        private string _url;
        private string _description;
        private string _ipAdress;
        public string Title
        {
            get => _title;
            set
            {
                CheckInput(nameof(Title), value);
                _title = value;
            }
        }
        public string Url
        {
            get => _url;
            set
            {
                CheckInput(nameof(Url), value);
                _url = value;
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
        public string IpAdress
        {
            get => _ipAdress;
            set
            {
                CheckInput(nameof(IpAdress), value);
                _ipAdress = value;
            }
        }
        public override string ToString()
        {
            var input = new StringBuilder();
            input.AppendLine($"Title: {_title}");
            input.AppendLine($"URL: {_url}");
            input.AppendLine($"Description: {_description}");
            input.AppendLine($"IP Address: {_ipAdress}");
            return input.ToString();
        }
    }
}
