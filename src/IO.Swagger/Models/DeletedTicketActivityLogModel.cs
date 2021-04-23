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
    public partial class DeletedTicketActivityLogModel : IEquatable<DeletedTicketActivityLogModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets TypeID
        /// </summary>
        [DataMember(Name="typeID")]
        public int? TypeID { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID")]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name="ticketNumber")]
        public string TicketNumber { get; set; }

        /// <summary>
        /// Gets or Sets NoteOrAttachmentTitle
        /// </summary>
        [DataMember(Name="noteOrAttachmentTitle")]
        public string NoteOrAttachmentTitle { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByResourceID
        /// </summary>
        [DataMember(Name="createdByResourceID")]
        public int? CreatedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets ActivityDateTime
        /// </summary>
        [DataMember(Name="activityDateTime")]
        public DateTime? ActivityDateTime { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="startDateTime")]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets HoursWorked
        /// </summary>
        [DataMember(Name="hoursWorked")]
        public double? HoursWorked { get; set; }

        /// <summary>
        /// Gets or Sets DeletedByResourceID
        /// </summary>
        [DataMember(Name="deletedByResourceID")]
        public int? DeletedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets DeletedDateTime
        /// </summary>
        [DataMember(Name="deletedDateTime")]
        public DateTime? DeletedDateTime { get; set; }

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
            sb.Append("class DeletedTicketActivityLogModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TypeID: ").Append(TypeID).Append("\n");
            sb.Append("  TicketID: ").Append(TicketID).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  NoteOrAttachmentTitle: ").Append(NoteOrAttachmentTitle).Append("\n");
            sb.Append("  CreatedByResourceID: ").Append(CreatedByResourceID).Append("\n");
            sb.Append("  ActivityDateTime: ").Append(ActivityDateTime).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  HoursWorked: ").Append(HoursWorked).Append("\n");
            sb.Append("  DeletedByResourceID: ").Append(DeletedByResourceID).Append("\n");
            sb.Append("  DeletedDateTime: ").Append(DeletedDateTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DeletedTicketActivityLogModel)obj);
        }

        /// <summary>
        /// Returns true if DeletedTicketActivityLogModel instances are equal
        /// </summary>
        /// <param name="other">Instance of DeletedTicketActivityLogModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletedTicketActivityLogModel other)
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
                    TypeID == other.TypeID ||
                    TypeID != null &&
                    TypeID.Equals(other.TypeID)
                ) && 
                (
                    TicketID == other.TicketID ||
                    TicketID != null &&
                    TicketID.Equals(other.TicketID)
                ) && 
                (
                    TicketNumber == other.TicketNumber ||
                    TicketNumber != null &&
                    TicketNumber.Equals(other.TicketNumber)
                ) && 
                (
                    NoteOrAttachmentTitle == other.NoteOrAttachmentTitle ||
                    NoteOrAttachmentTitle != null &&
                    NoteOrAttachmentTitle.Equals(other.NoteOrAttachmentTitle)
                ) && 
                (
                    CreatedByResourceID == other.CreatedByResourceID ||
                    CreatedByResourceID != null &&
                    CreatedByResourceID.Equals(other.CreatedByResourceID)
                ) && 
                (
                    ActivityDateTime == other.ActivityDateTime ||
                    ActivityDateTime != null &&
                    ActivityDateTime.Equals(other.ActivityDateTime)
                ) && 
                (
                    StartDateTime == other.StartDateTime ||
                    StartDateTime != null &&
                    StartDateTime.Equals(other.StartDateTime)
                ) && 
                (
                    EndDateTime == other.EndDateTime ||
                    EndDateTime != null &&
                    EndDateTime.Equals(other.EndDateTime)
                ) && 
                (
                    HoursWorked == other.HoursWorked ||
                    HoursWorked != null &&
                    HoursWorked.Equals(other.HoursWorked)
                ) && 
                (
                    DeletedByResourceID == other.DeletedByResourceID ||
                    DeletedByResourceID != null &&
                    DeletedByResourceID.Equals(other.DeletedByResourceID)
                ) && 
                (
                    DeletedDateTime == other.DeletedDateTime ||
                    DeletedDateTime != null &&
                    DeletedDateTime.Equals(other.DeletedDateTime)
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
                    if (TypeID != null)
                    hashCode = hashCode * 59 + TypeID.GetHashCode();
                    if (TicketID != null)
                    hashCode = hashCode * 59 + TicketID.GetHashCode();
                    if (TicketNumber != null)
                    hashCode = hashCode * 59 + TicketNumber.GetHashCode();
                    if (NoteOrAttachmentTitle != null)
                    hashCode = hashCode * 59 + NoteOrAttachmentTitle.GetHashCode();
                    if (CreatedByResourceID != null)
                    hashCode = hashCode * 59 + CreatedByResourceID.GetHashCode();
                    if (ActivityDateTime != null)
                    hashCode = hashCode * 59 + ActivityDateTime.GetHashCode();
                    if (StartDateTime != null)
                    hashCode = hashCode * 59 + StartDateTime.GetHashCode();
                    if (EndDateTime != null)
                    hashCode = hashCode * 59 + EndDateTime.GetHashCode();
                    if (HoursWorked != null)
                    hashCode = hashCode * 59 + HoursWorked.GetHashCode();
                    if (DeletedByResourceID != null)
                    hashCode = hashCode * 59 + DeletedByResourceID.GetHashCode();
                    if (DeletedDateTime != null)
                    hashCode = hashCode * 59 + DeletedDateTime.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DeletedTicketActivityLogModel left, DeletedTicketActivityLogModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeletedTicketActivityLogModel left, DeletedTicketActivityLogModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
