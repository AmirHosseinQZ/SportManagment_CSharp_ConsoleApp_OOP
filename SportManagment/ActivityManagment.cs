using System;
using System.Collections.Generic;

namespace SportManagment
{
    internal class ActivityManagment : IMyActivity
    {
        public static List<Activity> activities = new List<Activity>();

        // اضافه کردن فعالیت به اعضا
        public bool AddPlan(string activityId, string memberId)
        {
            
            try
            {
                string pId = null;
                foreach (var i in activities)
                {
                    if (i.activityId == activityId)
                    {
                        pId = i.activityId;
                    }
                }
                foreach (var i in MembersManagment.members)
                {
                    if(i.memberId == memberId)
                    {
                        i.memberPlans.Add(pId);
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

        // تابعی که یک فعالیت را از یاشگاه حذف میکند
        public bool DeleteActivity(string activityId)
        {
            try
            {
                foreach (var item in activities)
                {
                    if (item.activityId == activityId)
                    {
                        activities.Remove(item);
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

        // تابعی که لیست همه فعالیت های باشگاه را نمایش میدهد
        public void GetActivityList()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var i in activities)
            {
                Console.Write($"ID : {i.activityId}\nName : {i.activityName}\nAge : {i.activityDescription}\n************************************\n");
            }
            Console.ResetColor();
        }

        //تایع افزودن فعالیت جدید به باشگاه
        public bool InsertActivity(string activityId, string activityName, string activityDescription)
        {
            Activity a = new Activity();
            try
            {
                a.activityId = activityId;
                a.activityName = activityName;
                a.activityDescription = activityDescription;
                activities.Add(a);
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
