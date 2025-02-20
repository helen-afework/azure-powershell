// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The public IP Address configuration of the networking configuration of a
    /// Pool.
    /// </summary>
    public partial class PublicIPAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressConfiguration class.
        /// </summary>
        public PublicIPAddressConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressConfiguration class.
        /// </summary>

        /// <param name="provision">The default value is BatchManaged
        /// Possible values include: &#39;BatchManaged&#39;, &#39;UserManaged&#39;,
        /// &#39;NoPublicIPAddresses&#39;</param>

        /// <param name="ipAddressIds">The number of IPs specified here limits the maximum size of the Pool - 100
        /// dedicated nodes or 100 Spot/low-priority nodes can be allocated for each
        /// public IP. For example, a pool needing 250 dedicated VMs would need at
        /// least 3 public IPs specified. Each element of this collection is of the
        /// form:
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/Microsoft.Network/publicIPAddresses/{ip}.
        /// </param>
        public PublicIPAddressConfiguration(IPAddressProvisioningType? provision = default(IPAddressProvisioningType?), System.Collections.Generic.IList<string> ipAddressIds = default(System.Collections.Generic.IList<string>))

        {
            this.Provision = provision;
            this.IPAddressIds = ipAddressIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the default value is BatchManaged Possible values include: &#39;BatchManaged&#39;, &#39;UserManaged&#39;, &#39;NoPublicIPAddresses&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provision")]
        public IPAddressProvisioningType? Provision {get; set; }

        /// <summary>
        /// Gets or sets the number of IPs specified here limits the maximum size of
        /// the Pool - 100 dedicated nodes or 100 Spot/low-priority nodes can be
        /// allocated for each public IP. For example, a pool needing 250 dedicated VMs
        /// would need at least 3 public IPs specified. Each element of this collection
        /// is of the form:
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/Microsoft.Network/publicIPAddresses/{ip}.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipAddressIds")]
        public System.Collections.Generic.IList<string> IPAddressIds {get; set; }
    }
}