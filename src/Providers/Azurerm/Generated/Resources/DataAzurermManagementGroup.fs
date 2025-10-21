namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermManagementGroupState = { assignments: ResizeArray<azurerm.DataAzurermManagementGroup.DataAzurermManagementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group">azurerm_management_group</a>.
    /// </summary>
    type DataAzurermManagementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermManagementGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermManagementGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#display_name-1">DataAzurermManagementGroup#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermManagementGroupState, value: string) : DataAzurermManagementGroupState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#id-1">DataAzurermManagementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermManagementGroupState, value: string) : DataAzurermManagementGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#name-1">DataAzurermManagementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermManagementGroupState, value: string) : DataAzurermManagementGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermManagementGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group#timeouts-1">DataAzurermManagementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermManagementGroupState, value: azurerm.DataAzurermManagementGroup.DataAzurermManagementGroupTimeouts) : DataAzurermManagementGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermManagementGroupState

        member _.Run(state: DataAzurermManagementGroupState) : azurerm.DataAzurermManagementGroup.DataAzurermManagementGroup =
            let config = azurerm.DataAzurermManagementGroup.DataAzurermManagementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermManagementGroup.DataAzurermManagementGroup(StackContext.get (), logicalId, config)
