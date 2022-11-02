using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSL_DAL
{
    public class UserMethods
    {
        CSLDBEntities context = null;
        public UserMethods()
        {
            context = new CSLDBEntities();
        }
        public bool ValidateUser(UserInfo u)
        {
            List<UserInfo> list = context.UserInfoes.ToList();
            bool ans = false;

            UserInfo u1 = list.Find(x => x.UserId == u.UserId);
            if (u1 != null)
            {
                if (u1.Password == u.Password)
                {
                    ans = true;
                }
            }

            return ans;

        }

    }
    public class CustLogMethods
    {
        CSLDBEntities context = null;
        public CustLogMethods()
        {
            context = new CSLDBEntities();
        }
        public bool SaveCustloginfotest(CustLogInfo cust)
        {
            try
            {
                context.CustLogInfoes.Add(cust);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
