namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationConnectionType.AutomationConnectionTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type">azurerm_automation_connection_type</a>.
    /// </summary>
    type AutomationConnectionTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationConnectionTypeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionTypeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationConnectionTypeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionTypeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#automation_account_name-1">AutomationConnectionType#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationConnectionTypeState<Missing, 'Field, 'Name, 'ResourceGroupName>, value: string) : AutomationConnectionTypeState<Present, 'Field, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationConnectionTypeState<Present, 'Field, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// field block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#field-1">AutomationConnectionType#field</a> Accepts: azurerm.IResolvable | azurerm.AutomationConnectionType.AutomationConnectionTypeField[]
        /// </summary>
        [<CustomOperation "field">]
        member _.Field(state: AutomationConnectionTypeState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationConnectionTypeState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Field <- value)
            ({ assignments = state.assignments } : AutomationConnectionTypeState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#name-1">AutomationConnectionType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, Missing, 'ResourceGroupName>, value: string) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationConnectionTypeState<'AutomationAccountName, 'Field, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#resource_group_name-1">AutomationConnectionType#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, Missing>, value: string) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#id-1">AutomationConnectionType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>, value: string) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#is_global-1">AutomationConnectionType#is_global</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_global">]
        member _.IsGlobal(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>, value: bool) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsGlobal <- value)
            state : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#is_global-1">AutomationConnectionType#is_global</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_global">]
        member _.IsGlobal(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsGlobal <- value)
            state : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_type#timeouts-1">AutomationConnectionType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>, value: azurerm.AutomationConnectionType.AutomationConnectionTypeTimeouts) : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationConnectionTypeState<'AutomationAccountName, 'Field, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationConnectionTypeState<Present, Present, Present, Present>) : azurerm.AutomationConnectionType.AutomationConnectionType =
            let config = azurerm.AutomationConnectionType.AutomationConnectionTypeConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationConnectionType.AutomationConnectionType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationConnectionType: missing required arguments. Must call: automation_account_name, field, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationConnectionTypeState<_, _, _, _>) : azurerm.AutomationConnectionType.AutomationConnectionType =
            Unchecked.defaultof<azurerm.AutomationConnectionType.AutomationConnectionType>
