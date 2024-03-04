using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using CassandraDataLayer.QueryEntities;

namespace CassandraDataLayer
{
    public class DataProvider
    {
        #region Admin

        public static bool AddAdmin(Admin admin)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Admin v = GetAdmin(admin.id);
            if (v.id != null)
                return false;

            String id = "'" + admin.id + "'";
            String password = "'" + admin.password + "'";
            String name = "'" + admin.name + "'";
            String surname = "'" + admin.surname + "'";
            String phonenumber = "'" + admin.phonenumber + "'";
            String query = "insert into \"Admin\" (\"id\", password, name, surname, phonenumber)  values (" + id + "," + password + "," + name + "," + surname + "," + phonenumber + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static Admin GetAdmin(string adminID)
        {
            ISession session = SessionManager.GetSession();
            Admin admin = new Admin();

            if (session == null)
                return null;

            Row admData = session.Execute("select * from \"Admin\" where \"id\"=" + "'" + adminID + "'").FirstOrDefault();

            if (admData != null)
            {
                admin.id = admData["id"] != null ? admData["id"].ToString() : string.Empty;
                admin.password = admData["password"] != null ? admData["password"].ToString() : string.Empty;
                admin.name = admData["name"] != null ? admData["name"].ToString() : string.Empty;
                admin.surname = admData["surname"] != null ? admData["surname"].ToString() : string.Empty;
                admin.phonenumber = admData["phonenumber"] != null ? admData["phonenumber"].ToString() : string.Empty;
            }

            return admin;
        }

        public static List<Admin> GetAdmins()
        {
            ISession session = SessionManager.GetSession();
            List<Admin> admins = new List<Admin>();

            if (session == null)
                return null;

            RowSet adminsData = session.Execute("select * from \"Admin\"");

            foreach (Row appData in adminsData)
            {
                Admin nova = new Admin();
                nova.id = appData["id"] != null ? appData["id"].ToString() : string.Empty;
                nova.password = appData["password"] != null ? appData["password"].ToString() : string.Empty;
                nova.name = appData["name"] != null ? appData["name"].ToString() : string.Empty;
                nova.surname = appData["surname"] != null ? appData["surname"].ToString() : string.Empty;
                nova.phonenumber = appData["phonenumber"] != null ? appData["phonenumber"].ToString() : string.Empty;
                admins.Add(nova);
            }

            return admins;
        }

        public static bool DeleteAdmin(String idAdmin)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            RowSet adminData = session.Execute("delete from \"Admin\" where \"id\" = '" + idAdmin + "'");
            return true;
        }

        #endregion

        #region User

        public static User GetUser(string userUsername)
        {
            ISession session = SessionManager.GetSession();
            User user = new User();

            if (session == null)
                return null;

            Row admData = session.Execute("select * from \"User\" where \"username\" = " + "'" + userUsername + "'").FirstOrDefault();

            if (admData != null)
            {
                user.id = admData["id"] != null ? admData["id"].ToString() : string.Empty;
                user.username = admData["id"] != null ? admData["username"].ToString() : string.Empty;
                user.password = admData["password"] != null ? admData["password"].ToString() : string.Empty;
                user.company = admData["company"] != null ? admData["company"].ToString() : string.Empty;
                user.email = admData["email"] != null ? admData["email"].ToString() : string.Empty;
            }

            return user;
        }

        public static bool AddUser(User user)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            User v = GetUser(user.username);
            if (v.username != null)
                return false;

