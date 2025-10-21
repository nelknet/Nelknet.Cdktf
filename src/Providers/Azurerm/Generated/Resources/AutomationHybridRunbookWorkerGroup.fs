namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group">azurerm_automation_hybrid_runbook_worker_group</a>.
    /// </summary>
    type AutomationHybridRunbookWorkerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationHybridRunbookWorkerGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationHybridRunbookWorkerGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationHybridRunbookWorkerGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationHybridRunbookWorkerGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#automation_account_name-1">AutomationHybridRunbookWorkerGroup#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationHybridRunbookWorkerGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationHybridRunbookWorkerGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#name-1">AutomationHybridRunbookWorkerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#resource_group_name-1">AutomationHybridRunbookWorkerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#credential_name-1">AutomationHybridRunbookWorkerGroup#credential_name</a>.
        /// </summary>
        [<CustomOperation "credential_name">]
        member _.CredentialName(state: AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CredentialName <- value)
            state : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#id-1">AutomationHybridRunbookWorkerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker_group#timeouts-1">AutomationHybridRunbookWorkerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroupTimeouts) : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationHybridRunbookWorkerGroupState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationHybridRunbookWorkerGroupState<Present, Present, Present>) : azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroup =
            let config = azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationHybridRunbookWorkerGroup: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationHybridRunbookWorkerGroupState<_, _, _>) : azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroup =
            Unchecked.defaultof<azurerm.AutomationHybridRunbookWorkerGroup.AutomationHybridRunbookWorkerGroup>
