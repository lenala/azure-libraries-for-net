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
    /// Contains the IpTag associated with the public IP address
    /// </summary>
    public partial class IpTag
    {
        /// <summary>
        /// Initializes a new instance of the IpTag class.
        /// </summary>
        public IpTag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpTag class.
        /// </summary>
        /// <param name="ipTagType">Gets or sets the ipTag type: Example
        /// FirstPartyUsage.</param>
        /// <param name="tag">Gets or sets value of the IpTag associated with
        /// the public IP. Example SQL, Storage etc</param>
        public IpTag(string ipTagType = default(string), string tag = default(string))
        {
            IpTagType = ipTagType;
            Tag = tag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ipTag type: Example FirstPartyUsage.
        /// </summary>
        [JsonProperty(PropertyName = "ipTagType")]
        public string IpTagType { get; set; }

        /// <summary>
        /// Gets or sets value of the IpTag associated with the public IP.
        /// Example SQL, Storage etc
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

    }
}
