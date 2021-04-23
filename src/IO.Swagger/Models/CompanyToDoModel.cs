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
    public partial class CompanyToDoModel : IEquatable<CompanyToDoModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType")]
        public int? ActionType { get; set; }

        /// <summary>
        /// Gets or Sets ActivityDescription
        /// </summary>
        [DataMember(Name="activityDescription")]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// Gets or Sets AssignedToResourceID
        /// </summary>
        [DataMember(Name="assignedToResourceID")]
        public long? AssignedToResourceID { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID")]
        public long? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name="completedDate")]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="contactID")]
        public long? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets ContractID
        /// </summary>
        [DataMember(Name="contractID")]
        public long? ContractID { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name="createDateTime")]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID")]
        public long? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ImpersonatorCreatorResourceID
        /// </summary>
        [DataMember(Name="impersonatorCreatorResourceID")]
        public int? ImpersonatorCreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name="lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityID
        /// </summary>
        [DataMember(Name="opportunityID")]
        public long? OpportunityID { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="startDateTime")]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID")]
        public long? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncAccountToDoInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class CompanyToDoModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  ActivityDescription: ").Append(ActivityDescription).Append("\n");
            sb.Append("  AssignedToResourceID: ").Append(AssignedToResourceID).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  ContractID: ").Append(ContractID).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  ImpersonatorCreatorResourceID: ").Append(ImpersonatorCreatorResourceID).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  OpportunityID: ").Append(OpportunityID).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  SoapParentPropertyId: ").Append(SoapParentPropertyId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CompanyToDoModel)obj);
        }

        /// <summary>
        /// Returns true if CompanyToDoModel instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyToDoModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyToDoModel other)
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
                    ActionType == other.ActionType ||
                    ActionType != null &&
                    ActionType.Equals(other.ActionType)
                ) && 
                (
                    ActivityDescription == other.ActivityDescription ||
                    ActivityDescription != null &&
                    ActivityDescription.Equals(other.ActivityDescription)
                ) && 
                (
                    AssignedToResourceID == other.AssignedToResourceID ||
                    AssignedToResourceID != null &&
                    AssignedToResourceID.Equals(other.AssignedToResourceID)
                ) && 
                (
                    CompanyID == other.CompanyID ||
                    CompanyID != null &&
                    CompanyID.Equals(other.CompanyID)
                ) && 
                (
                    CompletedDate == other.CompletedDate ||
                    CompletedDate != null &&
                    CompletedDate.Equals(other.CompletedDate)
                ) && 
                (
                    ContactID == other.ContactID ||
                    ContactID != null &&
                    ContactID.Equals(other.ContactID)
                ) && 
                (
                    ContractID == other.ContractID ||
                    ContractID != null &&
                    ContractID.Equals(other.ContractID)
                ) && 
                (
                    CreateDateTime == other.CreateDateTime ||
                    CreateDateTime != null &&
                    CreateDateTime.Equals(other.CreateDateTime)
                ) && 
                (
                    CreatorResourceID == other.CreatorResourceID ||
                    CreatorResourceID != null &&
                    CreatorResourceID.Equals(other.CreatorResourceID)
                ) && 
                (
                    EndDateTime == other.EndDateTime ||
                    EndDateTime != null &&
                    EndDateTime.Equals(other.EndDateTime)
                ) && 
                (
                    ImpersonatorCreatorResourceID == other.ImpersonatorCreatorResourceID ||
                    ImpersonatorCreatorResourceID != null &&
                    ImpersonatorCreatorResourceID.Equals(other.ImpersonatorCreatorResourceID)
                ) && 
                (
                    LastModifiedDate == other.LastModifiedDate ||
                    LastModifiedDate != null &&
                    LastModifiedDate.Equals(other.LastModifiedDate)
                ) && 
                (
                    OpportunityID == other.OpportunityID ||
                    OpportunityID != null &&
                    OpportunityID.Equals(other.OpportunityID)
                ) && 
                (
                    StartDateTime == other.StartDateTime ||
                    StartDateTime != null &&
                    StartDateTime.Equals(other.StartDateTime)
                ) && 
                (
                    TicketID == other.TicketID ||
                    TicketID != null &&
                    TicketID.Equals(other.TicketID)
                ) && 
                (
                    SoapParentPropertyId == other.SoapParentPropertyId ||
                    SoapParentPropertyId != null &&
                    SoapParentPropertyId.Equals(other.SoapParentPropertyId)
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
                    if (ActionType != null)
                    hashCode = hashCode * 59 + ActionType.GetHashCode();
                    if (ActivityDescription != null)
                    hashCode = hashCode * 59 + ActivityDescription.GetHashCode();
                    if (AssignedToResourceID != null)
                    hashCode = hashCode * 59 + AssignedToResourceID.GetHashCode();
                    if (CompanyID != null)
                    hashCode = hashCode * 59 + CompanyID.GetHashCode();
                    if (CompletedDate != null)
                    hashCode = hashCode * 59 + CompletedDate.GetHashCode();
                    if (ContactID != null)
                    hashCode = hashCode * 59 + ContactID.GetHashCode();
                    if (ContractID != null)
                    hashCode = hashCode * 59 + ContractID.GetHashCode();
                    if (CreateDateTime != null)
                    hashCode = hashCode * 59 + CreateDateTime.GetHashCode();
                    if (CreatorResourceID != null)
                    hashCode = hashCode * 59 + CreatorResourceID.GetHashCode();
                    if (EndDateTime != null)
                    hashCode = hashCode * 59 + EndDateTime.GetHashCode();
                    if (ImpersonatorCreatorResourceID != null)
                    hashCode = hashCode * 59 + ImpersonatorCreatorResourceID.GetHashCode();
                    if (LastModifiedDate != null)
                    hashCode = hashCode * 59 + LastModifiedDate.GetHashCode();
                    if (OpportunityID != null)
                    hashCode = hashCode * 59 + OpportunityID.GetHashCode();
                    if (StartDateTime != null)
                    hashCode = hashCode * 59 + StartDateTime.GetHashCode();
                    if (TicketID != null)
                    hashCode = hashCode * 59 + TicketID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CompanyToDoModel left, CompanyToDoModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompanyToDoModel left, CompanyToDoModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}