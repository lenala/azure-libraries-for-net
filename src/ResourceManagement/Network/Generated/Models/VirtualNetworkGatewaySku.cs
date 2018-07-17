// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VirtualNetworkGatewaySku details
    /// </summary>
    public partial class VirtualNetworkGatewaySku
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        public VirtualNetworkGatewaySku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        /// <param name="name">Gateway SKU name. Possible values include:
        /// 'Basic', 'HighPerformance', 'Standard', 'UltraPerformance',
        /// 'VpnGw1', 'VpnGw2', 'VpnGw3', 'VpnGw1AZ', 'VpnGw2AZ', 'VpnGw3AZ',
        /// 'ErGw1AZ', 'ErGw2AZ', 'ErGw3AZ'</param>
        /// <param name="tier">Gateway SKU tier. Possible values include:
        /// 'Basic', 'HighPerformance', 'Standard', 'UltraPerformance',
        /// 'VpnGw1', 'VpnGw2', 'VpnGw3', 'VpnGw1AZ', 'VpnGw2AZ', 'VpnGw3AZ',
        /// 'ErGw1AZ', 'ErGw2AZ', 'ErGw3AZ'</param>
        /// <param name="capacity">The capacity.</param>
        public VirtualNetworkGatewaySku(VirtualNetworkGatewaySkuName name = default(VirtualNetworkGatewaySkuName), VirtualNetworkGatewaySkuTier tier = default(VirtualNetworkGatewaySkuTier), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gateway SKU name. Possible values include: 'Basic',
        /// 'HighPerformance', 'Standard', 'UltraPerformance', 'VpnGw1',
        /// 'VpnGw2', 'VpnGw3', 'VpnGw1AZ', 'VpnGw2AZ', 'VpnGw3AZ', 'ErGw1AZ',
        /// 'ErGw2AZ', 'ErGw3AZ'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public VirtualNetworkGatewaySkuName Name { get; set; }

        /// <summary>
        /// Gets or sets gateway SKU tier. Possible values include: 'Basic',
        /// 'HighPerformance', 'Standard', 'UltraPerformance', 'VpnGw1',
        /// 'VpnGw2', 'VpnGw3', 'VpnGw1AZ', 'VpnGw2AZ', 'VpnGw3AZ', 'ErGw1AZ',
        /// 'ErGw2AZ', 'ErGw3AZ'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public VirtualNetworkGatewaySkuTier Tier { get; set; }

        /// <summary>
        /// Gets or sets the capacity.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
