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
    public partial class QueryActionResultAppointmentModelAppointment : IEquatable<QueryActionResultAppointmentModelAppointment>
    { 
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items")]
        public List<AppointmentModel> Items { get; set; }

        /// <summary>
        /// Gets or Sets PageDetails
        /// </summary>
        [DataMember(Name="pageDetails")]
        public PagingModel PageDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryActionResultAppointmentModelAppointment {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PageDetails: ").Append(PageDetails).Append("\n");
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
            return obj.GetType() == GetType() && Equals((QueryActionResultAppointmentModelAppointment)obj);
        }

        /// <summary>
        /// Returns true if QueryActionResultAppointmentModelAppointment instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryActionResultAppointmentModelAppointment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryActionResultAppointmentModelAppointment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Items == other.Items ||
                    Items != null &&
                    Items.SequenceEqual(other.Items)
                ) && 
                (
                    PageDetails == other.PageDetails ||
                    PageDetails != null &&
                    PageDetails.Equals(other.PageDetails)
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
                    if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                    if (PageDetails != null)
                    hashCode = hashCode * 59 + PageDetails.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(QueryActionResultAppointmentModelAppointment left, QueryActionResultAppointmentModelAppointment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(QueryActionResultAppointmentModelAppointment left, QueryActionResultAppointmentModelAppointment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
