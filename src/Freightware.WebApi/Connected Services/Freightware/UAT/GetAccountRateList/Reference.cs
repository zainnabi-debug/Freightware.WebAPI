﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendor.Services.Freightware.UAT.GetAccountRateList
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://namespace.softwareag.com/entirex/xml/mapping", ConfigurationName="Vendor.Services.Freightware.UAT.GetAccountRateList.FWV6WEBPort")]
    public interface FWV6WEBPort
    {
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="GetAccountRateList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        System.Threading.Tasks.Task<Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListResponse> GetAccountRateListAsync(Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetAccountRateListSequence
    {
        
        private bool byAccountCodeField;
        
        private bool byAccountCodeFieldSpecified;
        
        private bool byAccountCodeRateField;
        
        private bool byAccountCodeRateFieldSpecified;
        
        private bool byServiceAccountDateEffField;
        
        private bool byServiceAccountDateEffFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool ByAccountCode
        {
            get
            {
                return this.byAccountCodeField;
            }
            set
            {
                this.byAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ByAccountCodeSpecified
        {
            get
            {
                return this.byAccountCodeFieldSpecified;
            }
            set
            {
                this.byAccountCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool ByAccountCodeRate
        {
            get
            {
                return this.byAccountCodeRateField;
            }
            set
            {
                this.byAccountCodeRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ByAccountCodeRateSpecified
        {
            get
            {
                return this.byAccountCodeRateFieldSpecified;
            }
            set
            {
                this.byAccountCodeRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool ByServiceAccountDateEff
        {
            get
            {
                return this.byServiceAccountDateEffField;
            }
            set
            {
                this.byServiceAccountDateEffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ByServiceAccountDateEffSpecified
        {
            get
            {
                return this.byServiceAccountDateEffFieldSpecified;
            }
            set
            {
                this.byServiceAccountDateEffFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetAccountRateListStartValues
    {
        
        private string inAccountCodeField;
        
        private string inActiveRateIndField;
        
        private string inDateEffectiveField;
        
        private string inServiceTypeField;
        
        private string inRateTypeField;
        
        private string inProductTypeField;
        
        private string inAreaFromField;
        
        private string inAreaToField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string InAccountCode
        {
            get
            {
                return this.inAccountCodeField;
            }
            set
            {
                this.inAccountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string InActiveRateInd
        {
            get
            {
                return this.inActiveRateIndField;
            }
            set
            {
                this.inActiveRateIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string InDateEffective
        {
            get
            {
                return this.inDateEffectiveField;
            }
            set
            {
                this.inDateEffectiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string InServiceType
        {
            get
            {
                return this.inServiceTypeField;
            }
            set
            {
                this.inServiceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string InRateType
        {
            get
            {
                return this.inRateTypeField;
            }
            set
            {
                this.inRateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string InProductType
        {
            get
            {
                return this.inProductTypeField;
            }
            set
            {
                this.inProductTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string InAreaFrom
        {
            get
            {
                return this.inAreaFromField;
            }
            set
            {
                this.inAreaFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string InAreaTo
        {
            get
            {
                return this.inAreaToField;
            }
            set
            {
                this.inAreaToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetAccountRateListResponseAccountRateOutput
    {
        
        private string custCodeField;
        
        private string serviceTypeField;
        
        private string rateTypeField;
        
        private string productTypeField;
        
        private string areaFromField;
        
        private string areaToField;
        
        private decimal dateEffectiveField;
        
        private bool dateEffectiveFieldSpecified;
        
        private decimal dateCeaseField;
        
        private bool dateCeaseFieldSpecified;
        
        private string[] commentsField;
        
        private string companyCodeField;
        
        private string currencyCodeField;
        
        private string custCoCodeField;
        
        private string directionIndField;
        
        private string idCaptureField;
        
        private string idModifyField;
        
        private decimal minimumChargeField;
        
        private bool minimumChargeFieldSpecified;
        
        private GetAccountRateListResponseAccountRateOutputRatesTable[] ratesTablesField;
        
        private decimal uniqueIdField;
        
        private bool uniqueIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CustCode
        {
            get
            {
                return this.custCodeField;
            }
            set
            {
                this.custCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string RateType
        {
            get
            {
                return this.rateTypeField;
            }
            set
            {
                this.rateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string AreaFrom
        {
            get
            {
                return this.areaFromField;
            }
            set
            {
                this.areaFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string AreaTo
        {
            get
            {
                return this.areaToField;
            }
            set
            {
                this.areaToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal DateEffective
        {
            get
            {
                return this.dateEffectiveField;
            }
            set
            {
                this.dateEffectiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateEffectiveSpecified
        {
            get
            {
                return this.dateEffectiveFieldSpecified;
            }
            set
            {
                this.dateEffectiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public decimal DateCease
        {
            get
            {
                return this.dateCeaseField;
            }
            set
            {
                this.dateCeaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCeaseSpecified
        {
            get
            {
                return this.dateCeaseFieldSpecified;
            }
            set
            {
                this.dateCeaseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string CompanyCode
        {
            get
            {
                return this.companyCodeField;
            }
            set
            {
                this.companyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string CustCoCode
        {
            get
            {
                return this.custCoCodeField;
            }
            set
            {
                this.custCoCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string DirectionInd
        {
            get
            {
                return this.directionIndField;
            }
            set
            {
                this.directionIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string IdCapture
        {
            get
            {
                return this.idCaptureField;
            }
            set
            {
                this.idCaptureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string IdModify
        {
            get
            {
                return this.idModifyField;
            }
            set
            {
                this.idModifyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public decimal MinimumCharge
        {
            get
            {
                return this.minimumChargeField;
            }
            set
            {
                this.minimumChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumChargeSpecified
        {
            get
            {
                return this.minimumChargeFieldSpecified;
            }
            set
            {
                this.minimumChargeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RatesTable", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetAccountRateListResponseAccountRateOutputRatesTable[] RatesTables
        {
            get
            {
                return this.ratesTablesField;
            }
            set
            {
                this.ratesTablesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public decimal UniqueId
        {
            get
            {
                return this.uniqueIdField;
            }
            set
            {
                this.uniqueIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueIdSpecified
        {
            get
            {
                return this.uniqueIdFieldSpecified;
            }
            set
            {
                this.uniqueIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB")]
    public partial class GetAccountRateListResponseAccountRateOutputRatesTable
    {
        
        private decimal quantityFromField;
        
        private bool quantityFromFieldSpecified;
        
        private decimal quantityToField;
        
        private bool quantityToFieldSpecified;
        
        private decimal ratePerUnitField;
        
        private bool ratePerUnitFieldSpecified;
        
        private string rateIndField;
        
        private decimal rateAmountField;
        
        private bool rateAmountFieldSpecified;
        
        private string roundingIndField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal QuantityFrom
        {
            get
            {
                return this.quantityFromField;
            }
            set
            {
                this.quantityFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityFromSpecified
        {
            get
            {
                return this.quantityFromFieldSpecified;
            }
            set
            {
                this.quantityFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal QuantityTo
        {
            get
            {
                return this.quantityToField;
            }
            set
            {
                this.quantityToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityToSpecified
        {
            get
            {
                return this.quantityToFieldSpecified;
            }
            set
            {
                this.quantityToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal RatePerUnit
        {
            get
            {
                return this.ratePerUnitField;
            }
            set
            {
                this.ratePerUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatePerUnitSpecified
        {
            get
            {
                return this.ratePerUnitFieldSpecified;
            }
            set
            {
                this.ratePerUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string RateInd
        {
            get
            {
                return this.rateIndField;
            }
            set
            {
                this.rateIndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal RateAmount
        {
            get
            {
                return this.rateAmountField;
            }
            set
            {
                this.rateAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateAmountSpecified
        {
            get
            {
                return this.rateAmountFieldSpecified;
            }
            set
            {
                this.rateAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string RoundingInd
        {
            get
            {
                return this.roundingIndField;
            }
            set
            {
                this.roundingIndField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccountRateList", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class GetAccountRateListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InUserid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InCustCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InRequestCtr;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IoSessionData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListSequence Sequence;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListStartValues StartValues;
        
        public GetAccountRateListRequest()
        {
        }
        
        public GetAccountRateListRequest(string InUserid, string InPassword, string InCustCode, string InRequestCtr, string IoSessionData, Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListSequence Sequence, Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListStartValues StartValues)
        {
            this.InUserid = InUserid;
            this.InPassword = InPassword;
            this.InCustCode = InCustCode;
            this.InRequestCtr = InRequestCtr;
            this.IoSessionData = IoSessionData;
            this.Sequence = Sequence;
            this.StartValues = StartValues;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccountRateListResponse", WrapperNamespace="urn:com-softwareag-entirex-rpc:FWV6WEB", IsWrapped=true)]
    public partial class GetAccountRateListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IoSessionData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnCtr;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnMessage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:com-softwareag-entirex-rpc:FWV6WEB", Order=4)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AccountRateOutput", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListResponseAccountRateOutput[] AccountRateOutputs;
        
        public GetAccountRateListResponse()
        {
        }
        
        public GetAccountRateListResponse(string IoSessionData, string ReturnCtr, string ReturnCode, string ReturnMessage, Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListResponseAccountRateOutput[] AccountRateOutputs)
        {
            this.IoSessionData = IoSessionData;
            this.ReturnCtr = ReturnCtr;
            this.ReturnCode = ReturnCode;
            this.ReturnMessage = ReturnMessage;
            this.AccountRateOutputs = AccountRateOutputs;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface FWV6WEBPortChannel : Vendor.Services.Freightware.UAT.GetAccountRateList.FWV6WEBPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FWV6WEBPortClient : System.ServiceModel.ClientBase<Vendor.Services.Freightware.UAT.GetAccountRateList.FWV6WEBPort>, Vendor.Services.Freightware.UAT.GetAccountRateList.FWV6WEBPort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), FWV6WEBPortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FWV6WEBPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FWV6WEBPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListResponse> GetAccountRateListAsync(Vendor.Services.Freightware.UAT.GetAccountRateList.GetAccountRateListRequest request)
        {
            return base.Channel.GetAccountRateListAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP12Port))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP12Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8180/FreightWareV6Test/services/GetAccoun" +
                        "tRateList.FWV6WEBSOAP12Port/");
            }
            if ((endpointConfiguration == EndpointConfiguration.FWV6WEBSOAP11Port))
            {
                return new System.ServiceModel.EndpointAddress("http://triton-fw.clients.dovetail.co.za:8180/FreightWareV6Test/services/GetAccoun" +
                        "tRateList.FWV6WEBSOAP11Port/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            FWV6WEBSOAP12Port,
            
            FWV6WEBSOAP11Port,
        }
    }
}
