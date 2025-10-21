namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration">azurerm_automation_dsc_nodeconfiguration</a>.
    /// </summary>
    type AutomationDscNodeconfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationDscNodeconfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationDscNodeconfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationDscNodeconfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationDscNodeconfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#automation_account_name-1">AutomationDscNodeconfiguration#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationDscNodeconfigurationState<Missing, 'ContentEmbedded, 'Name, 'ResourceGroupName>, value: string) : AutomationDscNodeconfigurationState<Present, 'ContentEmbedded, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationDscNodeconfigurationState<Present, 'ContentEmbedded, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#content_embedded-1">AutomationDscNodeconfiguration#content_embedded</a>.
        /// </summary>
        [<CustomOperation "content_embedded">]
        member _.ContentEmbedded(state: AutomationDscNodeconfigurationState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationDscNodeconfigurationState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentEmbedded <- value)
            ({ assignments = state.assignments } : AutomationDscNodeconfigurationState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#name-1">AutomationDscNodeconfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, Missing, 'ResourceGroupName>, value: string) : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#resource_group_name-1">AutomationDscNodeconfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, Missing>, value: string) : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#id-1">AutomationDscNodeconfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName>, value: string) : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_nodeconfiguration#timeouts-1">AutomationDscNodeconfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName>, value: azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfigurationTimeouts) : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationDscNodeconfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationDscNodeconfigurationState<Present, Present, Present, Present>) : azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfiguration =
            let config = azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationDscNodeconfiguration: missing required arguments. Must call: automation_account_name, content_embedded, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationDscNodeconfigurationState<_, _, _, _>) : azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfiguration =
            Unchecked.defaultof<azurerm.AutomationDscNodeconfiguration.AutomationDscNodeconfiguration>
