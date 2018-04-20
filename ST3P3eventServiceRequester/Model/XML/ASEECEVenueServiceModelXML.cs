using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEECEVenueServiceRequester.Model.XML
{
    class ASEECEVenueServiceModelXML
    {
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models", IsNullable = false)]
    public partial class ArrayOfVenue
    {

        private ArrayOfVenueVenue[] venueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Venue")]
        public ArrayOfVenueVenue[] Venue
        {
            get
            {
                return this.venueField;
            }
            set
            {
                this.venueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/VenueServiceASEECE.Models")]
    public partial class ArrayOfVenueVenue
    {

        private object commingEventsField;

        private string countryField;

        private byte idField;

        private string nameField;

        private string streetField;

        private string townField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object CommingEvents
        {
            get
            {
                return this.commingEventsField;
            }
            set
            {
                this.commingEventsField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }
    }




}
