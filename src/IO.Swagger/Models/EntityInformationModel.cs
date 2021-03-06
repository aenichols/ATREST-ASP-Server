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
    public partial class EntityInformationModel : IEquatable<EntityInformationModel>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets CanCreate
        /// </summary>
        [DataMember(Name="canCreate")]
        public bool? CanCreate { get; private set; }

        /// <summary>
        /// Gets or Sets CanDelete
        /// </summary>
        [DataMember(Name="canDelete")]
        public bool? CanDelete { get; private set; }

        /// <summary>
        /// Gets or Sets CanQuery
        /// </summary>
        [DataMember(Name="canQuery")]
        public bool? CanQuery { get; private set; }

        /// <summary>
        /// Gets or Sets CanUpdate
        /// </summary>
        [DataMember(Name="canUpdate")]
        public bool? CanUpdate { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForCreate
        /// </summary>
        [DataMember(Name="userAccessForCreate")]
        public RestUserAccessLevel UserAccessForCreate { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForDelete
        /// </summary>
        [DataMember(Name="userAccessForDelete")]
        public RestUserAccessLevel UserAccessForDelete { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForQuery
        /// </summary>
        [DataMember(Name="userAccessForQuery")]
        public RestUserAccessLevel UserAccessForQuery { get; private set; }

        /// <summary>
        /// Gets or Sets UserAccessForUpdate
        /// </summary>
        [DataMember(Name="userAccessForUpdate")]
        public RestUserAccessLevel UserAccessForUpdate { get; private set; }

        /// <summary>
        /// Gets or Sets HasUserDefinedFields
        /// </summary>
        [DataMember(Name="hasUserDefinedFields")]
        public bool? HasUserDefinedFields { get; private set; }

        /// <summary>
        /// Gets or Sets SupportsWebhookCallouts
        /// </summary>
        [DataMember(Name="supportsWebhookCallouts")]
        public bool? SupportsWebhookCallouts { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityInformationModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CanCreate: ").Append(CanCreate).Append("\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  CanQuery: ").Append(CanQuery).Append("\n");
            sb.Append("  CanUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  UserAccessForCreate: ").Append(UserAccessForCreate).Append("\n");
            sb.Append("  UserAccessForDelete: ").Append(UserAccessForDelete).Append("\n");
            sb.Append("  UserAccessForQuery: ").Append(UserAccessForQuery).Append("\n");
            sb.Append("  UserAccessForUpdate: ").Append(UserAccessForUpdate).Append("\n");
            sb.Append("  HasUserDefinedFields: ").Append(HasUserDefinedFields).Append("\n");
            sb.Append("  SupportsWebhookCallouts: ").Append(SupportsWebhookCallouts).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EntityInformationModel)obj);
        }

        /// <summary>
        /// Returns true if EntityInformationModel instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityInformationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityInformationModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    CanCreate == other.CanCreate ||
                    CanCreate != null &&
                    CanCreate.Equals(other.CanCreate)
                ) && 
                (
                    CanDelete == other.CanDelete ||
                    CanDelete != null &&
                    CanDelete.Equals(other.CanDelete)
                ) && 
                (
                    CanQuery == other.CanQuery ||
                    CanQuery != null &&
                    CanQuery.Equals(other.CanQuery)
                ) && 
                (
                    CanUpdate == other.CanUpdate ||
                    CanUpdate != null &&
                    CanUpdate.Equals(other.CanUpdate)
                ) && 
                (
                    UserAccessForCreate == other.UserAccessForCreate ||
                    UserAccessForCreate != null &&
                    UserAccessForCreate.Equals(other.UserAccessForCreate)
                ) && 
                (
                    UserAccessForDelete == other.UserAccessForDelete ||
                    UserAccessForDelete != null &&
                    UserAccessForDelete.Equals(other.UserAccessForDelete)
                ) && 
                (
                    UserAccessForQuery == other.UserAccessForQuery ||
                    UserAccessForQuery != null &&
                    UserAccessForQuery.Equals(other.UserAccessForQuery)
                ) && 
                (
                    UserAccessForUpdate == other.UserAccessForUpdate ||
                    UserAccessForUpdate != null &&
                    UserAccessForUpdate.Equals(other.UserAccessForUpdate)
                ) && 
                (
                    HasUserDefinedFields == other.HasUserDefinedFields ||
                    HasUserDefinedFields != null &&
                    HasUserDefinedFields.Equals(other.HasUserDefinedFields)
                ) && 
                (
                    SupportsWebhookCallouts == other.SupportsWebhookCallouts ||
                    SupportsWebhookCallouts != null &&
                    SupportsWebhookCallouts.Equals(other.SupportsWebhookCallouts)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (CanCreate != null)
                    hashCode = hashCode * 59 + CanCreate.GetHashCode();
                    if (CanDelete != null)
                    hashCode = hashCode * 59 + CanDelete.GetHashCode();
                    if (CanQuery != null)
                    hashCode = hashCode * 59 + CanQuery.GetHashCode();
                    if (CanUpdate != null)
                    hashCode = hashCode * 59 + CanUpdate.GetHashCode();
                    if (UserAccessForCreate != null)
                    hashCode = hashCode * 59 + UserAccessForCreate.GetHashCode();
                    if (UserAccessForDelete != null)
                    hashCode = hashCode * 59 + UserAccessForDelete.GetHashCode();
                    if (UserAccessForQuery != null)
                    hashCode = hashCode * 59 + UserAccessForQuery.GetHashCode();
                    if (UserAccessForUpdate != null)
                    hashCode = hashCode * 59 + UserAccessForUpdate.GetHashCode();
                    if (HasUserDefinedFields != null)
                    hashCode = hashCode * 59 + HasUserDefinedFields.GetHashCode();
                    if (SupportsWebhookCallouts != null)
                    hashCode = hashCode * 59 + SupportsWebhookCallouts.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EntityInformationModel left, EntityInformationModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EntityInformationModel left, EntityInformationModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
