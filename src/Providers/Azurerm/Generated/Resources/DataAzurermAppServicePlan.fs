namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppServicePlanState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan">azurerm_app_service_plan</a>.
    /// </summary>
    type DataAzurermAppServicePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppServicePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServicePlanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppServicePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServicePlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#name-1">DataAzurermAppServicePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAppServicePlanState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAppServicePlanState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAppServicePlanState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#resource_group_name-1">DataAzurermAppServicePlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAppServicePlanState<'Name, Missing>, value: string) : DataAzurermAppServicePlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAppServicePlanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#id-1">DataAzurermAppServicePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppServicePlanState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAppServicePlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppServicePlanState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#timeouts-1">DataAzurermAppServicePlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppServicePlanState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlanTimeouts) : DataAzurermAppServicePlanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppServicePlanState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAppServicePlanState<Present, Present>) : azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlan =
            let config = azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppServicePlan: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppServicePlanState<_, _>) : azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlan =
            Unchecked.defaultof<azurerm.DataAzurermAppServicePlan.DataAzurermAppServicePlan>
