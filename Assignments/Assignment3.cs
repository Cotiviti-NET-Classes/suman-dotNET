using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Branch
    {
        public Branch()
        {
            IsMain = false;
        }

        public Branch(string companyName)
        {
            CompanyName = companyName;
        }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Provience Provience { get; set; }
        public string PhoneNo1 { get; }

        public string PhoneNo2
        {
            set { PhoneNo2 = "9876543210"; }
        }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public bool IsMain { get; set; }
        public readonly bool Status = true;
    }


    public enum Provience
    {
        ProvienceOne = 1,
        MadheshProvince = 2,
        BagmatiProvience = 3,
        GandakiProvience = 4,
        LumbiniProvience = 5,
        KarnaliProvience = 6,
        SudurpashchimProvience = 7
    }
}