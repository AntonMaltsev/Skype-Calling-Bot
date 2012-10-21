using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace SkypeCallingBot
{
    public class Phone
    {
        public const bool UNREPORTED_STATUS=false;   
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String phoneNumber;

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Phone()
        {
        }

        public Phone(int id, String phoneNumber, bool status)
        {
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.status = status;
        }

        public static IList<Phone> getAllPhones()
        {
            ISession session = Model.getSession();
            ITransaction transaction = session.BeginTransaction();
            IList<Phone> phones = session.CreateQuery("from Phone").List<Phone>();
            transaction.Commit();
            return phones;
        }

        public static IList<Phone> getUnCalledPhones()
        {
            ISession session = Model.getSession();
            ITransaction transaction = session.BeginTransaction();
            IList<Phone> phones = session.CreateQuery("from Phone p where p.Status = :status")
                .SetParameter("status", Phone.UNREPORTED_STATUS)
                .List<Phone>();
            transaction.Commit();
            return phones;
        }

        public static void updatePhone(Phone phone)
        {
            ISession session = Model.getSession();
            session.Update(phone);
        }
    }
}
