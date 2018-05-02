// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reference to a certificate to be installed on compute nodes in a
    /// pool. This must exist inside the same account as the pool.
    /// </summary>
    public partial class CertificateReference
    {
        /// <summary>
        /// Initializes a new instance of the CertificateReference class.
        /// </summary>
        public CertificateReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateReference class.
        /// </summary>
        /// <param name="id">The fully qualified ID of the certificate to
        /// install on the pool. This must be inside the same batch account as
        /// the pool.</param>
        /// <param name="storeLocation">The location of the certificate store
        /// on the compute node into which to install the certificate.</param>
        /// <param name="storeName">The name of the certificate store on the
        /// compute node into which to install the certificate.</param>
        /// <param name="visibility">Which user accounts on the compute node
        /// should have access to the private data of the certificate.</param>
        public CertificateReference(string id, CertificateStoreLocation? storeLocation = default(CertificateStoreLocation?), string storeName = default(string), IList<CertificateVisibility> visibility = default(IList<CertificateVisibility>))
        {
            Id = id;
            StoreLocation = storeLocation;
            StoreName = storeName;
            Visibility = visibility;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified ID of the certificate to install
        /// on the pool. This must be inside the same batch account as the
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the location of the certificate store on the compute
        /// node into which to install the certificate.
        /// </summary>
        /// <remarks>
        /// The default value is currentUser. This property is applicable only
        /// for pools configured with Windows nodes (that is, created with
        /// cloudServiceConfiguration, or with virtualMachineConfiguration
        /// using a Windows image reference). For Linux compute nodes, the
        /// certificates are stored in a directory inside the task working
        /// directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is
        /// supplied to the task to query for this location. For certificates
        /// with visibility of 'remoteUser', a 'certs' directory is created in
        /// the user's home directory (e.g., /home/{user-name}/certs) and
        /// certificates are placed in that directory. Possible values include:
        /// 'CurrentUser', 'LocalMachine'
        /// </remarks>
        [JsonProperty(PropertyName = "storeLocation")]
        public CertificateStoreLocation? StoreLocation { get; set; }

        /// <summary>
        /// Gets or sets the name of the certificate store on the compute node
        /// into which to install the certificate.
        /// </summary>
        /// <remarks>
        /// This property is applicable only for pools configured with Windows
        /// nodes (that is, created with cloudServiceConfiguration, or with
        /// virtualMachineConfiguration using a Windows image reference).
        /// Common store names include: My, Root, CA, Trust, Disallowed,
        /// TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any
        /// custom store name can also be used. The default value is My.
        /// </remarks>
        [JsonProperty(PropertyName = "storeName")]
        public string StoreName { get; set; }

        /// <summary>
        /// Gets or sets which user accounts on the compute node should have
        /// access to the private data of the certificate.
        /// </summary>
        /// <remarks>
        /// Values are:
        ///
        /// starttask - The user account under which the start task is run.
        /// task - The accounts under which job tasks are run.
        /// remoteuser - The accounts under which users remotely access the
        /// node.
        ///
        /// You can specify more than one visibility in this collection. The
        /// default is all accounts.
        /// </remarks>
        [JsonProperty(PropertyName = "visibility")]
        public IList<CertificateVisibility> Visibility { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
