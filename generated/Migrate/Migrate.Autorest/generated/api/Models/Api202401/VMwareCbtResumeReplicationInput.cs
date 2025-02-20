// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt specific resume replication input.</summary>
    public partial class VMwareCbtResumeReplicationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtResumeReplicationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtResumeReplicationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInput __resumeReplicationProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ResumeReplicationProviderSpecificInput();

        /// <summary>Backing field for <see cref="DeleteMigrationResource" /> property.</summary>
        private string _deleteMigrationResource;

        /// <summary>A value indicating whether Migration resources to be deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DeleteMigrationResource { get => this._deleteMigrationResource; set => this._deleteMigrationResource = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInputInternal)__resumeReplicationProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInputInternal)__resumeReplicationProviderSpecificInput).InstanceType = value ; }

        /// <summary>Creates an new <see cref="VMwareCbtResumeReplicationInput" /> instance.</summary>
        public VMwareCbtResumeReplicationInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resumeReplicationProviderSpecificInput), __resumeReplicationProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__resumeReplicationProviderSpecificInput), __resumeReplicationProviderSpecificInput);
        }
    }
    /// VMwareCbt specific resume replication input.
    public partial interface IVMwareCbtResumeReplicationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInput
    {
        /// <summary>A value indicating whether Migration resources to be deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether Migration resources to be deleted.",
        SerializedName = @"deleteMigrationResources",
        PossibleTypes = new [] { typeof(string) })]
        string DeleteMigrationResource { get; set; }

    }
    /// VMwareCbt specific resume replication input.
    internal partial interface IVMwareCbtResumeReplicationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IResumeReplicationProviderSpecificInputInternal
    {
        /// <summary>A value indicating whether Migration resources to be deleted.</summary>
        string DeleteMigrationResource { get; set; }

    }
}