using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CassandraDataLayer.QueryEntities;
using Cassandra;

namespace CassandraDataLayer
{
    public class CustomerLog
    {
        private string _userId;
        private string _applicationName;

        ///<summary>
        ///Konstruktor objekta pomocu kog se mogu logovati akcije korisnika(customer)
        ///Da bi mogao da se koristi potrebno je da postoji registrovan customer, 
        ///aplikacije u bazi i kreirana "aplikacija" na njegovom nalogu.
        ///<param name="applicationName">Naziv aplikacije koja je kreirana u nalogu korisnika za koju se loguju podaci</param>
        ///<param name="userUsername">Username (korisnicko ime) usera aplikacije koji je registrovan u sistemu.</param>
        ///<param name="password">Password (lozinka) usera aplikacije koji je registrovan u sistemu.</param>
        ///</summary>
        public CustomerLog(String applicationName, String userUsername, String password)
        {
            User v = DataProvider.GetUser(userUsername);
            if (v.password != password)
                return;

            _userId = v.id;
            _applicationName = applicationName;
        }

        ///<summary>
        ///Dodaje novog korisnika u tabelu Customer.        
        ///</summary>
        public void RegisterCustomer(String customerUsername)
        {
            DataProvider.AddCustomer(new Customer(_userId + "#" + _applicationName, customerUsername));
        }

        ///<summary>
        ///Loguje korisnikov pregled predmeta.         
        ///</summary>
        public void LogCustomerView(String customerUsername, String subjectName, String viewType)
        {
            LogView lv = new LogView();
            lv.compId = _userId + "#" + _applicationName + "#" + customerUsername;
            lv.subjectName = _userId + "#" + _applicationName + "#" + subjectName;
            lv.viewType = viewType;
            lv.time = DateTime.Now;
            DataProvider.AddLogView(lv);
        }

        ///<summary>
        ///Vraca sve logovane preglede korisnika.       
        ///</summary>
        public List<LogView> GetLogsView(String customerUsername)
        {
            List<LogView> lvs = new List<LogView>();
            lvs = DataProvider.GetLogsView(customerUsername, _userId, _applicationName);
            return lvs;
        }

        ///<summary>
        ///Vraca broj pregleda odredjenog predmeta.       
        ///</summary>
        public int GetSubjectLogsView(String subjectName)
        {
            int br = DataProvider.GetCountSubjectLogsView(subjectName, _userId, _applicationName);
            return br;
        }

        ///<summary>
        ///Vrace sve logove odredjenog predmeta. Svaki log u kome se nalazi naziv predmeta koji je dat kao argument.        
        ///</summary>
        public List<LogView> GetLogsSubjectNameView(String subjectName)
        {
            List<LogView> lps = DataProvider.GetLogsSubjectNameView(subjectName, _userId, _applicationName);
            return lps;
        }

        ///<summary>
        ///Dodaje novi dogadjaj odredjenog korisnika. Sluzi za logovanje korisnickih akcija nevezanih za odredjene predmete.        
        ///</summary>
        public void LogEvent(String customerUsername, String eventType)
        {
            LogEvent lp = new LogEvent();
            lp.compId = _userId + "#" + _applicationName + "#" + customerUsername;
            lp.eventType = _userId + "#" + _applicationName + "#" + eventType;
            lp.time = DateTime.Now;
            DataProvider.AddLogEvent(lp);
        }

        ///<summary>
        ///Vraca sve logove dogadjaja odredjenog korisnika.        
        ///</summary>
        public List<LogEvent> GetLogsEvent(String customerUsername)
        {
            List<LogEvent> lps = new List<LogEvent>();
            lps = DataProvider.GetLogsEvent(customerUsername, _userId, _applicationName);
            return lps;
        }
    }
}
