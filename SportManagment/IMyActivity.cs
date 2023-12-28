using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportManagment
{
    internal interface IMyActivity
    {
        bool InsertActivity(string activityId, string activityName, string activityDescription);
        bool DeleteActivity(string activityId);
        bool AddPlan(string activityId, string memberId);
        void GetActivityList();
    }
}
