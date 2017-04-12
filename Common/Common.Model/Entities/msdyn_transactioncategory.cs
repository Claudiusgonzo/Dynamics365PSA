//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Common.Model
{
    public enum msdyn_transactioncategoryState
    {
        Active = 0,
        Inactive = 1,
    }

    /// <summary>
    /// Business transaction categories to classify costs and revenue.
    /// </summary>
    public partial class msdyn_transactioncategory : Microsoft.Xrm.Sdk.Samples.Entity, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_transactioncategory() : base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_transactioncategory";

        public const int EntityTypeCode = 10114;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the record.
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
        /// </summary>
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the user who modified the record.
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Select the default billing type of project transactions in this category. Valid values are Chargeable, Non chargeable or Complimentary. Only chargeable transactions will add to an invoice total
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.OptionSetValue msdyn_BillingType
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("msdyn_billingtype");
            }
            set
            {
                this.SetAttributeValue("msdyn_billingtype", value);
                this.OnPropertyChanged("msdyn_BillingType");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference msdyn_DefaultUnit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("msdyn_defaultunit");
            }
            set
            {
                this.SetAttributeValue("msdyn_defaultunit", value);
                this.OnPropertyChanged("msdyn_DefaultUnit");
            }
        }

        /// <summary>
        /// Type the name of the custom entity.
        /// </summary>
        public string msdyn_name
        {
            get
            {
                return this.GetAttributeValue<string>("msdyn_name");
            }
            set
            {
                this.SetAttributeValue("msdyn_name", value);
                this.OnPropertyChanged("msdyn_name");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        public System.Nullable<System.Guid> msdyn_transactioncategoryId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_transactioncategoryid");
            }
            set
            {
                this.SetAttributeValue("msdyn_transactioncategoryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_transactioncategoryId");
            }
        }

        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.msdyn_transactioncategoryId = value;
            }
        }

        /// <summary>
        /// Select the unit schedule that is associated with the transaction category.
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference msdyn_UnitGroup
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("msdyn_unitgroup");
            }
            set
            {
                this.SetAttributeValue("msdyn_unitgroup", value);
                this.OnPropertyChanged("msdyn_UnitGroup");
            }
        }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.EntityReference OrganizationId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("organizationid");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Status of the Transaction Category
        /// </summary>
        public System.Nullable<Common.Model.msdyn_transactioncategoryState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.Samples.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Common.Model.msdyn_transactioncategoryState)(System.Enum.ToObject(typeof(Common.Model.msdyn_transactioncategoryState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.Samples.OptionSetValue(((int)(value))));
                }
                this.OnPropertyChanged("statecode");
            }
        }

        /// <summary>
        /// Reason for the status of the Transaction Category
        /// </summary>
        public Microsoft.Xrm.Sdk.Samples.OptionSetValue statuscode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("statuscode");
            }
            set
            {
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("statuscode");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version Number
        /// </summary>
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N msdyn_msdyn_transactioncategory_msdyn_expensecatego
        /// </summary>
        public System.Collections.Generic.IEnumerable<Common.Model.msdyn_expensecategory> msdyn_msdyn_transactioncategory_msdyn_expensecatego
        {
            get
            {
                return this.GetRelatedEntities<Common.Model.msdyn_expensecategory>("msdyn_msdyn_transactioncategory_msdyn_expensecatego", null);
            }
            set
            {
                this.SetRelatedEntities<Common.Model.msdyn_expensecategory>("msdyn_msdyn_transactioncategory_msdyn_expensecatego", null, value);
                this.OnPropertyChanged("msdyn_msdyn_transactioncategory_msdyn_expensecatego");
            }
        }

        /// <summary>
        /// 1:N msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory
        /// </summary>
        public System.Collections.Generic.IEnumerable<Common.Model.msdyn_projecttask> msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory
        {
            get
            {
                return this.GetRelatedEntities<Common.Model.msdyn_projecttask>("msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory", null);
            }
            set
            {
                this.SetRelatedEntities<Common.Model.msdyn_projecttask>("msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory", null, value);
                this.OnPropertyChanged("msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory");
            }
        }

        /// <summary>
        /// 1:N msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory
        /// </summary>
        public System.Collections.Generic.IEnumerable<Common.Model.msdyn_transactioncategoryhierarchyelement> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory
        {
            get
            {
                return this.GetRelatedEntities<Common.Model.msdyn_transactioncategoryhierarchyelement>("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCa" +
                        "tegory", null);
            }
            set
            {
                this.SetRelatedEntities<Common.Model.msdyn_transactioncategoryhierarchyelement>("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCa" +
                        "tegory", null, value);
                this.OnPropertyChanged("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCa" +
                        "tegory");
            }
        }

        /// <summary>
        /// 1:N msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory
        /// </summary>
        public System.Collections.Generic.IEnumerable<Common.Model.msdyn_transactioncategoryhierarchyelement> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory
        {
            get
            {
                return this.GetRelatedEntities<Common.Model.msdyn_transactioncategoryhierarchyelement>("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentC" +
                        "ategory", null);
            }
            set
            {
                this.SetRelatedEntities<Common.Model.msdyn_transactioncategoryhierarchyelement>("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentC" +
                        "ategory", null, value);
                this.OnPropertyChanged("msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentC" +
                        "ategory");
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_transactioncategory_createdby
        /// </summary>
        public Common.Model.SystemUser lk_msdyn_transactioncategory_createdby
        {
            get
            {
                return this.GetRelatedEntity<Common.Model.SystemUser>("lk_msdyn_transactioncategory_createdby", null);
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_transactioncategory_createdonbehalfby
        /// </summary>
        public Common.Model.SystemUser lk_msdyn_transactioncategory_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<Common.Model.SystemUser>("lk_msdyn_transactioncategory_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_transactioncategory_modifiedby
        /// </summary>
        public Common.Model.SystemUser lk_msdyn_transactioncategory_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<Common.Model.SystemUser>("lk_msdyn_transactioncategory_modifiedby", null);
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_transactioncategory_modifiedonbehalfby
        /// </summary>
        public Common.Model.SystemUser lk_msdyn_transactioncategory_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<Common.Model.SystemUser>("lk_msdyn_transactioncategory_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 organization_msdyn_transactioncategory
        /// </summary>
        public Common.Model.Organization organization_msdyn_transactioncategory
        {
            get
            {
                return this.GetRelatedEntity<Common.Model.Organization>("organization_msdyn_transactioncategory", null);
            }
        }
    }
}