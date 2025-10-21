namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupState = { assignments: ResizeArray<azurerm.ManagementGroup.ManagementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group">azurerm_management_group</a>.
    /// </summary>
    type ManagementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : ManagementGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#display_name-1">ManagementGroup#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ManagementGroupState, value: string) : ManagementGroupState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#id-1">ManagementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupState, value: string) : ManagementGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#name-1">ManagementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementGroupState, value: string) : ManagementGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#parent_management_group_id-1">ManagementGroup#parent_management_group_id</a>.
        /// </summary>
        [<CustomOperation "parent_management_group_id">]
        member _.ParentManagementGroupId(state: ManagementGroupState, value: string) : ManagementGroupState =
            state.assignments.Add(fun config -> config.ParentManagementGroupId <- value)
            state : ManagementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#subscription_ids-1">ManagementGroup#subscription_ids</a>.
        /// </summary>
        [<CustomOperation "subscription_ids">]
        member _.SubscriptionIds(state: ManagementGroupState, value: seq<string>) : ManagementGroupState =
            state.assignments.Add(fun config -> config.SubscriptionIds <- (value |> Seq.toArray))
            state : ManagementGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group#timeouts-1">ManagementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupState, value: azurerm.ManagementGroup.ManagementGroupTimeouts) : ManagementGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupState

        member _.Run(state: ManagementGroupState) : azurerm.ManagementGroup.ManagementGroup =
            let config = azurerm.ManagementGroup.ManagementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroup.ManagementGroup(StackContext.get (), logicalId, config)
