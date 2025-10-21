namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId> = { assignments: ResizeArray<azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorkerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker">azurerm_automation_hybrid_runbook_worker</a>.
    /// </summary>
    type AutomationHybridRunbookWorkerBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationHybridRunbookWorkerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationHybridRunbookWorkerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationHybridRunbookWorkerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationHybridRunbookWorkerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#automation_account_name-1">AutomationHybridRunbookWorker#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationHybridRunbookWorkerState<Missing, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>, value: string) : AutomationHybridRunbookWorkerState<Present, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerState<Present, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#resource_group_name-1">AutomationHybridRunbookWorker#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, Missing, 'VmResourceId, 'WorkerGroupName, 'WorkerId>, value: string) : AutomationHybridRunbookWorkerState<'AutomationAccountName, Present, 'VmResourceId, 'WorkerGroupName, 'WorkerId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerState<'AutomationAccountName, Present, 'VmResourceId, 'WorkerGroupName, 'WorkerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#vm_resource_id-1">AutomationHybridRunbookWorker#vm_resource_id</a>.
        /// </summary>
        [<CustomOperation "vm_resource_id">]
        member _.VmResourceId(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, Missing, 'WorkerGroupName, 'WorkerId>, value: string) : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, Present, 'WorkerGroupName, 'WorkerId> =
            state.assignments.Add(fun config -> config.VmResourceId <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, Present, 'WorkerGroupName, 'WorkerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#worker_group_name-1">AutomationHybridRunbookWorker#worker_group_name</a>.
        /// </summary>
        [<CustomOperation "worker_group_name">]
        member _.WorkerGroupName(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, Missing, 'WorkerId>, value: string) : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, Present, 'WorkerId> =
            state.assignments.Add(fun config -> config.WorkerGroupName <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, Present, 'WorkerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#worker_id-1">AutomationHybridRunbookWorker#worker_id</a>.
        /// </summary>
        [<CustomOperation "worker_id">]
        member _.WorkerId(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, Missing>, value: string) : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkerId <- value)
            ({ assignments = state.assignments } : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#id-1">AutomationHybridRunbookWorker#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>, value: string) : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_hybrid_runbook_worker#timeouts-1">AutomationHybridRunbookWorker#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>, value: azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorkerTimeouts) : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationHybridRunbookWorkerState<'AutomationAccountName, 'ResourceGroupName, 'VmResourceId, 'WorkerGroupName, 'WorkerId>

        member _.Run(state: AutomationHybridRunbookWorkerState<Present, Present, Present, Present, Present>) : azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorker =
            let config = azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorkerConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorker(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationHybridRunbookWorker: missing required arguments. Must call: automation_account_name, resource_group_name, vm_resource_id, worker_group_name, worker_id.", 9999, IsError = true)>]
        member _.Run(_: AutomationHybridRunbookWorkerState<_, _, _, _, _>) : azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorker =
            Unchecked.defaultof<azurerm.AutomationHybridRunbookWorker.AutomationHybridRunbookWorker>
