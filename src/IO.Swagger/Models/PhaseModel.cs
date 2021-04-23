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
    public partial class PhaseModel : IEquatable<PhaseModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID")]
        public int? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedHours
        /// </summary>
        [DataMember(Name="estimatedHours")]
        public double? EstimatedHours { get; set; }

        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="externalID")]
        public string ExternalID { get; set; }

        /// <summary>
        /// Gets or Sets IsScheduled
        /// </summary>
        [DataMember(Name="isScheduled")]
        public bool? IsScheduled { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityDateTime
        /// </summary>
        [DataMember(Name="lastActivityDateTime")]
        public DateTime? LastActivityDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ParentPhaseID
        /// </summary>
        [DataMember(Name="parentPhaseID")]
        public int? ParentPhaseID { get; set; }

        /// <summary>
        /// Gets or Sets PhaseNumber
        /// </summary>
        [DataMember(Name="phaseNumber")]
        public string PhaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID")]
        public int? ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncPhaseInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class PhaseModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  EstimatedHours: ").Append(EstimatedHours).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  IsScheduled: ").Append(IsScheduled).Append("\n");
            sb.Append("  LastActivityDateTime: ").Append(LastActivityDateTime).Append("\n");
            sb.Append("  ParentPhaseID: ").Append(ParentPhaseID).Append("\n");
            sb.Append("  PhaseNumber: ").Append(PhaseNumber).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PhaseModel)obj);
        }

        /// <summary>
        /// Returns true if PhaseModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PhaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhaseModel other)
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
                    CreateDate == other.CreateDate ||
                    CreateDate != null &&
                    CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    CreatorResourceID == other.CreatorResourceID ||
                    CreatorResourceID != null &&
                    CreatorResourceID.Equals(other.CreatorResourceID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DueDate == other.DueDate ||
                    DueDate != null &&
                    DueDate.Equals(other.DueDate)
                ) && 
                (
                    EstimatedHours == other.EstimatedHours ||
                    EstimatedHours != null &&
                    EstimatedHours.Equals(other.EstimatedHours)
                ) && 
                (
                    ExternalID == other.ExternalID ||
                    ExternalID != null &&
                    ExternalID.Equals(other.ExternalID)
                ) && 
                (
                    IsScheduled == other.IsScheduled ||
                    IsScheduled != null &&
                    IsScheduled.Equals(other.IsScheduled)
                ) && 
                (
                    LastActivityDateTime == other.LastActivityDateTime ||
                    LastActivityDateTime != null &&
                    LastActivityDateTime.Equals(other.LastActivityDateTime)
                ) && 
                (
                    ParentPhaseID == other.ParentPhaseID ||
                    ParentPhaseID != null &&
                    ParentPhaseID.Equals(other.ParentPhaseID)
                ) && 
                (
                    PhaseNumber == other.PhaseNumber ||
                    PhaseNumber != null &&
                    PhaseNumber.Equals(other.PhaseNumber)
                ) && 
                (
                    ProjectID == other.ProjectID ||
                    ProjectID != null &&
                    ProjectID.Equals(other.ProjectID)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
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
                    if (CreateDate != null)
                    hashCode = hashCode * 59 + CreateDate.GetHashCode();
                    if (CreatorResourceID != null)
                    hashCode = hashCode * 59 + CreatorResourceID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DueDate != null)
                    hashCode = hashCode * 59 + DueDate.GetHashCode();
                    if (EstimatedHours != null)
                    hashCode = hashCode * 59 + EstimatedHours.GetHashCode();
                    if (ExternalID != null)
                    hashCode = hashCode * 59 + ExternalID.GetHashCode();
                    if (IsScheduled != null)
                    hashCode = hashCode * 59 + IsScheduled.GetHashCode();
                    if (LastActivityDateTime != null)
                    hashCode = hashCode * 59 + LastActivityDateTime.GetHashCode();
                    if (ParentPhaseID != null)
                    hashCode = hashCode * 59 + ParentPhaseID.GetHashCode();
                    if (PhaseNumber != null)
                    hashCode = hashCode * 59 + PhaseNumber.GetHashCode();
                    if (ProjectID != null)
                    hashCode = hashCode * 59 + ProjectID.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PhaseModel left, PhaseModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PhaseModel left, PhaseModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}