            String id = "'" + user.id + "'";
            String username = "'" + user.username + "'";
            String password = "'" + user.password + "'";
            String company = "'" + user.company + "'";
            String email = "'" + user.email + "'";
            String query = "insert into \"User\" (\"id\", \"username\", password, company, email)  values (" + id + "," + username + "," + password + "," + company + "," + email + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static bool DeleteUser(String userUsername, String userID)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            RowSet adminData = session.Execute("delete from \"User\" where \"username\" = '" + userUsername + "'" + "and  \"id\" = '" + userID + "'");
            return true;
        }

        #endregion

        #region Applications

        public static List<Application> GetApps(String userId)
        {
            ISession session = SessionManager.GetSession();
            List<Application> apps = new List<Application>();


            if (session == null)
                return null;

            RowSet adminsData = session.Execute("select * from \"Application\" where \"ownerOfApp\" = '" + userId + "'");

            foreach (Row appData in adminsData)
            {
                Application nova = new Application();
                nova.appName = appData["appName"] != null ? appData["appName"].ToString() : string.Empty;
                nova.appType = appData["appType"] != null ? appData["appType"].ToString() : string.Empty;
                nova.purposeOfApp = appData["purposeOfApp"] != null ? appData["purposeOfApp"].ToString() : string.Empty;
                nova.termsOfUse = appData["termsOfUse"] != null ? appData["termsOfUse"].ToString() : string.Empty;
                apps.Add(nova);
            }

            return apps;
        }

        public static bool AddApp(Application app, String userId)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            String id = "'" + userId + "#" + app.appName + "'";
            String ownerApp = "'" + userId + "'";
            String appName = "'" + app.appName + "'";
            String appType = "'" + app.appType + "'";
            String purposeOfApp = "'" + app.purposeOfApp + "'";
            String termsOfUse = "'" + app.termsOfUse + "'";
            String query = "insert into \"Application\" (\"id\", \"ownerApp\", \"appName\", appType, purposeOfApp, termsOfUse)  values (" + id + "," + ownerApp + "," + appName + "," + appType + "," + purposeOfApp + "," + termsOfUse + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static bool DeleteApp(String appName, String userId)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            List<Customer> customers = GetCustomers(userId, appName);
            foreach (Customer k in customers)
            {
                RowSet deleteLog = session.Execute("delete from \"LogView\" where \"kompId\" ='" + userId + "#" + appName + "#" + k.username + "'");
                deleteLog = session.Execute("delete from \"LogEvent\" where \"kompID\" ='" + userId + "#" + appName + "#" + k.username + "'");
            }

            RowSet adminData = session.Execute("delete from \"Application\" where \"ownerApp\" ='" + userId + "' and \"id\" = '" + userId + "#" + appName + "'");
            return true;
        }

        #endregion

        #region Customers

        public static bool AddCustomer(Customer customer)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            String id = "'" + customer.applicationId + "'";
            String username = "'" + customer.username + "'";

            String query = "insert into \"Customer\" (\"applicationId\", \"username\")  values (" + id + "," + username + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static List<Customer> GetCustomers(String userId, String appName)
        {
            ISession session = SessionManager.GetSession();
            List<Customer> customers = new List<Customer>();

            if (session == null)
                return null;
            String applicationId = userId + "#" + appName;
            RowSet adminsData = session.Execute("select * from \"Customer\" where" + "\"applicationId\" ='" + applicationId + "'");

            foreach (Row appData in adminsData)
            {
                String username = appData["username"] != null ? appData["username"].ToString() : string.Empty;
                Customer nova = new Customer(applicationId, username);

                customers.Add(nova);
            }

            return customers;
        }

        #endregion

        #region LogView

        public static bool AddLogView(LogView logView)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            String compId = "'" + logView.compId + "'";
            String subjectName = "'" + logView.subjectName + "'";
            String viewType = "'" + logView.viewType + "'";
            String time = "'" + logView.time + "'";
            String query = "insert into \"LogView\" (\"id\",\"compId\", \"subjectName\", \"viewType\", time)  values ( uuid() ," + compId + "," + subjectName + "," + viewType + "," + time + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static int GetCountSubjectLogsView(String subjectName, String userId, String applicationName)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return -1;

            Row logData = session.Execute("select count(*) from \"LogView\" where \"subjectName\" = '" + userId + "#" + applicationName + "#" + subjectName + "'").FirstOrDefault();
            String brojS = logData["count"] != null ? logData["count"].ToString() : string.Empty;
            int broj = int.Parse(brojS);
            return broj;
        }

        public static List<LogView> GetLogsSubjectNameView(String subjectName, String userId, String applicationName)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
                return null;

            List<LogView> allCustomerLogs = new List<LogView>();
            RowSet logData = session.Execute("select* from \"LogView\" where \"subjectName\" = '" + userId + "#" + applicationName + "#" + subjectName + "'");
            foreach (Row appData in logData)
            {
                LogView nova = new LogView();
                nova.id = appData["id"] != null ? appData["id"].ToString() : string.Empty;
                nova.compId = appData["compId"] != null ? appData["compId"].ToString() : string.Empty;
                nova.subjectName = appData["subjectName"] != null ? appData["subjectName"].ToString() : string.Empty;
                nova.viewType = appData["viewType"] != null ? appData["viewType"].ToString() : string.Empty;
                nova.time = DateTime.Parse(appData["time"] != null ? appData["time"].ToString() : string.Empty);
                allCustomerLogs.Add(nova);
            }
            return allCustomerLogs;
        }

        public static List<LogView> GetLogsView(String username, String userId, String applicationName)
        {
            ISession session = SessionManager.GetSession();
            List<LogView> allCustomerLogs = new List<LogView>();
            if (session == null)
                return null;

            RowSet logData = session.Execute("select * from \"LogView\" where \"compId\" = '" + userId + "#" + applicationName + "#" + username + "'");

            foreach (Row appData in logData)
            {
                LogView nova = new LogView();
                nova.id = appData["id"] != null ? appData["id"].ToString() : string.Empty;
                nova.compId = appData["compId"] != null ? appData["compId"].ToString() : string.Empty;
                nova.subjectName = appData["subjectName"] != null ? appData["subjectName"].ToString() : string.Empty;
                nova.viewType = appData["viewType"] != null ? appData["viewType"].ToString() : string.Empty;
                nova.time = DateTime.Parse(appData["time"] != null ? appData["time"].ToString() : string.Empty);
                allCustomerLogs.Add(nova);
            }
            return allCustomerLogs;
        }

        public static List<LogView> GetSubjectLogsView(String subjectName, String userId, String applicationName)
        {
            ISession session = SessionManager.GetSession();
            List<LogView> allCustomerLogs = new List<LogView>();
            if (session == null)
                return null;

            RowSet logData = session.Execute("select * from \"LogView\" where \"subjectName\" = '" + userId + "#" + applicationName + "#" + subjectName + "'");

            foreach (Row appData in logData)
            {
                LogView nova = new LogView();
                nova.id = appData["id"] != null ? appData["id"].ToString() : string.Empty;
                nova.compId = appData["compId"] != null ? appData["compId"].ToString() : string.Empty;
                nova.subjectName = appData["subjectName"] != null ? appData["subjectName"].ToString() : string.Empty;
                nova.viewType = appData["viewType"] != null ? appData["viewType"].ToString() : string.Empty;
                nova.time = DateTime.Parse(appData["time"] != null ? appData["time"].ToString() : string.Empty);
                allCustomerLogs.Add(nova);
            }
            return allCustomerLogs;
        }

        #endregion

        #region LogEvent

        public static bool AddLogEvent(LogEvent logEvent)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            String compId = "'" + logEvent.compId + "'";
            String eventType = "'" + logEvent.eventType + "'";
            String time = "'" + logEvent.time + "'";
            String query = "insert into \"LogEvent\" (\"id\",\"compId\", \"eventType\", time)  values ( uuid() ," + compId + "," + eventType + "," + time + ")";
            RowSet userData = session.Execute(query);
            return true;
        }

        public static List<LogEvent> GetLogsEvent(String username, String userId, String applicationName)
        {
            ISession session = SessionManager.GetSession();
            List<LogEvent> allCustomerLogs = new List<LogEvent>();
            if (session == null)
                return null;

            RowSet logData = session.Execute("select * from \"LogEvent\" where \"compId\" = '" + userId + "#" + applicationName + "#" + username + "'");

            foreach (Row appData in logData)
            {
                LogEvent nova = new LogEvent();
                nova.id = appData["id"] != null ? appData["id"].ToString() : string.Empty;
                nova.compId = appData["compId"] != null ? appData["compId"].ToString() : string.Empty;
                nova.eventType = appData["eventType"] != null ? appData["eventType"].ToString() : string.Empty;
                nova.time = DateTime.Parse(appData["time"] != null ? appData["time"].ToString() : string.Empty);
                allCustomerLogs.Add(nova);
            }
            return allCustomerLogs;
        }
        #endregion

    }
}
