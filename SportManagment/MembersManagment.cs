using System;
using System.Collections.Generic;

namespace SportManagment
{
    internal class MembersManagment : IMyMembers
    {
        public static List<Member> members = new List<Member>();

        // Delete Mamber
        public bool DeleteMember(string memberId)
        {
            try
            {
                foreach (var i in members)
                {
                    if (i.memberId == memberId)
                    {
                        members.Remove(i);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        // Get All Members
        public void GetMembersList()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var i in members)
            {
                string plans = "";
                for (int j = 0; j < i.memberPlans.Count; j++)
                {
                    plans += i.memberPlans[j] + ",";
                }
                Console.Write($"ID : {i.memberId}\nName : {i.memberName}\nAge : {i.memberAge}\nPlans : {plans}\n************************************\n");
            }
            Console.ResetColor();
        }

        // Add Member
        public bool InsertMember(string memberId, string memberName, int memberAge, List<string> memberPlans)
        {
            Member member = new Member();
            try
            {
                member.memberName = memberName;
                member.memberId = memberId;
                member.memberAge = memberAge;
                member.memberPlans = memberPlans;
                members.Add(member);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
