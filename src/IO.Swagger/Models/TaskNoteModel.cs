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
    public partial class TaskNoteModel : IEquatable<TaskNoteModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name="createDateTime")]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatorResourceID
        /// </summary>
        [DataMember(Name="creatorResourceID")]
        public int? CreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByContactID
        /// </summary>
        [DataMember(Name="createdByContactID")]
        public int? CreatedByContactID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ImpersonatorCreatorResourceID
        /// </summary>
        [DataMember(Name="impersonatorCreatorResourceID")]
        public int? ImpersonatorCreatorResourceID { get; set; }

        /// <summary>
        /// Gets or Sets ImpersonatorUpdaterResourceID
        /// </summary>
        [DataMember(Name="impersonatorUpdaterResourceID")]
        public int? ImpersonatorUpdaterResourceID { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityDate
        /// </summary>
        [DataMember(Name="lastActivityDate")]
        public DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Gets or Sets NoteType
        /// </summary>
        [DataMember(Name="noteType")]
        public int? NoteType { get; set; }

        /// <summary>
        /// Gets or Sets Publish
        /// </summary>
        [DataMember(Name="publish")]
        public int? Publish { get; set; }

        /// <summary>
        /// Gets or Sets TaskID
        /// </summary>
        [DataMember(Name="taskID")]
        public int? TaskID { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncTaskNoteInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TaskNoteModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreatorResourceID: ").Append(CreatorResourceID).Append("\n");
            sb.Append("  CreatedByContactID: ").Append(CreatedByContactID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImpersonatorCreatorResourceID: ").Append(ImpersonatorCreatorResourceID).Append("\n");
            sb.Append("  ImpersonatorUpdaterResourceID: ").Append(ImpersonatorUpdaterResourceID).Append("\n");
            sb.Append("  LastActivityDate: ").Append(LastActivityDate).Append("\n");
            sb.Append("  NoteType: ").Append(NoteType).Append("\n");
            sb.Append("  Publish: ").Append(Publish).Append("\n");
            sb.Append("  TaskID: ").Append(TaskID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TaskNoteModel)obj);
        }

        /// <summary>
        /// Returns true if TaskNoteModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskNoteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskNoteModel other)
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
                    CreatedByContactID == other.CreatedByContactID ||
                    CreatedByContactID != null &&
                    CreatedByContactID.Equals(other.CreatedByContactID)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ImpersonatorCreatorResourceID == other.ImpersonatorCreatorResourceID ||
                    ImpersonatorCreatorResourceID != null &&
                    ImpersonatorCreatorResourceID.Equals(other.ImpersonatorCreatorResourceID)
                ) && 
                (
                    ImpersonatorUpdaterResourceID == other.ImpersonatorUpdaterResourceID ||
                    ImpersonatorUpdaterResourceID != null &&
                    ImpersonatorUpdaterResourceID.Equals(other.ImpersonatorUpdaterResourceID)
                ) && 
                (
                    LastActivityDate == other.LastActivityDate ||
                    LastActivityDate != null &&
                    LastActivityDate.Equals(other.LastActivityDate)
                ) && 
                (
                    NoteType == other.NoteType ||
                    NoteType != null &&
                    NoteType.Equals(other.NoteType)
                ) && 
                (
                    Publish == other.Publish ||
                    Publish != null &&
                    Publish.Equals(other.Publish)
                ) && 
                (
                    TaskID == other.TaskID ||
                    TaskID != null &&
                    TaskID.Equals(other.TaskID)
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
                    if (CreateDateTime != null)
                    hashCode = hashCode * 59 + CreateDateTime.GetHashCode();
                    if (CreatorResourceID != null)
                    hashCode = hashCode * 59 + CreatorResourceID.GetHashCode();
                    if (CreatedByContactID != null)
                    hashCode = hashCode * 59 + CreatedByContactID.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ImpersonatorCreatorResourceID != null)
                    hashCode = hashCode * 59 + ImpersonatorCreatorResourceID.GetHashCode();
                    if (ImpersonatorUpdaterResourceID != null)
                    hashCode = hashCode * 59 + ImpersonatorUpdaterResourceID.GetHashCode();
                    if (LastActivityDate != null)
                    hashCode = hashCode * 59 + LastActivityDate.GetHashCode();
                    if (NoteType != null)
                    hashCode = hashCode * 59 + NoteType.GetHashCode();
                    if (Publish != null)
                    hashCode = hashCode * 59 + Publish.GetHashCode();
                    if (TaskID != null)
                    hashCode = hashCode * 59 + TaskID.GetHashCode();
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

        public static bool operator ==(TaskNoteModel left, TaskNoteModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TaskNoteModel left, TaskNoteModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
