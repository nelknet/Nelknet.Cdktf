namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan">azurerm_network_ddos_protection_plan</a>.
    /// </summary>
    type DataAzurermNetworkDdosProtectionPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkDdosProtectionPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkDdosProtectionPlanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkDdosProtectionPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkDdosProtectionPlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan#name-1">DataAzurermNetworkDdosProtectionPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkDdosProtectionPlanState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNetworkDdosProtectionPlanState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkDdosProtectionPlanState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan#resource_group_name-1">DataAzurermNetworkDdosProtectionPlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetworkDdosProtectionPlanState<'Name, Missing>, value: string) : DataAzurermNetworkDdosProtectionPlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkDdosProtectionPlanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan#id-1">DataAzurermNetworkDdosProtectionPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan#timeouts-1">DataAzurermNetworkDdosProtectionPlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlanTimeouts) : DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkDdosProtectionPlanState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetworkDdosProtectionPlanState<Present, Present>) : azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlan =
            let config = azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkDdosProtectionPlan: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkDdosProtectionPlanState<_, _>) : azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlan =
            Unchecked.defaultof<azurerm.DataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlan>
