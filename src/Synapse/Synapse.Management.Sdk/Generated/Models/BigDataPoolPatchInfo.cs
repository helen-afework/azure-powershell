// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Properties patch for a Big Data pool
    /// </summary>
    /// <remarks>
    /// Properties patch for a Big Data pool
    /// </remarks>
    public partial class BigDataPoolPatchInfo
    {
        /// <summary>
        /// Initializes a new instance of the BigDataPoolPatchInfo class.
        /// </summary>
        public BigDataPoolPatchInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BigDataPoolPatchInfo class.
        /// </summary>

        /// <param name="tags">Updated tags for the Big Data pool
        /// </param>
        public BigDataPoolPatchInfo(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets updated tags for the Big Data pool
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }
    }
}