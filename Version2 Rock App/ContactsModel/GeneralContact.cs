using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App.ContactsModel
{
    class GeneralContact
    {
        private int _generaltelephonenumber;
        private string _webaddress;
        private string _complaintwebaddress;

        public int GeneralTelephoneNumber
        {
            get { return _generaltelephonenumber; }
            set { _generaltelephonenumber = value; }
        }

        public string WebAddress
        {
            get { return _webaddress; }
            set { _webaddress = value; }
        }

        public string ComplaintWebAddress
        {
            get { return _complaintwebaddress; }
            set { _complaintwebaddress = value; }
        }
    }
}
