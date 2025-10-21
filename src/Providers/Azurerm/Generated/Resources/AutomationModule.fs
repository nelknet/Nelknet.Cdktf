namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationModule.AutomationModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module">azurerm_automation_module</a>.
    /// </summary>
    type AutomationModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationModuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationModuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationModuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationModuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#automation_account_name-1">AutomationModule#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationModuleState<Missing, 'ModuleLink, 'Name, 'ResourceGroupName>, value: string) : AutomationModuleState<Present, 'ModuleLink, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationModuleState<Present, 'ModuleLink, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// module_link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#module_link-1">AutomationModule#module_link</a>
        /// </summary>
        [<CustomOperation "module_link">]
        member _.ModuleLink(state: AutomationModuleState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: azurerm.AutomationModule.AutomationModuleModuleLink) : AutomationModuleState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ModuleLink <- value)
            ({ assignments = state.assignments } : AutomationModuleState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#name-1">AutomationModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationModuleState<'AutomationAccountName, 'ModuleLink, Missing, 'ResourceGroupName>, value: string) : AutomationModuleState<'AutomationAccountName, 'ModuleLink, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationModuleState<'AutomationAccountName, 'ModuleLink, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#resource_group_name-1">AutomationModule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, Missing>, value: string) : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#id-1">AutomationModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName>, value: string) : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#timeouts-1">AutomationModule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName>, value: azurerm.AutomationModule.AutomationModuleTimeouts) : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationModuleState<'AutomationAccountName, 'ModuleLink, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationModuleState<Present, Present, Present, Present>) : azurerm.AutomationModule.AutomationModule =
            let config = azurerm.AutomationModule.AutomationModuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationModule.AutomationModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationModule: missing required arguments. Must call: automation_account_name, module_link, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationModuleState<_, _, _, _>) : azurerm.AutomationModule.AutomationModule =
            Unchecked.defaultof<azurerm.AutomationModule.AutomationModule>
