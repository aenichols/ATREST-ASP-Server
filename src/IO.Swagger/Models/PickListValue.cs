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
    public partial class PickListValue : IEquatable<PickListValue>
    { 
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultValue
        /// </summary>
        [DataMember(Name="isDefaultValue")]
        public bool? IsDefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets ParentValue
        /// </summary>
        [DataMember(Name="parentValue")]
        public string ParentValue { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name="isSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PickListValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  IsDefaultValue: ").Append(IsDefaultValue).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  ParentValue: ").Append(ParentValue).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PickListValue)obj);
        }

        /// <summary>
        /// Returns true if PickListValue instances are equal
        /// </summary>
        /// <param name="other">Instance of PickListValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PickListValue other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    IsDefaultValue == other.IsDefaultValue ||
                    IsDefaultValue != null &&
                    IsDefaultValue.Equals(other.IsDefaultValue)
                ) && 
                (
                    SortOrder == other.SortOrder ||
                    SortOrder != null &&
                    SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    ParentValue == other.ParentValue ||
                    ParentValue != null &&
                    ParentValue.Equals(other.ParentValue)
                ) && 
                (
                    IsActive == other.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    IsSystem == other.IsSystem ||
                    IsSystem != null &&
                    IsSystem.Equals(other.IsSystem)
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (IsDefaultValue != null)
                    hashCode = hashCode * 59 + IsDefaultValue.GetHashCode();
                    if (SortOrder != null)
                    hashCode = hashCode * 59 + SortOrder.GetHashCode();
                    if (ParentValue != null)
                    hashCode = hashCode * 59 + ParentValue.GetHashCode();
                    if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (IsSystem != null)
                    hashCode = hashCode * 59 + IsSystem.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PickListValue left, PickListValue right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PickListValue left, PickListValue right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
