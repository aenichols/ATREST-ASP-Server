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
    public partial class TicketChecklistItemModel : IEquatable<TicketChecklistItemModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CompletedByResourceID
        /// </summary>
        [DataMember(Name="completedByResourceID")]
        public int? CompletedByResourceID { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDateTime
        /// </summary>
        [DataMember(Name="completedDateTime")]
        public DateTime? CompletedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsCompleted
        /// </summary>
        [DataMember(Name="isCompleted")]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets IsImportant
        /// </summary>
        [DataMember(Name="isImportant")]
        public bool? IsImportant { get; set; }

        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        [DataMember(Name="itemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or Sets KnowledgebaseArticleID
        /// </summary>
        [DataMember(Name="knowledgebaseArticleID")]
        public int? KnowledgebaseArticleID { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position")]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets TicketID
        /// </summary>
        [DataMember(Name="ticketID")]
        public int? TicketID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncTicketChecklistItemInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TicketChecklistItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompletedByResourceID: ").Append(CompletedByResourceID).Append("\n");
            sb.Append("  CompletedDateTime: ").Append(CompletedDateTime).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  IsImportant: ").Append(IsImportant).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  KnowledgebaseArticleID: ").Append(KnowledgebaseArticleID).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TicketChecklistItemModel)obj);
        }

        /// <summary>
        /// Returns true if TicketChecklistItemModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TicketChecklistItemModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketChecklistItemModel other)
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
                    CompletedByResourceID == other.CompletedByResourceID ||
                    CompletedByResourceID != null &&
                    CompletedByResourceID.Equals(other.CompletedByResourceID)
                ) && 
                (
                    CompletedDateTime == other.CompletedDateTime ||
                    CompletedDateTime != null &&
                    CompletedDateTime.Equals(other.CompletedDateTime)
                ) && 
                (
                    IsCompleted == other.IsCompleted ||
                    IsCompleted != null &&
                    IsCompleted.Equals(other.IsCompleted)
                ) && 
                (
                    IsImportant == other.IsImportant ||
                    IsImportant != null &&
                    IsImportant.Equals(other.IsImportant)
                ) && 
                (
                    ItemName == other.ItemName ||
                    ItemName != null &&
                    ItemName.Equals(other.ItemName)
                ) && 
                (
                    KnowledgebaseArticleID == other.KnowledgebaseArticleID ||
                    KnowledgebaseArticleID != null &&
                    KnowledgebaseArticleID.Equals(other.KnowledgebaseArticleID)
                ) && 
                (
                    Position == other.Position ||
                    Position != null &&
                    Position.Equals(other.Position)
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
                    if (CompletedByResourceID != null)
                    hashCode = hashCode * 59 + CompletedByResourceID.GetHashCode();
                    if (CompletedDateTime != null)
                    hashCode = hashCode * 59 + CompletedDateTime.GetHashCode();
                    if (IsCompleted != null)
                    hashCode = hashCode * 59 + IsCompleted.GetHashCode();
                    if (IsImportant != null)
                    hashCode = hashCode * 59 + IsImportant.GetHashCode();
                    if (ItemName != null)
                    hashCode = hashCode * 59 + ItemName.GetHashCode();
                    if (KnowledgebaseArticleID != null)
                    hashCode = hashCode * 59 + KnowledgebaseArticleID.GetHashCode();
                    if (Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();
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

        public static bool operator ==(TicketChecklistItemModel left, TicketChecklistItemModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TicketChecklistItemModel left, TicketChecklistItemModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}