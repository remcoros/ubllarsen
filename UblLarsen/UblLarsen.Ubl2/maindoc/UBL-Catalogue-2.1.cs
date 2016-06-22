// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     https://github.com/Gammern/ubllarsen
//     
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblLarsen.Ubl2
{
    using Cac;
    using Udt;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: Catalogue. Details</para>
    /// <para>Definition: A document that describes items, prices, and price validity.</para>
    /// <para>ObjectClass: Catalogue</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Catalogue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Catalogue-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("Catalogue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Catalogue-2", IsNullable=false)]
#endif
    public partial class CatalogueType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Action Code. Code</para>
        /// <para>Definition: A code signifying whether the transaction is a replacement or an update.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Action Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// <para>Examples: Replace , Update .</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ActionCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Name</para>
        /// <para>Definition: Text, assigned by the sender, that identifies this document to business users.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Name</para>
        /// <para>RepresentationTerm: Name</para>
        /// <para>DataType: Name. Type</para>
        /// <para>Examples: winter 2005 collection</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Revision Date. Date</para>
        /// <para>Definition: The date, assigned by the seller party, on which the information in the Catalogue was last revised.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Revision Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType RevisionDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Revision Time. Time</para>
        /// <para>Definition: The time, assigned by the Seller party, at which the information in the Catalogue was last revised.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Revision Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType RevisionTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Description. Text</para>
        /// <para>Definition: Textual description of the document instance.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Description</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// <para>Examples: computer accessories for laptops</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Version. Identifier</para>
        /// <para>Definition: An identifier for the current version of the Catalogue.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.1</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Previous_ Version. Identifier</para>
        /// <para>Definition: An identifier for the previous version of the Catalogue that is superseded by this version.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Previous</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.0</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PreviousVersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue. Line Count. Numeric</para>
        /// <para>Definition: The number of Catalogue Lines in the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Validity_ Period. Period</para>
        /// <para>Definition: A period, assigned by the seller, during which the information in the Catalogue is effective. This may be given as start and end dates or as a duration.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Validity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] ValidityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Referenced_ Contract. Contract</para>
        /// <para>Definition: A contract or framework agreement with which this Catalogue is associated.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Referenced</para>
        /// <para>PropertyTerm: Contract</para>
        /// <para>AssociatedObjectClass: Contract</para>
        /// <para>RepresentationTerm: Contract</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractType[] ReferencedContract { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Source_ Catalogue Reference. Catalogue Reference</para>
        /// <para>Definition: A reference to the source catalogue.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Source</para>
        /// <para>PropertyTerm: Catalogue Reference</para>
        /// <para>AssociatedObjectClass: Catalogue Reference</para>
        /// <para>RepresentationTerm: Catalogue Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CatalogueReferenceType SourceCatalogueReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Document Reference</para>
        /// <para>Definition: A reference to another document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Provider_ Party. Party</para>
        /// <para>Definition: The party providing the Catalogue.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Provider</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ProviderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Receiver_ Party. Party</para>
        /// <para>Definition: The party receiving the Catalogue.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Contractor_ Customer Party. Customer Party</para>
        /// <para>Definition: The customer party responsible for the contracts with which the Catalogue is associated.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTermQualifier: Contractor</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType ContractorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Trading Terms</para>
        /// <para>Definition: The trading terms associated with this Catalogue.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Trading Terms</para>
        /// <para>AssociatedObjectClass: Trading Terms</para>
        /// <para>RepresentationTerm: Trading Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TradingTermsType[] TradingTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue. Catalogue Line</para>
        /// <para>Definition: A line in a Catalogue describing an item of sale.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Catalogue</para>
        /// <para>PropertyTerm: Catalogue Line</para>
        /// <para>AssociatedObjectClass: Catalogue Line</para>
        /// <para>RepresentationTerm: Catalogue Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CatalogueLineType[] CatalogueLine { get; set; }
    }
}
