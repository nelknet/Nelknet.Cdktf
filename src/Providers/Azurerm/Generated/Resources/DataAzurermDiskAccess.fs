namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDiskAccessState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDiskAccess.DataAzurermDiskAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access">azurerm_disk_access</a>.
    /// </summary>
    type DataAzurermDiskAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDiskAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDiskAccessState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDiskAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDiskAccessState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#name-1">DataAzurermDiskAccess#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDiskAccessState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDiskAccessState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDiskAccessState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#resource_group_name-1">DataAzurermDiskAccess#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDiskAccessState<'Name, Missing>, value: string) : DataAzurermDiskAccessState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDiskAccessState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#id-1">DataAzurermDiskAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDiskAccessState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDiskAccessState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDiskAccessState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#timeouts-1">DataAzurermDiskAccess#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDiskAccessState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDiskAccess.DataAzurermDiskAccessTimeouts) : DataAzurermDiskAccessState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDiskAccessState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDiskAccessState<Present, Present>) : azurerm.DataAzurermDiskAccess.DataAzurermDiskAccess =
            let config = azurerm.DataAzurermDiskAccess.DataAzurermDiskAccessConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDiskAccess.DataAzurermDiskAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDiskAccess: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDiskAccessState<_, _>) : azurerm.DataAzurermDiskAccess.DataAzurermDiskAccess =
            Unchecked.defaultof<azurerm.DataAzurermDiskAccess.DataAzurermDiskAccess>
