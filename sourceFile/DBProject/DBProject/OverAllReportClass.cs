using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db4objects.Db4o;

namespace DBProject
{
     
    class OverAllReportClass
    {
        public Report NewReport;
        public Patrol NewPatrol;
        public int id; 
        public OverAllReportClass(Report rep, Patrol patrol,int ID)
        {
            NewReport = rep;
            NewPatrol = patrol;
            id = ID;
        }
        public OverAllReportClass()
        {
        }
        public void insert(OverAllReportClass Allreport)
        {
            Complainant.db.Store(Allreport);
        }
    }
}
