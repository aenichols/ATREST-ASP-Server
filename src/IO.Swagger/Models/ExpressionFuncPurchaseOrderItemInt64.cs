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
    public partial class ExpressionFuncPurchaseOrderItemInt64 : IEquatable<ExpressionFuncPurchaseOrderItemInt64>
    { 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NodeTypeEnum
        {
            
            /// <summary>
            /// Enum AddEnum for Add
            /// </summary>
            [EnumMember(Value = "Add")]
            AddEnum = 1,
            
            /// <summary>
            /// Enum AddCheckedEnum for AddChecked
            /// </summary>
            [EnumMember(Value = "AddChecked")]
            AddCheckedEnum = 2,
            
            /// <summary>
            /// Enum AndEnum for And
            /// </summary>
            [EnumMember(Value = "And")]
            AndEnum = 3,
            
            /// <summary>
            /// Enum AndAlsoEnum for AndAlso
            /// </summary>
            [EnumMember(Value = "AndAlso")]
            AndAlsoEnum = 4,
            
            /// <summary>
            /// Enum ArrayLengthEnum for ArrayLength
            /// </summary>
            [EnumMember(Value = "ArrayLength")]
            ArrayLengthEnum = 5,
            
            /// <summary>
            /// Enum ArrayIndexEnum for ArrayIndex
            /// </summary>
            [EnumMember(Value = "ArrayIndex")]
            ArrayIndexEnum = 6,
            
            /// <summary>
            /// Enum CallEnum for Call
            /// </summary>
            [EnumMember(Value = "Call")]
            CallEnum = 7,
            
            /// <summary>
            /// Enum CoalesceEnum for Coalesce
            /// </summary>
            [EnumMember(Value = "Coalesce")]
            CoalesceEnum = 8,
            
            /// <summary>
            /// Enum ConditionalEnum for Conditional
            /// </summary>
            [EnumMember(Value = "Conditional")]
            ConditionalEnum = 9,
            
            /// <summary>
            /// Enum ConstantEnum for Constant
            /// </summary>
            [EnumMember(Value = "Constant")]
            ConstantEnum = 10,
            
            /// <summary>
            /// Enum ConvertEnum for Convert
            /// </summary>
            [EnumMember(Value = "Convert")]
            ConvertEnum = 11,
            
            /// <summary>
            /// Enum ConvertCheckedEnum for ConvertChecked
            /// </summary>
            [EnumMember(Value = "ConvertChecked")]
            ConvertCheckedEnum = 12,
            
            /// <summary>
            /// Enum DivideEnum for Divide
            /// </summary>
            [EnumMember(Value = "Divide")]
            DivideEnum = 13,
            
            /// <summary>
            /// Enum EqualEnum for Equal
            /// </summary>
            [EnumMember(Value = "Equal")]
            EqualEnum = 14,
            
            /// <summary>
            /// Enum ExclusiveOrEnum for ExclusiveOr
            /// </summary>
            [EnumMember(Value = "ExclusiveOr")]
            ExclusiveOrEnum = 15,
            
            /// <summary>
            /// Enum GreaterThanEnum for GreaterThan
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            GreaterThanEnum = 16,
            
            /// <summary>
            /// Enum GreaterThanOrEqualEnum for GreaterThanOrEqual
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqual")]
            GreaterThanOrEqualEnum = 17,
            
            /// <summary>
            /// Enum InvokeEnum for Invoke
            /// </summary>
            [EnumMember(Value = "Invoke")]
            InvokeEnum = 18,
            
            /// <summary>
            /// Enum LambdaEnum for Lambda
            /// </summary>
            [EnumMember(Value = "Lambda")]
            LambdaEnum = 19,
            
            /// <summary>
            /// Enum LeftShiftEnum for LeftShift
            /// </summary>
            [EnumMember(Value = "LeftShift")]
            LeftShiftEnum = 20,
            
            /// <summary>
            /// Enum LessThanEnum for LessThan
            /// </summary>
            [EnumMember(Value = "LessThan")]
            LessThanEnum = 21,
            
            /// <summary>
            /// Enum LessThanOrEqualEnum for LessThanOrEqual
            /// </summary>
            [EnumMember(Value = "LessThanOrEqual")]
            LessThanOrEqualEnum = 22,
            
            /// <summary>
            /// Enum ListInitEnum for ListInit
            /// </summary>
            [EnumMember(Value = "ListInit")]
            ListInitEnum = 23,
            
            /// <summary>
            /// Enum MemberAccessEnum for MemberAccess
            /// </summary>
            [EnumMember(Value = "MemberAccess")]
            MemberAccessEnum = 24,
            
            /// <summary>
            /// Enum MemberInitEnum for MemberInit
            /// </summary>
            [EnumMember(Value = "MemberInit")]
            MemberInitEnum = 25,
            
            /// <summary>
            /// Enum ModuloEnum for Modulo
            /// </summary>
            [EnumMember(Value = "Modulo")]
            ModuloEnum = 26,
            
            /// <summary>
            /// Enum MultiplyEnum for Multiply
            /// </summary>
            [EnumMember(Value = "Multiply")]
            MultiplyEnum = 27,
            
            /// <summary>
            /// Enum MultiplyCheckedEnum for MultiplyChecked
            /// </summary>
            [EnumMember(Value = "MultiplyChecked")]
            MultiplyCheckedEnum = 28,
            
            /// <summary>
            /// Enum NegateEnum for Negate
            /// </summary>
            [EnumMember(Value = "Negate")]
            NegateEnum = 29,
            
            /// <summary>
            /// Enum UnaryPlusEnum for UnaryPlus
            /// </summary>
            [EnumMember(Value = "UnaryPlus")]
            UnaryPlusEnum = 30,
            
            /// <summary>
            /// Enum NegateCheckedEnum for NegateChecked
            /// </summary>
            [EnumMember(Value = "NegateChecked")]
            NegateCheckedEnum = 31,
            
            /// <summary>
            /// Enum NewEnum for New
            /// </summary>
            [EnumMember(Value = "New")]
            NewEnum = 32,
            
            /// <summary>
            /// Enum NewArrayInitEnum for NewArrayInit
            /// </summary>
            [EnumMember(Value = "NewArrayInit")]
            NewArrayInitEnum = 33,
            
            /// <summary>
            /// Enum NewArrayBoundsEnum for NewArrayBounds
            /// </summary>
            [EnumMember(Value = "NewArrayBounds")]
            NewArrayBoundsEnum = 34,
            
            /// <summary>
            /// Enum NotEnum for Not
            /// </summary>
            [EnumMember(Value = "Not")]
            NotEnum = 35,
            
            /// <summary>
            /// Enum NotEqualEnum for NotEqual
            /// </summary>
            [EnumMember(Value = "NotEqual")]
            NotEqualEnum = 36,
            
            /// <summary>
            /// Enum OrEnum for Or
            /// </summary>
            [EnumMember(Value = "Or")]
            OrEnum = 37,
            
            /// <summary>
            /// Enum OrElseEnum for OrElse
            /// </summary>
            [EnumMember(Value = "OrElse")]
            OrElseEnum = 38,
            
            /// <summary>
            /// Enum ParameterEnum for Parameter
            /// </summary>
            [EnumMember(Value = "Parameter")]
            ParameterEnum = 39,
            
            /// <summary>
            /// Enum PowerEnum for Power
            /// </summary>
            [EnumMember(Value = "Power")]
            PowerEnum = 40,
            
            /// <summary>
            /// Enum QuoteEnum for Quote
            /// </summary>
            [EnumMember(Value = "Quote")]
            QuoteEnum = 41,
            
            /// <summary>
            /// Enum RightShiftEnum for RightShift
            /// </summary>
            [EnumMember(Value = "RightShift")]
            RightShiftEnum = 42,
            
            /// <summary>
            /// Enum SubtractEnum for Subtract
            /// </summary>
            [EnumMember(Value = "Subtract")]
            SubtractEnum = 43,
            
            /// <summary>
            /// Enum SubtractCheckedEnum for SubtractChecked
            /// </summary>
            [EnumMember(Value = "SubtractChecked")]
            SubtractCheckedEnum = 44,
            
            /// <summary>
            /// Enum TypeAsEnum for TypeAs
            /// </summary>
            [EnumMember(Value = "TypeAs")]
            TypeAsEnum = 45,
            
            /// <summary>
            /// Enum TypeIsEnum for TypeIs
            /// </summary>
            [EnumMember(Value = "TypeIs")]
            TypeIsEnum = 46,
            
            /// <summary>
            /// Enum AssignEnum for Assign
            /// </summary>
            [EnumMember(Value = "Assign")]
            AssignEnum = 47,
            
            /// <summary>
            /// Enum BlockEnum for Block
            /// </summary>
            [EnumMember(Value = "Block")]
            BlockEnum = 48,
            
            /// <summary>
            /// Enum DebugInfoEnum for DebugInfo
            /// </summary>
            [EnumMember(Value = "DebugInfo")]
            DebugInfoEnum = 49,
            
            /// <summary>
            /// Enum DecrementEnum for Decrement
            /// </summary>
            [EnumMember(Value = "Decrement")]
            DecrementEnum = 50,
            
            /// <summary>
            /// Enum DynamicEnum for Dynamic
            /// </summary>
            [EnumMember(Value = "Dynamic")]
            DynamicEnum = 51,
            
            /// <summary>
            /// Enum DefaultEnum for Default
            /// </summary>
            [EnumMember(Value = "Default")]
            DefaultEnum = 52,
            
            /// <summary>
            /// Enum ExtensionEnum for Extension
            /// </summary>
            [EnumMember(Value = "Extension")]
            ExtensionEnum = 53,
            
            /// <summary>
            /// Enum GotoEnum for Goto
            /// </summary>
            [EnumMember(Value = "Goto")]
            GotoEnum = 54,
            
            /// <summary>
            /// Enum IncrementEnum for Increment
            /// </summary>
            [EnumMember(Value = "Increment")]
            IncrementEnum = 55,
            
            /// <summary>
            /// Enum IndexEnum for Index
            /// </summary>
            [EnumMember(Value = "Index")]
            IndexEnum = 56,
            
            /// <summary>
            /// Enum LabelEnum for Label
            /// </summary>
            [EnumMember(Value = "Label")]
            LabelEnum = 57,
            
            /// <summary>
            /// Enum RuntimeVariablesEnum for RuntimeVariables
            /// </summary>
            [EnumMember(Value = "RuntimeVariables")]
            RuntimeVariablesEnum = 58,
            
            /// <summary>
            /// Enum LoopEnum for Loop
            /// </summary>
            [EnumMember(Value = "Loop")]
            LoopEnum = 59,
            
            /// <summary>
            /// Enum SwitchEnum for Switch
            /// </summary>
            [EnumMember(Value = "Switch")]
            SwitchEnum = 60,
            
            /// <summary>
            /// Enum ThrowEnum for Throw
            /// </summary>
            [EnumMember(Value = "Throw")]
            ThrowEnum = 61,
            
            /// <summary>
            /// Enum TryEnum for Try
            /// </summary>
            [EnumMember(Value = "Try")]
            TryEnum = 62,
            
            /// <summary>
            /// Enum UnboxEnum for Unbox
            /// </summary>
            [EnumMember(Value = "Unbox")]
            UnboxEnum = 63,
            
            /// <summary>
            /// Enum AddAssignEnum for AddAssign
            /// </summary>
            [EnumMember(Value = "AddAssign")]
            AddAssignEnum = 64,
            
            /// <summary>
            /// Enum AndAssignEnum for AndAssign
            /// </summary>
            [EnumMember(Value = "AndAssign")]
            AndAssignEnum = 65,
            
            /// <summary>
            /// Enum DivideAssignEnum for DivideAssign
            /// </summary>
            [EnumMember(Value = "DivideAssign")]
            DivideAssignEnum = 66,
            
            /// <summary>
            /// Enum ExclusiveOrAssignEnum for ExclusiveOrAssign
            /// </summary>
            [EnumMember(Value = "ExclusiveOrAssign")]
            ExclusiveOrAssignEnum = 67,
            
            /// <summary>
            /// Enum LeftShiftAssignEnum for LeftShiftAssign
            /// </summary>
            [EnumMember(Value = "LeftShiftAssign")]
            LeftShiftAssignEnum = 68,
            
            /// <summary>
            /// Enum ModuloAssignEnum for ModuloAssign
            /// </summary>
            [EnumMember(Value = "ModuloAssign")]
            ModuloAssignEnum = 69,
            
            /// <summary>
            /// Enum MultiplyAssignEnum for MultiplyAssign
            /// </summary>
            [EnumMember(Value = "MultiplyAssign")]
            MultiplyAssignEnum = 70,
            
            /// <summary>
            /// Enum OrAssignEnum for OrAssign
            /// </summary>
            [EnumMember(Value = "OrAssign")]
            OrAssignEnum = 71,
            
            /// <summary>
            /// Enum PowerAssignEnum for PowerAssign
            /// </summary>
            [EnumMember(Value = "PowerAssign")]
            PowerAssignEnum = 72,
            
            /// <summary>
            /// Enum RightShiftAssignEnum for RightShiftAssign
            /// </summary>
            [EnumMember(Value = "RightShiftAssign")]
            RightShiftAssignEnum = 73,
            
            /// <summary>
            /// Enum SubtractAssignEnum for SubtractAssign
            /// </summary>
            [EnumMember(Value = "SubtractAssign")]
            SubtractAssignEnum = 74,
            
            /// <summary>
            /// Enum AddAssignCheckedEnum for AddAssignChecked
            /// </summary>
            [EnumMember(Value = "AddAssignChecked")]
            AddAssignCheckedEnum = 75,
            
            /// <summary>
            /// Enum MultiplyAssignCheckedEnum for MultiplyAssignChecked
            /// </summary>
            [EnumMember(Value = "MultiplyAssignChecked")]
            MultiplyAssignCheckedEnum = 76,
            
            /// <summary>
            /// Enum SubtractAssignCheckedEnum for SubtractAssignChecked
            /// </summary>
            [EnumMember(Value = "SubtractAssignChecked")]
            SubtractAssignCheckedEnum = 77,
            
            /// <summary>
            /// Enum PreIncrementAssignEnum for PreIncrementAssign
            /// </summary>
            [EnumMember(Value = "PreIncrementAssign")]
            PreIncrementAssignEnum = 78,
            
            /// <summary>
            /// Enum PreDecrementAssignEnum for PreDecrementAssign
            /// </summary>
            [EnumMember(Value = "PreDecrementAssign")]
            PreDecrementAssignEnum = 79,
            
            /// <summary>
            /// Enum PostIncrementAssignEnum for PostIncrementAssign
            /// </summary>
            [EnumMember(Value = "PostIncrementAssign")]
            PostIncrementAssignEnum = 80,
            
            /// <summary>
            /// Enum PostDecrementAssignEnum for PostDecrementAssign
            /// </summary>
            [EnumMember(Value = "PostDecrementAssign")]
            PostDecrementAssignEnum = 81,
            
            /// <summary>
            /// Enum TypeEqualEnum for TypeEqual
            /// </summary>
            [EnumMember(Value = "TypeEqual")]
            TypeEqualEnum = 82,
            
            /// <summary>
            /// Enum OnesComplementEnum for OnesComplement
            /// </summary>
            [EnumMember(Value = "OnesComplement")]
            OnesComplementEnum = 83,
            
            /// <summary>
            /// Enum IsTrueEnum for IsTrue
            /// </summary>
            [EnumMember(Value = "IsTrue")]
            IsTrueEnum = 84,
            
            /// <summary>
            /// Enum IsFalseEnum for IsFalse
            /// </summary>
            [EnumMember(Value = "IsFalse")]
            IsFalseEnum = 85
        }

        /// <summary>
        /// Gets or Sets NodeType
        /// </summary>
        [DataMember(Name="nodeType")]
        public NodeTypeEnum? NodeType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters")]
        public List<ParameterExpression> Parameters { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body")]
        public Expression Body { get; private set; }

        /// <summary>
        /// Gets or Sets ReturnType
        /// </summary>
        [DataMember(Name="returnType")]
        public string ReturnType { get; private set; }

        /// <summary>
        /// Gets or Sets TailCall
        /// </summary>
        [DataMember(Name="tailCall")]
        public bool? TailCall { get; private set; }

        /// <summary>
        /// Gets or Sets CanReduce
        /// </summary>
        [DataMember(Name="canReduce")]
        public bool? CanReduce { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressionFuncPurchaseOrderItemInt64 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
            sb.Append("  TailCall: ").Append(TailCall).Append("\n");
            sb.Append("  CanReduce: ").Append(CanReduce).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExpressionFuncPurchaseOrderItemInt64)obj);
        }

        /// <summary>
        /// Returns true if ExpressionFuncPurchaseOrderItemInt64 instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpressionFuncPurchaseOrderItemInt64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionFuncPurchaseOrderItemInt64 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    NodeType == other.NodeType ||
                    NodeType != null &&
                    NodeType.Equals(other.NodeType)
                ) && 
                (
                    Parameters == other.Parameters ||
                    Parameters != null &&
                    Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Body == other.Body ||
                    Body != null &&
                    Body.Equals(other.Body)
                ) && 
                (
                    ReturnType == other.ReturnType ||
                    ReturnType != null &&
                    ReturnType.Equals(other.ReturnType)
                ) && 
                (
                    TailCall == other.TailCall ||
                    TailCall != null &&
                    TailCall.Equals(other.TailCall)
                ) && 
                (
                    CanReduce == other.CanReduce ||
                    CanReduce != null &&
                    CanReduce.Equals(other.CanReduce)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (NodeType != null)
                    hashCode = hashCode * 59 + NodeType.GetHashCode();
                    if (Parameters != null)
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                    if (ReturnType != null)
                    hashCode = hashCode * 59 + ReturnType.GetHashCode();
                    if (TailCall != null)
                    hashCode = hashCode * 59 + TailCall.GetHashCode();
                    if (CanReduce != null)
                    hashCode = hashCode * 59 + CanReduce.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExpressionFuncPurchaseOrderItemInt64 left, ExpressionFuncPurchaseOrderItemInt64 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExpressionFuncPurchaseOrderItemInt64 left, ExpressionFuncPurchaseOrderItemInt64 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
