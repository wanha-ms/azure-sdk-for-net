// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// P2S Vpn connection detailed health written to sas url.
    /// </summary>
    public partial class P2SVpnConnectionHealth
    {
        /// <summary>
        /// Initializes a new instance of the P2SVpnConnectionHealth class.
        /// </summary>
        public P2SVpnConnectionHealth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SVpnConnectionHealth class.
        /// </summary>
        /// <param name="sasUrl">Returned sas url of the blob to which the p2s
        /// vpn connection detailed health will be written. </param>
        public P2SVpnConnectionHealth(string sasUrl = default(string))
        {
            SasUrl = sasUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returned sas url of the blob to which the p2s vpn
        /// connection detailed health will be written.
        /// </summary>
        [JsonProperty(PropertyName = "sasUrl")]
        public string SasUrl { get; set; }

    }
}
