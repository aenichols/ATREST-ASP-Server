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
    public partial class TaskSecondaryResourceModel : IEquatable<TaskSecondaryResourceModel>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name="resourceID")]
        public int? ResourceID { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name="roleID")]
        public int? RoleID { get; set; }

        /// <summary>
        /// Gets or Sets TaskID
        /// </summary>
        [DataMember(Name="taskID")]
        public int? TaskID { get; set; }

        /// <summary>
        /// Gets or Sets SoapParentPropertyId
        /// </summary>
        [DataMember(Name="soapParentPropertyId")]
        public ExpressionFuncTaskSecondaryResourceInt64 SoapParentPropertyId { get; private set; }

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
            sb.Append("class TaskSecondaryResourceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
            sb.Append("  TaskID: ").Append(TaskID).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TaskSecondaryResourceModel)obj);
        }

        /// <summary>
        /// Returns true if TaskSecondaryResourceModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskSecondaryResourceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSecondaryResourceModel other)
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
                    ResourceID == other.ResourceID ||
                    ResourceID != null &&
                    ResourceID.Equals(other.ResourceID)
                ) && 
                (
                    RoleID == other.RoleID ||
                    RoleID != null &&
                    RoleID.Equals(other.RoleID)
                ) && 
                (
                    TaskID == other.TaskID ||
                    TaskID != null &&
                    TaskID.Equals(other.TaskID)
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
                    if (ResourceID != null)
                    hashCode = hashCode * 59 + ResourceID.GetHashCode();
                    if (RoleID != null)
                    hashCode = hashCode * 59 + RoleID.GetHashCode();
                    if (TaskID != null)
                    hashCode = hashCode * 59 + TaskID.GetHashCode();
                    if (SoapParentPropertyId != null)
                    hashCode = hashCode * 59 + SoapParentPropertyId.GetHashCode();
                    if (UserDefinedFields != null)
                    hashCode = hashCode * 59 + UserDefinedFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TaskSecondaryResourceModel left, TaskSecondaryResourceModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TaskSecondaryResourceModel left, TaskSecondaryResourceModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
