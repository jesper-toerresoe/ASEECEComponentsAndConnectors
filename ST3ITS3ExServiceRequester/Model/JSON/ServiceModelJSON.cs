using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST3ITS3ExServiceRequester.Model.JSON
{
   
    public class LTBloodGlucoseReports
    {
        public List<LTBloodGlucoseReport> LTBGReports { get; set; }
    }

    public class LTBloodGlucoseReport
    {
        public int LTBloodGlucoseReportId { get; set; }
        public string ReportingClinicName { get; set; }
        public int SampleIdFromClinic { get; set; }
        public string CitizenName { get; set; }
        public float MmolperLitre { get; set; }
        public DateTime SampleTime { get; set; }
        public bool SelfHelpCoursesProvided { get; set; }
        public List<Selfhelpcours> SelfHelpCourses { get; set; }
    }

    public class Selfhelpcours
    {
        public int SelfHelpCourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public bool Accepted { get; set; }
        public bool Ongoing { get; set; }
    }

}
