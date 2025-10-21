namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values> = { assignments: ResizeArray<azurerm.AutomationConnection.AutomationConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection">azurerm_automation_connection</a>.
    /// </summary>
    type AutomationConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#automation_account_name-1">AutomationConnection#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationConnectionState<Missing, 'Name, 'ResourceGroupName, 'Type, 'Values>, value: string) : AutomationConnectionState<Present, 'Name, 'ResourceGroupName, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationConnectionState<Present, 'Name, 'ResourceGroupName, 'Type, 'Values>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#name-1">AutomationConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationConnectionState<'AutomationAccountName, Missing, 'ResourceGroupName, 'Type, 'Values>, value: string) : AutomationConnectionState<'AutomationAccountName, Present, 'ResourceGroupName, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationConnectionState<'AutomationAccountName, Present, 'ResourceGroupName, 'Type, 'Values>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#resource_group_name-1">AutomationConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationConnectionState<'AutomationAccountName, 'Name, Missing, 'Type, 'Values>, value: string) : AutomationConnectionState<'AutomationAccountName, 'Name, Present, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationConnectionState<'AutomationAccountName, 'Name, Present, 'Type, 'Values>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#type-1">AutomationConnection#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, Missing, 'Values>, value: string) : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, Present, 'Values> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, Present, 'Values>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#values-1">AutomationConnection#values</a>.
        /// </summary>
        [<CustomOperation "values">]
        member _.Values(state: AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, Missing>, value: seq<string * string>) : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, Present> =
            state.assignments.Add(fun config -> config.Values <- dict value)
            ({ assignments = state.assignments } : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#description-1">AutomationConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>, value: string) : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#id-1">AutomationConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>, value: string) : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection#timeouts-1">AutomationConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>, value: azurerm.AutomationConnection.AutomationConnectionTimeouts) : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationConnectionState<'AutomationAccountName, 'Name, 'ResourceGroupName, 'Type, 'Values>

        member _.Run(state: AutomationConnectionState<Present, Present, Present, Present, Present>) : azurerm.AutomationConnection.AutomationConnection =
            let config = azurerm.AutomationConnection.AutomationConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationConnection.AutomationConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationConnection: missing required arguments. Must call: automation_account_name, name, resource_group_name, type, values.", 9999, IsError = true)>]
        member _.Run(_: AutomationConnectionState<_, _, _, _, _>) : azurerm.AutomationConnection.AutomationConnection =
            Unchecked.defaultof<azurerm.AutomationConnection.AutomationConnection>
