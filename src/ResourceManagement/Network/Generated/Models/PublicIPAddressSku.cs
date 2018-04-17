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
    /// SKU of a public IP address
    /// </summary>
    public partial class PublicIPAddressSku
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        public PublicIPAddressSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        /// <param name="name">Name of a public IP address SKU. Possible values
        /// include: 'Basic', 'Standard'</param>
        public PublicIPAddressSku(PublicIPAddressSkuName name = default(PublicIPAddressSkuName))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a public IP address SKU. Possible values
        /// include: 'Basic', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public PublicIPAddressSkuName Name { get; set; }

    }
}
