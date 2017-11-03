using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST3ITS3ExServiceRequester.Model.JSON;
using ST3ITS3ExServiceRequester.Util.JSON;

namespace TestApplication
{
    class ST3ITS3ExServiceTesterJson
    {
        public void TestExService()
        {
            ST3P3ExServiceUtilJSON tester = new ST3P3ExServiceUtilJSON("localhost", "39079", "TestJSON");
            LTBloodGlucoseReports ltrep = new LTBloodGlucoseReports();
            ltrep.LTBGReports = tester.getAllLTBGRep();
        }
    }
}
