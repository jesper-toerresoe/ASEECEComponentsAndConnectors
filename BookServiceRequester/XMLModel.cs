using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServiceRequester.Model.XML
{
    /*
     * <Book xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/BookService.Models">
     *   <Author>
     *       <Id>1</Id>
     *       <Name>sample string 2</Name>
     *   </Author>
     *   <AuthorId>6</AuthorId>
     *   <Genre>sample string 5</Genre>
     *   <Id>1</Id>
     *   <Price>4</Price>
     *   <Title>sample string 2</Title>
     *   <Year>3</Year>
     * </Book>
     */
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Book
    {

        private BookAuthor authorField;

        private int authorIdField;

        private string genreField;

        private int idField;

        private decimal priceField;

        private string titleField;

        private int yearField;

        /// <remarks/>
        public BookAuthor Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public int AuthorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }

        /// <remarks/>
        public string Genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public int Id
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
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public int Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BookAuthor
    {

        private int idField;

        private string nameField;

        /// <remarks/>
        public int Id
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
    }

    /*
     * <ArrayOfBook xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/BookService.Models">
     *   <Book>
     *     <Author>
     *       <Id>1</Id>
     *       <Name>sample string 2</Name>
     *     </Author>
     *     <AuthorId>6</AuthorId>
     *     <Genre>sample string 5</Genre>
     *     <Id>1</Id>
     *     <Price>4</Price>
     *     <Title>sample string 2</Title>
     *     <Year>3</Year>
     *   </Book>
     *   <Book>
     *     <Author>
     *       <Id>1</Id>
     *       <Name>sample string 2</Name>
     *     </Author>
     *     <AuthorId>6</AuthorId>
     *     <Genre>sample string 5</Genre>
     *     <Id>1</Id>
     *     <Price>4</Price>
     *     <Title>sample string 2</Title>
     *     <Year>3</Year>
     *   </Book>
     *   </ArrayOfBook>
     * 
     */

    /// <remarks/>
   
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ArrayOfBook
    {

        private List<ArrayOfBookBook> bookField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Book")]
        public List<ArrayOfBookBook> Book
        {
            get
            {
                return this.bookField;
            }
            set
            {
                this.bookField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfBookBook
    {

        private ArrayOfBookBookAuthor authorField;

        private int authorIdField;

        private string genreField;

        private int idField;

        private decimal priceField;

        private string titleField;

        private int yearField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable=true)]
        public ArrayOfBookBookAuthor Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public int AuthorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }

        /// <remarks/>
        public string Genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public int Id
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
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public int Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfBookBookAuthor
    {

        private int idField;

        private string nameField;

        /// <remarks/>
        public int Id
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
    }

    /*   
     *    <Author xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/BookService.Models">
     *    <Id>1</Id>
     *      <Name>sample string 2</Name>
     *    </Author>
    */


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Author
    {

        private int idField;

        private string nameField;

        /// <remarks/>
        public int Id
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
    }

    /*
     * <ArrayOfAuthor xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/BookService.Models">
     *   <Author>
     *       <Id>1</Id>
     *       <Name>sample string 2</Name>
     *   </Author>
     *   <Author>
     *       <Id>1</Id>
     *       <Name>sample string 2</Name>
     *   </Author>
     *  </ArrayOfAuthor>
     * 
     * 
     */

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ArrayOfAuthor
    {

        private List<ArrayOfAuthorAuthor> authorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Author")]
        public List<ArrayOfAuthorAuthor> Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfAuthorAuthor
    {

        private int idField;

        private string nameField;

        /// <remarks/>
        public int Id
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
    }

}
