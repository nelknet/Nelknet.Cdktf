namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema">azurerm_logic_app_integration_account_schema</a>.
    /// </summary>
    type LogicAppIntegrationAccountSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountSchemaState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountSchemaState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#content-1">LogicAppIntegrationAccountSchema#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: LogicAppIntegrationAccountSchemaState<Missing, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSchemaState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#integration_account_name-1">LogicAppIntegrationAccountSchema#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountSchemaState<'Content, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSchemaState<'Content, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#name-1">LogicAppIntegrationAccountSchema#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#resource_group_name-1">LogicAppIntegrationAccountSchema#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#file_name-1">LogicAppIntegrationAccountSchema#file_name</a>.
        /// </summary>
        [<CustomOperation "file_name">]
        member _.FileName(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FileName <- value)
            state : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#id-1">LogicAppIntegrationAccountSchema#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#metadata-1">LogicAppIntegrationAccountSchema#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_schema#timeouts-1">LogicAppIntegrationAccountSchema#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchemaTimeouts) : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountSchemaState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountSchemaState<Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchema =
            let config = azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchemaConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountSchema: missing required arguments. Must call: content, integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountSchemaState<_, _, _, _>) : azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchema =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountSchema.LogicAppIntegrationAccountSchema>
