/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ContractModel : IEquatable<ContractModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets BillingPreference
        /// </summary>
        [DataMember(Name="billingPreference")]
        public int? BillingPreference { get; set; }

        /// <summary>
        /// Gets or Sets BillToCompanyContactID
        /// </summary>
        [DataMember(Name="billToCompanyContactID")]
        public int? BillToCompanyContactID { get; set; }

        /// <summary>
        /// Gets or Sets BillToCompanyID
        /// </summary>
        [DataMember(Name="billToCompanyID")]
        public int? BillToCompanyID { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID")]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="contactID")]
        public int? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContractCategory
        /// </summary>
        [DataMember(Name="contractCategory")]
        public int? ContractCategory { get; set; }

        /// <summary>
        /// Gets or Sets ContractExclusionSetID
        /// </summary>
        [DataMember(Name="contractExclusionSetID")]
        public int? ContractExclusionSetID { get; set; }

        /// <summary>
        /// Gets or Sets ContractName
        /// </summary>
        [DataMember(Name="contractName")]
        public string ContractName { get; set; }

        /// <summary>
        /// Gets or Sets ContractNumber
        /// </summary>
        [DataMember(Name="contractNumber")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContractPeriodType
        /// </summary>
        [DataMember(Name="contractPeriodType")]
        public int? ContractPeriodType { get; set; }

        /// <summary>
        /// Gets or Sets ContractType
        /// </summary>
        [DataMember(Name="contractType")]
        public int? ContractType { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCost
        /// </summary>
        [DataMember(Name="estimatedCost")]
        public double? EstimatedCost { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedHours
        /// </summary>
        [DataMember(Name="estimatedHours")]
        public double? EstimatedHours { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedRevenue
        /// </summary>
        [DataMember(Name="estimatedRevenue")]
        public double? EstimatedRevenue { get; set; }

        /// <summary>
        /// Gets or Sets ExclusionContractID
        /// </summary>
        [DataMember(Name="exclusionContractID")]
        public long? ExclusionContractID { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencyOverageBillingRate
        /// </summary>
        [DataMember(Name="internalCurrencyOverageBillingRate")]
        public double? InternalCurrencyOverageBillingRate { get; set; }

        /// <summary>
        /// Gets or Sets InternalCurrencySetupFee
        /// </summary>
        [DataMember(Name="internalCurrencySetupFee")]
        public double? InternalCurrencySetupFee { get; set; }

        /// <summary>
        /// Gets or Sets IsCompliant
        /// </summary>
        [DataMember(Name="isCompliant")]
        public bool? IsCompliant { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultContract
        /// </summary>
        [DataMember(Name="isDefaultContract")]
        public bool? IsDefaultContract { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityID
        /// </summary>
        [DataMember(Name="opportunityID")]
        public int? OpportunityID { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationalLevelAssociationID
        /// </summary>
        [DataMember(Name="organizationalLevelAssociationID")]
        public int? OrganizationalLevelAssociationID { get; set; }

        /// <summary>
        /// Gets or Sets OverageBillingRate
        /// </summary>
        [DataMember(Name="overageBillingRate")]
        public double? OverageBillingRate { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets RenewedContractID
        /// </summary>
        [DataMember(Name="renewedContractID")]
        public long? RenewedContractID { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelAgreementID
        /// </summary>
        [DataMember(Name="serviceLevelAgreementID")]
        public int? ServiceLevelAgreementID { get; set; }

        /// <summary>
        /// Gets or Sets SetupFee
        /// </summary>
        [DataMember(Name="setupFee")]
        public double? SetupFee { get; set; }

        /// <summary>
        /// Gets or Sets SetupFeeBillingCodeID
        /// </summary>
        [DataMember(Name="setupFeeBillingCodeID")]
        public long? SetupFeeBillingCodeID { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets TimeReportingRequiresStartAndStopTimes
        /// </summary>
        [DataMember(Name="timeReportingRequiresStartAndStopTimes")]
        public int? TimeReportingRequiresStartAndStopTimes { get; set; }

        /// <summary>
        /// Gets or Sets UserDefinedFields
        /// </summary>
        [DataMember(Name="userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BillingPreference: ").Append(BillingPreference).Append("\n");
            sb.Append("  BillToCompanyContactID: ").Append(BillToCompanyContactID).Append("\n");
            sb.Append("  BillToCompanyID: ").Append(BillToCompanyID).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContractCategory: ").Append(ContractCategory).Append("\n");
            sb.Append("  ContractExclusionSetID: ").Append(ContractExclusionSetID).Append("\n");
            sb.Append("  ContractName: ").Append(ContractName).Append("\n");
            sb.Append("  ContractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  ContractPeriodType: ").Append(ContractPeriodType).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EstimatedCost: ").Append(EstimatedCost).Append("\n");
            sb.Append("  EstimatedHours: ").Append(EstimatedHours).Append("\n");
            sb.Append("  EstimatedRevenue: ").Append(EstimatedRevenue).Append("\n");
            sb.Append("  ExclusionContractID: ").Append(ExclusionContractID).Append("\n");
            sb.Append("  InternalCurrencyOverageBillingRate: ").Append(InternalCurrencyOverageBillingRate).Append("\n");
            sb.Append("  InternalCurrencySetupFee: ").Append(InternalCurrencySetupFee).Append("\n");
            sb.Append("  IsCompliant: ").Append(IsCompliant).Append("\n");
            sb.Append("  IsDefaultContract: ").Append(IsDefaultContract).Append("\n");
            sb.Append("  OpportunityID: ").Append(OpportunityID).Append("\n");
            sb.Append("  OrganizationalLevelAssociationID: ").Append(OrganizationalLevelAssociationID).Append("\n");
            sb.Append("  OverageBillingRate: ").Append(OverageBillingRate).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  RenewedContractID: ").Append(RenewedContractID).Append("\n");
            sb.Append("  ServiceLevelAgreementID: ").Append(ServiceLevelAgreementID).Append("\n");
            sb.Append("  SetupFee: ").Append(SetupFee).Append("\n");
            sb.Append("  SetupFeeBillingCodeID: ").Append(SetupFeeBillingCodeID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TimeReportingRequiresStartAndStopTimes: ").Append(TimeReportingRequiresStartAndStopTimes).Append("\n");
            sb.Append("  UserDefinedFields: ").Append(UserDefinedFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ContractModel)obj);
        }

        /// <summary>
        /// Returns true if ContractModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    BillingPreference == other.BillingPreference ||
                    BillingPreference != null &&
                    BillingPreference.Equals(other.BillingPreference)
                ) && 
                (
                    BillToCompanyContactID == other.BillToCompanyContactID ||
                    BillToCompanyContactID != null &&
                    BillToCompanyContactID.Equals(other.BillToCompanyContactID)
                ) && 
                (
                    BillToCompanyID == other.BillToCompanyID ||
                    BillToCompanyID != null &&
                    BillToCompanyID.Equals(other.BillToCompanyID)
                ) && 
                (
                    CompanyID == other.CompanyID ||
                    CompanyID != null &&
                    CompanyID.Equals(other.CompanyID)
                ) && 
                (
                    ContactID == other.ContactID ||
                    ContactID != null &&
                    ContactID.Equals(other.ContactID)
                ) && 
                (
                    ContactName == other.ContactName ||
                    ContactName != null &&
                    ContactName.Equals(other.ContactName)
                ) && 
                (
                    ContractCategory == other.ContractCategory ||
                    ContractCategory != null &&
                    ContractCategory.Equals(other.ContractCategory)
                ) && 
                (
                    ContractExclusionSetID == other.ContractExclusionSetID ||
                    ContractExclusionSetID != null &&
                    ContractExclusionSetID.Equals(other.ContractExclusionSetID)
                ) && 
                (
                    ContractName == other.ContractName ||
                    ContractName != null &&
                    ContractName.Equals(other.ContractName)
                ) && 
                (
                    ContractNumber == other.ContractNumber ||
                    ContractNumber != null &&
                    ContractNumber.Equals(other.ContractNumber)
                ) && 
                (
                    ContractPeriodType == other.ContractPeriodType ||
                    ContractPeriodType != null &&
                    ContractPeriodType.Equals(other.ContractPeriodType)
                ) && 
                (
                    ContractType == other.ContractType ||
                    ContractType != null &&
                    ContractType.Equals(other.ContractType)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    EstimatedCost == other.EstimatedCost ||
                    EstimatedCost != null &&
                    EstimatedCost.Equals(other.EstimatedCost)
                ) && 
                (
                    EstimatedHours == other.EstimatedHours ||
                    EstimatedHours != null &&
                    EstimatedHours.Equals(other.EstimatedHours)
                ) && 
                (
                    EstimatedRevenue == other.EstimatedRevenue ||
                    EstimatedRevenue != null &&
                    EstimatedRevenue.Equals(other.EstimatedRevenue)
                ) && 
                (
                    ExclusionContractID == other.ExclusionContractID ||
                    ExclusionContractID != null &&
                    ExclusionContractID.Equals(other.ExclusionContractID)
                ) && 
                (
                    InternalCurrencyOverageBillingRate == other.InternalCurrencyOverageBillingRate ||
                    InternalCurrencyOverageBillingRate != null &&
                    InternalCurrencyOverageBillingRate.Equals(other.InternalCurrencyOverageBillingRate)
                ) && 
                (
                    InternalCurrencySetupFee == other.InternalCurrencySetupFee ||
                    InternalCurrencySetupFee != null &&
                    InternalCurrencySetupFee.Equals(other.InternalCurrencySetupFee)
                ) && 
                (
                    IsCompliant == other.IsCompliant ||
                    IsCompliant != null &&
                    IsCompliant.Equals(other.IsCompliant)
                ) && 
                (
                    IsDefaultContract == other.IsDefaultContract ||
                    IsDefaultContract != null &&
                    IsDefaultContract.Equals(other.IsDefaultContract)
                ) && 
                (
                    OpportunityID == other.OpportunityID ||
                    OpportunityID != null &&
                    OpportunityID.Equals(other.OpportunityID)
                ) && 
                (
                    OrganizationalLevelAssociationID == other.OrganizationalLevelAssociationID ||
                    OrganizationalLevelAssociationID != null &&
                    OrganizationalLevelAssociationID.Equals(other.OrganizationalLevelAssociationID)
                ) && 
                (
                    OverageBillingRate == other.OverageBillingRate ||
                    OverageBillingRate != null &&
                    OverageBillingRate.Equals(other.OverageBillingRate)
                ) && 
                (
                    PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    PurchaseOrderNumber != null &&
                    PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
                ) && 
                (
                    RenewedContractID == other.RenewedContractID ||
                    RenewedContractID != null &&
                    RenewedContractID.Equals(other.RenewedContractID)
                ) && 
                (
                    ServiceLevelAgreementID == other.ServiceLevelAgreementID ||
                    ServiceLevelAgreementID != null &&
                    ServiceLevelAgreementID.Equals(other.ServiceLevelAgreementID)
                ) && 
                (
                    SetupFee == other.SetupFee ||
                    SetupFee != null &&
                    SetupFee.Equals(other.SetupFee)
                ) && 
                (
                    SetupFeeBillingCodeID == other.SetupFeeBillingCodeID ||
                    SetupFeeBillingCodeID != null &&
                    SetupFeeBillingCodeID.Equals(other.SetupFeeBillingCodeID)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    TimeReportingRequiresStartAndStopTimes == other.TimeReportingRequiresStartAndStopTimes ||
                    TimeReportingRequiresStartAndStopTimes != null &&
                    TimeReportingRequiresStartAndStopTimes.Equals(other.TimeReportingRequiresStartAndStopTimes)
                ) && 
                (
                    UserDefinedFields == other.UserDefinedFields ||
                    UserDefinedFields != null &&
                    UserDefinedFields.SequenceEqual(other.UserDefinedFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (BillingPreference != null)
                    hashCode = hashCode * 59 + BillingPreference.GetHashCode();
                    if (BillToCompanyContactID != null)
                    hashCode = hashCode * 59 + BillToCompanyContactID.GetHashCode();
                    if (BillToCompanyID != null)
                    hashCode = hashCode * 59 + BillToCompanyID.GetHashCode();
                    if (CompanyID != null)
                    hashCode = hashCode * 59 + CompanyID.GetHashCode();
                    if (ContactID != null)
                    hashCode = hashCode * 59 + ContactID.GetHashCode();
                    if (ContactName != null)
                    hashCode = hashCode * 59 + ContactName.GetHashCode();
                    if (ContractCategory != null)
                    hashCode = hashCode * 59 + ContractCategory.GetHashCode();
                    if (ContractExclusionSetID != null)
                    hashCode = hashCode * 59 + ContractExclusionSetID.GetHashCode();
                    if (ContractName != null)
                    hashCode = hashCode * 59 + ContractName.GetHashCode();
                    if (ContractNumber != null)
                    hashCode = hashCode * 59 + ContractNumber.GetHashCode();
                    if (ContractPeriodType != null)
                    hashCode = hashCode * 59 + ContractPeriodType.GetHashCode();
                    if (ContractType != null)
                    hashCode = hashCode * 59 + ContractType.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (EstimatedCost != null)
                    hashCode = hashCode * 59 + EstimatedCost.GetHashCode();
                    if (EstimatedHours != null)
                    hashCode = hashCode * 59 + EstimatedHours.GetHashCode();
                    if (EstimatedRevenue != null)
                    hashCode = hashCode * 59 + EstimatedRevenue.GetHashCode();
                    if (ExclusionContractID != null)
                    hashCode = hashCode * 59 + ExclusionContractID.GetHashCode();
                    if (InternalCurrencyOverageBillingRate != null)
                    hashCode = hashCode * 59 + InternalCurrencyOverageBillingRate.GetHashCode();
                    if (InternalCurrencySetupFee != null)
                    hashCode = hashCode * 59 + InternalCurrencySetupFee.GetHashCode();
                    if (IsCompliant != null)
                    hashCode = hashCode * 59 + IsCompliant.GetHashCode();
                    if (IsDefaultContract != null)
                    hashCode = hashCode * 59 + IsDefaultContract.GetHashCode();
                    if (OpportunityID != null)
                    hashCode = hashCode * 59 + OpportunityID.GetHashCode();
                    if (OrganizationalLevelAssociationID != null)
                    hashCode = hashCode * 59 + OrganizationalLevelAssociationID.GetHashCode();
                    if (OverageBillingRate != null)
                    hashCode = hashCode * 59 + OverageBillingRate.GetHashCode();
                    if (PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + PurchaseOrderNumber.GetHashCode();
                    if (RenewedContractID != null)
                    hashCode = hashCode * 59 + RenewedContractID.GetHashCode();
                    if (ServiceLevelAgreementID != null)
                    hashCode = hashCode * 59 + ServiceLevelAgreementID.GetHashCode();
                    if (SetupFee != null)
                    hashCode = hashCode * 59 + SetupFee.GetHashCode();
                    if (SetupFeeBillingCodeID != null)
                    hashCode = hashCode * 59 + SetupFeeBillingCodeID.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (TimeReportingRequiresStartAndStopTimes != null)
                    hashCode = hashCode * 59 + TimeReportingRequiresStartAndStopTimes.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContractModel left, ContractModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContractModel left, ContractModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
