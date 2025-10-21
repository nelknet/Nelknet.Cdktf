namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set">azurerm_disk_encryption_set</a>.
    /// </summary>
    type DataAzurermDiskEncryptionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDiskEncryptionSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDiskEncryptionSetState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDiskEncryptionSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDiskEncryptionSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#name-1">DataAzurermDiskEncryptionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDiskEncryptionSetState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDiskEncryptionSetState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDiskEncryptionSetState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#resource_group_name-1">DataAzurermDiskEncryptionSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDiskEncryptionSetState<'Name, Missing>, value: string) : DataAzurermDiskEncryptionSetState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDiskEncryptionSetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#id-1">DataAzurermDiskEncryptionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#timeouts-1">DataAzurermDiskEncryptionSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetTimeouts) : DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDiskEncryptionSetState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDiskEncryptionSetState<Present, Present>) : azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSet =
            let config = azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDiskEncryptionSet: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDiskEncryptionSetState<_, _>) : azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSet =
            Unchecked.defaultof<azurerm.DataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSet>
