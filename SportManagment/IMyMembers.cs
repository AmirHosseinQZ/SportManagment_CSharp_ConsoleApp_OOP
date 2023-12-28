using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportManagment
{
    internal interface IMyMembers
    {
        bool  InsertMember(string memberId ,string  memberName,int memberAge , List<string> memberPlans);
        bool  DeleteMember(string memberId);
        void GetMembersList();
    }
}
