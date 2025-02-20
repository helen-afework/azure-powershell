// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the desired size of the pool. This can either be &#39;fixedScale&#39; where
    /// the requested targetDedicatedNodes is specified, or &#39;autoScale&#39; which
    /// defines a formula which is periodically reevaluated. If this property is
    /// not specified, the pool will have a fixed scale with 0
    /// targetDedicatedNodes.
    /// </summary>
    /// <remarks>
    /// Defines the desired size of the pool. This can either be &#39;fixedScale&#39; where
    /// the requested targetDedicatedNodes is specified, or &#39;autoScale&#39; which
    /// defines a formula which is periodically reevaluated. If this property is
    /// not specified, the pool will have a fixed scale with 0
    /// targetDedicatedNodes.
    /// </remarks>
    public partial class ScaleSettings
    {
        /// <summary>
        /// Initializes a new instance of the ScaleSettings class.
        /// </summary>
        public ScaleSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleSettings class.
        /// </summary>

        /// <param name="fixedScale">This property and autoScale are mutually exclusive and one of the
        /// properties must be specified.
        /// </param>

        /// <param name="autoScale">This property and fixedScale are mutually exclusive and one of the
        /// properties must be specified.
        /// </param>
        public ScaleSettings(FixedScaleSettings fixedScale = default(FixedScaleSettings), AutoScaleSettings autoScale = default(AutoScaleSettings))

        {
            this.FixedScale = fixedScale;
            this.AutoScale = autoScale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets this property and autoScale are mutually exclusive and one of
        /// the properties must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fixedScale")]
        public FixedScaleSettings FixedScale {get; set; }

        /// <summary>
        /// Gets or sets this property and fixedScale are mutually exclusive and one of
        /// the properties must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoScale")]
        public AutoScaleSettings AutoScale {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.AutoScale != null)
            {
                this.AutoScale.Validate();
            }
        }
    }
}