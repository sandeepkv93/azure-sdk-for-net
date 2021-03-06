// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ClientDiscoveryForServiceSpecification
    /// </summary>
    /// <remarks>
    /// Class to represent shoebox service specification in json client
    /// discovery.
    /// </remarks>
    public partial class ClientDiscoveryForServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ClientDiscoveryForServiceSpecification class.
        /// </summary>
        public ClientDiscoveryForServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ClientDiscoveryForServiceSpecification class.
        /// </summary>
        /// <param name="logSpecifications">List of log specifications of this
        /// operation.</param>
        public ClientDiscoveryForServiceSpecification(IList<ClientDiscoveryForLogSpecification> logSpecifications = default(IList<ClientDiscoveryForLogSpecification>))
        {
            LogSpecifications = logSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of log specifications of this operation.
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<ClientDiscoveryForLogSpecification> LogSpecifications { get; set; }

    }
}
