namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration">azurerm_logic_app_integration_account_batch_configuration</a>.
    /// </summary>
    type LogicAppIntegrationAccountBatchConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountBatchConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountBatchConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountBatchConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountBatchConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#batch_group_name-1">LogicAppIntegrationAccountBatchConfiguration#batch_group_name</a>.
        /// </summary>
        [<CustomOperation "batch_group_name">]
        member _.BatchGroupName(state: LogicAppIntegrationAccountBatchConfigurationState<Missing, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountBatchConfigurationState<Present, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BatchGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountBatchConfigurationState<Present, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#integration_account_name-1">LogicAppIntegrationAccountBatchConfiguration#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, Missing, 'Name, 'ReleaseCriteria, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, Present, 'Name, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, Present, 'Name, 'ReleaseCriteria, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#name-1">LogicAppIntegrationAccountBatchConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, Missing, 'ReleaseCriteria, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, Present, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, Present, 'ReleaseCriteria, 'ResourceGroupName>)

        /// <summary>
        /// release_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#release_criteria-1">LogicAppIntegrationAccountBatchConfiguration#release_criteria</a>
        /// </summary>
        [<CustomOperation "release_criteria">]
        member _.ReleaseCriteria(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, Missing, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationReleaseCriteria) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReleaseCriteria <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#resource_group_name-1">LogicAppIntegrationAccountBatchConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, Missing>, value: string) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#id-1">LogicAppIntegrationAccountBatchConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#metadata-1">LogicAppIntegrationAccountBatchConfiguration#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>, value: seq<string * string>) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_batch_configuration#timeouts-1">LogicAppIntegrationAccountBatchConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationTimeouts) : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountBatchConfigurationState<'BatchGroupName, 'IntegrationAccountName, 'Name, 'ReleaseCriteria, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountBatchConfigurationState<Present, Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfiguration =
            let config = azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountBatchConfiguration: missing required arguments. Must call: batch_group_name, integration_account_name, name, release_criteria, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountBatchConfigurationState<_, _, _, _, _>) : azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfiguration =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountBatchConfiguration.LogicAppIntegrationAccountBatchConfiguration>
