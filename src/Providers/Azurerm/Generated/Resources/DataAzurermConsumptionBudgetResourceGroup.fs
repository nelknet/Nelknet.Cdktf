namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId> = { assignments: ResizeArray<azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_resource_group">azurerm_consumption_budget_resource_group</a>.
    /// </summary>
    type DataAzurermConsumptionBudgetResourceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermConsumptionBudgetResourceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConsumptionBudgetResourceGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermConsumptionBudgetResourceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConsumptionBudgetResourceGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_resource_group#name-1">DataAzurermConsumptionBudgetResourceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermConsumptionBudgetResourceGroupState<Missing, 'ResourceGroupId>, value: string) : DataAzurermConsumptionBudgetResourceGroupState<Present, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermConsumptionBudgetResourceGroupState<Present, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_resource_group#resource_group_id-1">DataAzurermConsumptionBudgetResourceGroup#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: DataAzurermConsumptionBudgetResourceGroupState<'Name, Missing>, value: string) : DataAzurermConsumptionBudgetResourceGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : DataAzurermConsumptionBudgetResourceGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_resource_group#id-1">DataAzurermConsumptionBudgetResourceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId>, value: string) : DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_resource_group#timeouts-1">DataAzurermConsumptionBudgetResourceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId>, value: azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroupTimeouts) : DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermConsumptionBudgetResourceGroupState<'Name, 'ResourceGroupId>

        member _.Run(state: DataAzurermConsumptionBudgetResourceGroupState<Present, Present>) : azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroup =
            let config = azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermConsumptionBudgetResourceGroup: missing required arguments. Must call: name, resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermConsumptionBudgetResourceGroupState<_, _>) : azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroup =
            Unchecked.defaultof<azurerm.DataAzurermConsumptionBudgetResourceGroup.DataAzurermConsumptionBudgetResourceGroup>
