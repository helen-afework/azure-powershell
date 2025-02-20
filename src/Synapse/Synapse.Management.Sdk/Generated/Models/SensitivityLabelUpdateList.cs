// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// A list of sensitivity label update operations.
    /// </summary>
    public partial class SensitivityLabelUpdateList
    {
        /// <summary>
        /// Initializes a new instance of the SensitivityLabelUpdateList class.
        /// </summary>
        public SensitivityLabelUpdateList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SensitivityLabelUpdateList class.
        /// </summary>

        /// <param name="operations">
        /// </param>
        public SensitivityLabelUpdateList(System.Collections.Generic.IList<SensitivityLabelUpdate> operations = default(System.Collections.Generic.IList<SensitivityLabelUpdate>))

        {
            this.Operations = operations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operations")]
        public System.Collections.Generic.IList<SensitivityLabelUpdate> Operations {get; set; }
    }
}