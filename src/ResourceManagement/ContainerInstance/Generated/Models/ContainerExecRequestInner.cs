// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The start container exec request.
    /// </summary>
    public partial class ContainerExecRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the ContainerExecRequestInner class.
        /// </summary>
        public ContainerExecRequestInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerExecRequestInner class.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="terminalSize">The size of the terminal.</param>
        public ContainerExecRequestInner(string command = default(string), ContainerExecRequestTerminalSize terminalSize = default(ContainerExecRequestTerminalSize))
        {
            Command = command;
            TerminalSize = terminalSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the command to be executed.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets the size of the terminal.
        /// </summary>
        [JsonProperty(PropertyName = "terminalSize")]
        public ContainerExecRequestTerminalSize TerminalSize { get; set; }

    }
}
