using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace SkypeCallingBot
{
    public class Processed
    {
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
        private bool answer;

        public bool Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public Processed()
        {
        }

        public Processed(String phoneNumber, bool answer)
        {
            this.phoneNumber = phoneNumber;
            this.answer = answer;
        }

        public static IList<Processed> getAllProcessed()
        {
            ISession session = Model.getSession();
            ITransaction transaction = session.BeginTransaction();
            IList<Processed> processed = session.CreateQuery("from Processed").List<Processed>();
            transaction.Commit();
            return processed;
        }

        public static IList<Processed> getProcessedForAnswer(bool answer)
        {
            ISession session = Model.getSession();
            ITransaction transaction = session.BeginTransaction();
            IList<Processed> processed = session.CreateQuery("from Processed p where p.Answer = :answer")
                .SetParameter("answer", answer)
                .List<Processed>();
            transaction.Commit();
            return processed;
        }

        public static void updateProcessed(Processed processed)
        {
            ISession session = Model.getSession();
            session.Update(processed);
        }

        public static void saveProcessed(Processed processed)
        {
            ISession session = Model.getSession();
            session.Save(processed);
        }
    }
}
