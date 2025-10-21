namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name> = { assignments: ResizeArray<azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module">azurerm_automation_powershell72_module</a>.
    /// </summary>
    type AutomationPowershell72ModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationPowershell72ModuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationPowershell72ModuleState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationPowershell72ModuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationPowershell72ModuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#automation_account_id-1">AutomationPowershell72Module#automation_account_id</a>.
        /// </summary>
        [<CustomOperation "automation_account_id">]
        member _.AutomationAccountId(state: AutomationPowershell72ModuleState<Missing, 'ModuleLink, 'Name>, value: string) : AutomationPowershell72ModuleState<Present, 'ModuleLink, 'Name> =
            state.assignments.Add(fun config -> config.AutomationAccountId <- value)
            ({ assignments = state.assignments } : AutomationPowershell72ModuleState<Present, 'ModuleLink, 'Name>)

        /// <summary>
        /// module_link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#module_link-1">AutomationPowershell72Module#module_link</a>
        /// </summary>
        [<CustomOperation "module_link">]
        member _.ModuleLink(state: AutomationPowershell72ModuleState<'AutomationAccountId, Missing, 'Name>, value: azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleModuleLink) : AutomationPowershell72ModuleState<'AutomationAccountId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ModuleLink <- value)
            ({ assignments = state.assignments } : AutomationPowershell72ModuleState<'AutomationAccountId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#name-1">AutomationPowershell72Module#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, Missing>, value: string) : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#id-1">AutomationPowershell72Module#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>, value: string) : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#tags-1">AutomationPowershell72Module#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>, value: seq<string * string>) : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#timeouts-1">AutomationPowershell72Module#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>, value: azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleTimeouts) : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationPowershell72ModuleState<'AutomationAccountId, 'ModuleLink, 'Name>

        member _.Run(state: AutomationPowershell72ModuleState<Present, Present, Present>) : azurerm.AutomationPowershell72Module.AutomationPowershell72Module =
            let config = azurerm.AutomationPowershell72Module.AutomationPowershell72ModuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationPowershell72Module.AutomationPowershell72Module(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationPowershell72Module: missing required arguments. Must call: automation_account_id, module_link, name.", 9999, IsError = true)>]
        member _.Run(_: AutomationPowershell72ModuleState<_, _, _>) : azurerm.AutomationPowershell72Module.AutomationPowershell72Module =
            Unchecked.defaultof<azurerm.AutomationPowershell72Module.AutomationPowershell72Module>
