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

    /// <summary>
    /// Exception thrown for an invalid response with GraphError information.
    /// </summary>
    public partial class GraphErrorException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public GraphError Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the GraphErrorException class.
        /// </summary>
        public GraphErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public GraphErrorException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public GraphErrorException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
