using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST3ITS3ExServiceRequester.Model.XML
{
  
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/TestJRT2.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/TestJRT2.Models", IsNullable = false)]
    public partial class ArrayOfLTBloodGlucoseReport
    {

        private List<ArrayOfLTBloodGlucoseReportLTBloodGlucoseReport> lTBloodGlucoseReportField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LTBloodGlucoseReport")]
        public List<ArrayOfLTBloodGlucoseReportLTBloodGlucoseReport> LTBloodGlucoseReport
        {
            get
            {
                return this.lTBloodGlucoseReportField;
            }
            set
            {
                this.lTBloodGlucoseReportField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/TestJRT2.Models")]
    public partial class ArrayOfLTBloodGlucoseReportLTBloodGlucoseReport
    {

        private string citizenNameField;

        private byte lTBloodGlucoseReportIdField;

        private decimal mmolperLitreField;

        private string reportingClinicNameField;

        private ushort sampleIdFromClinicField;

        private System.DateTime sampleTimeField;

        private ArrayOfLTBloodGlucoseReportLTBloodGlucoseReportSelfHelpCourse[] selfHelpCoursesField;

        private bool selfHelpCoursesProvidedField;

        /// <remarks/>
        public string CitizenName
        {
            get
            {
                return this.citizenNameField;
            }
            set
            {
                this.citizenNameField = value;
            }
        }

        /// <remarks/>
        public byte LTBloodGlucoseReportId
        {
            get
            {
                return this.lTBloodGlucoseReportIdField;
            }
            set
            {
                this.lTBloodGlucoseReportIdField = value;
            }
        }

        /// <remarks/>
        public decimal MmolperLitre
        {
            get
            {
                return this.mmolperLitreField;
            }
            set
            {
                this.mmolperLitreField = value;
            }
        }

        /// <remarks/>
        public string ReportingClinicName
        {
            get
            {
                return this.reportingClinicNameField;
            }
            set
            {
                this.reportingClinicNameField = value;
            }
        }

        /// <remarks/>
        public ushort SampleIdFromClinic
        {
            get
            {
                return this.sampleIdFromClinicField;
            }
            set
            {
                this.sampleIdFromClinicField = value;
            }
        }

        /// <remarks/>
        public System.DateTime SampleTime
        {
            get
            {
                return this.sampleTimeField;
            }
            set
            {
                this.sampleTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SelfHelpCourse", IsNullable = false)]
        public ArrayOfLTBloodGlucoseReportLTBloodGlucoseReportSelfHelpCourse[] SelfHelpCourses
        {
            get
            {
                return this.selfHelpCoursesField;
            }
            set
            {
                this.selfHelpCoursesField = value;
            }
        }

        /// <remarks/>
        public bool SelfHelpCoursesProvided
        {
            get
            {
                return this.selfHelpCoursesProvidedField;
            }
            set
            {
                this.selfHelpCoursesProvidedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/TestJRT2.Models")]
    public partial class ArrayOfLTBloodGlucoseReportLTBloodGlucoseReportSelfHelpCourse
    {

        private bool acceptedField;

        private string courseNameField;

        private string courseTypeField;

        private bool ongoingField;

        private byte selfHelpCourseIDField;

        /// <remarks/>
        public bool Accepted
        {
            get
            {
                return this.acceptedField;
            }
            set
            {
                this.acceptedField = value;
            }
        }

        /// <remarks/>
        public string CourseName
        {
            get
            {
                return this.courseNameField;
            }
            set
            {
                this.courseNameField = value;
            }
        }

        /// <remarks/>
        public string CourseType
        {
            get
            {
                return this.courseTypeField;
            }
            set
            {
                this.courseTypeField = value;
            }
        }

        /// <remarks/>
        public bool Ongoing
        {
            get
            {
                return this.ongoingField;
            }
            set
            {
                this.ongoingField = value;
            }
        }

        /// <remarks/>
        public byte SelfHelpCourseID
        {
            get
            {
                return this.selfHelpCourseIDField;
            }
            set
            {
                this.selfHelpCourseIDField = value;
            }
        }
    }



}
