namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy">azurerm_netapp_snapshot_policy</a>.
    /// </summary>
    type DataAzurermNetappSnapshotPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappSnapshotPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappSnapshotPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappSnapshotPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappSnapshotPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#account_name-1">DataAzurermNetappSnapshotPolicy#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermNetappSnapshotPolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappSnapshotPolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotPolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#name-1">DataAzurermNetappSnapshotPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappSnapshotPolicyState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermNetappSnapshotPolicyState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotPolicyState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#resource_group_name-1">DataAzurermNetappSnapshotPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, Missing>, value: string) : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#id-1">DataAzurermNetappSnapshotPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#timeouts-1">DataAzurermNetappSnapshotPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicyTimeouts) : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappSnapshotPolicyState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetappSnapshotPolicyState<Present, Present, Present>) : azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicy =
            let config = azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappSnapshotPolicy: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappSnapshotPolicyState<_, _, _>) : azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicy =
            Unchecked.defaultof<azurerm.DataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicy>
