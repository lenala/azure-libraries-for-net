// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ConnectionStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ConnectionStatus>))]
    public class ConnectionStatus : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ConnectionStatus>
    {
        public static readonly ConnectionStatus Unknown = Parse("Unknown");
        public static readonly ConnectionStatus Connected = Parse("Connected");
        public static readonly ConnectionStatus Disconnected = Parse("Disconnected");
        public static readonly ConnectionStatus Degraded = Parse("Degraded");
    }
}
