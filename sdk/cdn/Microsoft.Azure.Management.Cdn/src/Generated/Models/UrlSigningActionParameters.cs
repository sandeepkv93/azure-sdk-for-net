// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the parameters for the Url Signing action.
    /// </summary>
    public partial class UrlSigningActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the UrlSigningActionParameters class.
        /// </summary>
        public UrlSigningActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UrlSigningActionParameters class.
        /// </summary>
        /// <param name="algorithm">Algorithm to use for URL signing. Possible
        /// values include: 'SHA256'</param>
        /// <param name="parameterNameOverride">Defines which query string
        /// parameters in the url to be considered for expires, key id etc.
        /// </param>
        public UrlSigningActionParameters(string algorithm = default(string), IList<UrlSigningParamIdentifier> parameterNameOverride = default(IList<UrlSigningParamIdentifier>))
        {
            Algorithm = algorithm;
            ParameterNameOverride = parameterNameOverride;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UrlSigningActionParameters class.
        /// </summary>
        static UrlSigningActionParameters()
        {
            Odatatype = "#Microsoft.Azure.Cdn.Models.DeliveryRuleUrlSigningActionParameters";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets algorithm to use for URL signing. Possible values
        /// include: 'SHA256'
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// Gets or sets defines which query string parameters in the url to be
        /// considered for expires, key id etc.
        /// </summary>
        [JsonProperty(PropertyName = "parameterNameOverride")]
        public IList<UrlSigningParamIdentifier> ParameterNameOverride { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

    }
}
