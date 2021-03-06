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
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedClusterInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterInner class.
        /// </summary>
        public ManagedClusterInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterInner class.
        /// </summary>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="dnsPrefix">DNS prefix specified when creating the
        /// managed cluster.</param>
        /// <param name="fqdn">FDQN for the master pool.</param>
        /// <param name="kubernetesVersion">Version of Kubernetes specified
        /// when creating the managed cluster.</param>
        /// <param name="agentPoolProfiles">Properties of the agent
        /// pool.</param>
        /// <param name="linuxProfile">Profile for Linux VMs in the container
        /// service cluster.</param>
        /// <param name="servicePrincipalProfile">Information about a service
        /// principal identity for the cluster to use for manipulating Azure
        /// APIs. Either secret or keyVaultSecretRef must be specified.</param>
        public ManagedClusterInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string dnsPrefix = default(string), string fqdn = default(string), string kubernetesVersion = default(string), IList<ContainerServiceAgentPoolProfile> agentPoolProfiles = default(IList<ContainerServiceAgentPoolProfile>), ContainerServiceLinuxProfile linuxProfile = default(ContainerServiceLinuxProfile), ContainerServiceServicePrincipalProfile servicePrincipalProfile = default(ContainerServiceServicePrincipalProfile))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
            KubernetesVersion = kubernetesVersion;
            AgentPoolProfiles = agentPoolProfiles;
            LinuxProfile = linuxProfile;
            ServicePrincipalProfile = servicePrincipalProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets DNS prefix specified when creating the managed
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsPrefix")]
        public string DnsPrefix { get; set; }

        /// <summary>
        /// Gets FDQN for the master pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets or sets version of Kubernetes specified when creating the
        /// managed cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets or sets properties of the agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<ContainerServiceAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Gets or sets profile for Linux VMs in the container service
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxProfile")]
        public ContainerServiceLinuxProfile LinuxProfile { get; set; }

        /// <summary>
        /// Gets or sets information about a service principal identity for the
        /// cluster to use for manipulating Azure APIs. Either secret or
        /// keyVaultSecretRef must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePrincipalProfile")]
        public ContainerServiceServicePrincipalProfile ServicePrincipalProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AgentPoolProfiles != null)
            {
                foreach (var element in AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LinuxProfile != null)
            {
                LinuxProfile.Validate();
            }
            if (ServicePrincipalProfile != null)
            {
                ServicePrincipalProfile.Validate();
            }
        }
    }
}
