namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicePlanState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermServicePlan.DataAzurermServicePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/service_plan">azurerm_service_plan</a>.
    /// </summary>
    type DataAzurermServicePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicePlanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermServicePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicePlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/service_plan#name-1">DataAzurermServicePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicePlanState<Missing, 'ResourceGroupName>, value: string) : DataAzurermServicePlanState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicePlanState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/service_plan#resource_group_name-1">DataAzurermServicePlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicePlanState<'Name, Missing>, value: string) : DataAzurermServicePlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermServicePlanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/service_plan#id-1">DataAzurermServicePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicePlanState<'Name, 'ResourceGroupName>, value: string) : DataAzurermServicePlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicePlanState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/service_plan#timeouts-1">DataAzurermServicePlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicePlanState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermServicePlan.DataAzurermServicePlanTimeouts) : DataAzurermServicePlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicePlanState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermServicePlanState<Present, Present>) : azurerm.DataAzurermServicePlan.DataAzurermServicePlan =
            let config = azurerm.DataAzurermServicePlan.DataAzurermServicePlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicePlan.DataAzurermServicePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicePlan: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicePlanState<_, _>) : azurerm.DataAzurermServicePlan.DataAzurermServicePlan =
            Unchecked.defaultof<azurerm.DataAzurermServicePlan.DataAzurermServicePlan>
