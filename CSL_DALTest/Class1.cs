using CSL_DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSL_DALTest
{
    [TestFixture]
    public class UserInfoTest
    {
        UserMethods methods = new UserMethods();
        [TestCase]
        public void ValidateUserTest()
        {
            UserInfo user = new UserInfo();
            user.UserId = 1;
            //user.Email = "salini@gmail.com";
            user.Password = "Shalu@123";
            bool ans = methods.ValidateUser(user);
            Assert.AreEqual(true, ans);
            Console.WriteLine("Successfully validated");

        }
    }
    [TestFixture]
    public class CustLogTest
    {
        CustLogMethods methods = new CustLogMethods();
        [Test]
        public void SaveCustLogInfoTest()
        {
            CustLogInfo cust = new CustLogInfo();
            cust.LogId = 1;
            cust.CustName = "Shravan";
            cust.CustEmail = "shrvan@gmail.com";
            cust.LogStatus = "Logging";
            cust.UserId = 1;
            cust.Description = "Loggin Error";

            bool ans = methods.SaveCustloginfotest(cust);
            Assert.AreEqual(true, ans);
        }
    }
}
