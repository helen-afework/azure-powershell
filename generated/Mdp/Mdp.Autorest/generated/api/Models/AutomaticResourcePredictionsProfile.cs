// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Extensions;

    /// <summary>The stand-by agent scheme is determined based on historical demand.</summary>
    public partial class AutomaticResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAutomaticResourcePredictionsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAutomaticResourcePredictionsProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourcePredictionsProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourcePredictionsProfile __resourcePredictionsProfile = new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ResourcePredictionsProfile();

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string Kind { get => "Automatic"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourcePredictionsProfileInternal)__resourcePredictionsProfile).Kind = "Automatic"; }

        /// <summary>Backing field for <see cref="PredictionPreference" /> property.</summary>
        private string _predictionPreference;

        /// <summary>Determines the balance between cost and performance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Owned)]
        public string PredictionPreference { get => this._predictionPreference; set => this._predictionPreference = value; }

        /// <summary>Creates an new <see cref="AutomaticResourcePredictionsProfile" /> instance.</summary>
        public AutomaticResourcePredictionsProfile()
        {
            this.__resourcePredictionsProfile.Kind = "Automatic";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourcePredictionsProfile), __resourcePredictionsProfile);
            await eventListener.AssertObjectIsValid(nameof(__resourcePredictionsProfile), __resourcePredictionsProfile);
        }
    }
    /// The stand-by agent scheme is determined based on historical demand.
    public partial interface IAutomaticResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourcePredictionsProfile
    {
        /// <summary>Determines the balance between cost and performance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines the balance between cost and performance.",
        SerializedName = @"predictionPreference",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("Balanced", "MostCostEffective", "MoreCostEffective", "MorePerformance", "BestPerformance")]
        string PredictionPreference { get; set; }

    }
    /// The stand-by agent scheme is determined based on historical demand.
    internal partial interface IAutomaticResourcePredictionsProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourcePredictionsProfileInternal
    {
        /// <summary>Determines the balance between cost and performance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("Balanced", "MostCostEffective", "MoreCostEffective", "MorePerformance", "BestPerformance")]
        string PredictionPreference { get; set; }

    }
}