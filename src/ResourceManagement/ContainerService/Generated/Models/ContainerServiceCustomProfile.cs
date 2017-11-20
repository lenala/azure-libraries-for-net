// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties to configure a custom container service cluster.
    /// </summary>
    public partial class ContainerServiceCustomProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceCustomProfile
        /// class.
        /// </summary>
        public ContainerServiceCustomProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceCustomProfile
        /// class.
        /// </summary>
        /// <param name="orchestrator">The name of the custom orchestrator to
        /// use.</param>
        public ContainerServiceCustomProfile(string orchestrator)
        {
            Orchestrator = orchestrator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the custom orchestrator to use.
        /// </summary>
        [JsonProperty(PropertyName = "orchestrator")]
        public string Orchestrator { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Orchestrator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Orchestrator");
            }
        }
    }
}
