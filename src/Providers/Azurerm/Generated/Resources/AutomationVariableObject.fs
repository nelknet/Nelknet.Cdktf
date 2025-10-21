namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationVariableObject.AutomationVariableObjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object">azurerm_automation_variable_object</a>.
    /// </summary>
    type AutomationVariableObjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationVariableObjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableObjectState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationVariableObjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableObjectState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#automation_account_name-1">AutomationVariableObject#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationVariableObjectState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableObjectState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationVariableObjectState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#name-1">AutomationVariableObject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationVariableObjectState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationVariableObjectState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationVariableObjectState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#resource_group_name-1">AutomationVariableObject#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationVariableObjectState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationVariableObjectState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#description-1">AutomationVariableObject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#encrypted-1">AutomationVariableObject#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#encrypted-1">AutomationVariableObject#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#id-1">AutomationVariableObject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#timeouts-1">AutomationVariableObject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationVariableObject.AutomationVariableObjectTimeouts) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_object#value-1">AutomationVariableObject#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationVariableObjectState<Present, Present, Present>) : azurerm.AutomationVariableObject.AutomationVariableObject =
            let config = azurerm.AutomationVariableObject.AutomationVariableObjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationVariableObject.AutomationVariableObject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationVariableObject: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationVariableObjectState<_, _, _>) : azurerm.AutomationVariableObject.AutomationVariableObject =
            Unchecked.defaultof<azurerm.AutomationVariableObject.AutomationVariableObject>
