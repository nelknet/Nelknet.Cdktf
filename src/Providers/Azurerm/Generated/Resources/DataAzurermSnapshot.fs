namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSnapshotState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSnapshot.DataAzurermSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot">azurerm_snapshot</a>.
    /// </summary>
    type DataAzurermSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSnapshotState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#name-1">DataAzurermSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSnapshotState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSnapshotState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSnapshotState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#resource_group_name-1">DataAzurermSnapshot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSnapshotState<'Name, Missing>, value: string) : DataAzurermSnapshotState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSnapshotState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#id-1">DataAzurermSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSnapshotState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSnapshotState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSnapshotState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#timeouts-1">DataAzurermSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSnapshotState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSnapshot.DataAzurermSnapshotTimeouts) : DataAzurermSnapshotState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSnapshotState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSnapshotState<Present, Present>) : azurerm.DataAzurermSnapshot.DataAzurermSnapshot =
            let config = azurerm.DataAzurermSnapshot.DataAzurermSnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSnapshot.DataAzurermSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSnapshot: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSnapshotState<_, _>) : azurerm.DataAzurermSnapshot.DataAzurermSnapshot =
            Unchecked.defaultof<azurerm.DataAzurermSnapshot.DataAzurermSnapshot>
