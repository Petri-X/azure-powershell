// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.PowerShell;

    /// <summary>Mapping of user object ID to role assignments.</summary>
    [System.ComponentModel.TypeConverter(typeof(UserRoleAssignmentValueTypeConverter))]
    public partial class UserRoleAssignmentValue
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValue" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValue DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserRoleAssignmentValue(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValue" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValue DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UserRoleAssignmentValue(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserRoleAssignmentValue" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UserRoleAssignmentValue" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValue FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserRoleAssignmentValue(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValueInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentRoles) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValueInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentRolesTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UserRoleAssignmentValue(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValueInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentRoles) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IUserRoleAssignmentValueInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.UserRoleAssignmentRolesTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Mapping of user object ID to role assignments.
    [System.ComponentModel.TypeConverter(typeof(UserRoleAssignmentValueTypeConverter))]
    public partial interface IUserRoleAssignmentValue

    {

    }
}