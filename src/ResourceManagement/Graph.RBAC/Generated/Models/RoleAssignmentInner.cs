// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role Assignments
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleAssignmentInner
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignmentInner class.
        /// </summary>
        public RoleAssignmentInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignmentInner class.
        /// </summary>
        /// <param name="id">The role assignment ID.</param>
        /// <param name="name">The role assignment name.</param>
        /// <param name="type">The role assignment type.</param>
        /// <param name="scope">The role assignment scope.</param>
        /// <param name="roleDefinitionId">The role definition ID.</param>
        /// <param name="principalId">The principal ID.</param>
        /// <param name="canDelegate">The Delegation flag for the
        /// roleassignment</param>
        public RoleAssignmentInner(string id = default(string), string name = default(string), string type = default(string), string scope = default(string), string roleDefinitionId = default(string), string principalId = default(string), bool? canDelegate = default(bool?))
        {
            Id = id;
            Name = name;
            Type = type;
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            CanDelegate = canDelegate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the role assignment ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the role assignment name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the role assignment type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the role assignment scope.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the role definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the Delegation flag for the roleassignment
        /// </summary>
        [JsonProperty(PropertyName = "properties.canDelegate")]
        public bool? CanDelegate { get; set; }

    }
}
