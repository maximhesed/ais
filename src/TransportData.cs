using System.Windows.Forms;

namespace ais
{
    public class TransportData
    {
        public struct ContractorData
        {
            public TextBox firstName;
            public TextBox lastName;
            public TextBox patronymic;
            public TextBox email;
            public TextBox phone;
            public TextBox price;
        }

        public struct EmployeeData
        {
            public TextBox firstName;
            public TextBox lastName;
            public TextBox patronymic;
            public TextBox email;
            public TextBox passw;
            public TextBox passwRepeat;
            public TextBox phone;
        }

        public struct LeadData
        {
            public TextBox firstName;
            public TextBox lastName;
            public TextBox patronymic;
            public TextBox email;
            public TextBox phone;
            public TextBox promTime;
        }

        public struct ListMenu
        {
            public string lstName;
            public string[] items;
        }

        public struct OrdReqData
        {
            public TextBox prodName;
            public TextBox prodQuantity;
        }
    }
}

