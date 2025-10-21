namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan">azurerm_network_ddos_protection_plan</a>.
    /// </summary>
    type NetworkDdosProtectionPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkDdosProtectionPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkDdosProtectionPlanState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkDdosProtectionPlanState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkDdosProtectionPlanState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#location-1">NetworkDdosProtectionPlan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkDdosProtectionPlanState<Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkDdosProtectionPlanState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkDdosProtectionPlanState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#name-1">NetworkDdosProtectionPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkDdosProtectionPlanState<'Location, Missing, 'ResourceGroupName>, value: string) : NetworkDdosProtectionPlanState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkDdosProtectionPlanState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#resource_group_name-1">NetworkDdosProtectionPlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkDdosProtectionPlanState<'Location, 'Name, Missing>, value: string) : NetworkDdosProtectionPlanState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkDdosProtectionPlanState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#id-1">NetworkDdosProtectionPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#tags-1">NetworkDdosProtectionPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_ddos_protection_plan#timeouts-1">NetworkDdosProtectionPlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlanTimeouts) : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkDdosProtectionPlanState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkDdosProtectionPlanState<Present, Present, Present>) : azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlan =
            let config = azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkDdosProtectionPlan: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkDdosProtectionPlanState<_, _, _>) : azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlan =
            Unchecked.defaultof<azurerm.NetworkDdosProtectionPlan.NetworkDdosProtectionPlan>
