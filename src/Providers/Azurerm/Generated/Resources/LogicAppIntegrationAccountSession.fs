namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSessionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session">azurerm_logic_app_integration_account_session</a>.
    /// </summary>
    type LogicAppIntegrationAccountSessionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountSessionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountSessionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountSessionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountSessionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#content-1">LogicAppIntegrationAccountSession#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: LogicAppIntegrationAccountSessionState<Missing, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSessionState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSessionState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#integration_account_name-1">LogicAppIntegrationAccountSession#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountSessionState<'Content, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSessionState<'Content, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSessionState<'Content, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#name-1">LogicAppIntegrationAccountSession#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#resource_group_name-1">LogicAppIntegrationAccountSession#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#id-1">LogicAppIntegrationAccountSession#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_session#timeouts-1">LogicAppIntegrationAccountSession#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSessionTimeouts) : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountSessionState<'Content, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountSessionState<Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSession =
            let config = azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSessionConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSession(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountSession: missing required arguments. Must call: content, integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountSessionState<_, _, _, _>) : azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSession =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountSession.LogicAppIntegrationAccountSession>
