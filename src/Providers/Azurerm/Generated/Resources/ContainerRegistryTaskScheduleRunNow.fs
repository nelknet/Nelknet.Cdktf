namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId> = { assignments: ResizeArray<azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now">azurerm_container_registry_task_schedule_run_now</a>.
    /// </summary>
    type ContainerRegistryTaskScheduleRunNowBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryTaskScheduleRunNowState<Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTaskScheduleRunNowState<Missing>)

        member _.Zero(()) : ContainerRegistryTaskScheduleRunNowState<Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTaskScheduleRunNowState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#container_registry_task_id-1">ContainerRegistryTaskScheduleRunNow#container_registry_task_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_task_id">]
        member _.ContainerRegistryTaskId(state: ContainerRegistryTaskScheduleRunNowState<Missing>, value: string) : ContainerRegistryTaskScheduleRunNowState<Present> =
            state.assignments.Add(fun config -> config.ContainerRegistryTaskId <- value)
            ({ assignments = state.assignments } : ContainerRegistryTaskScheduleRunNowState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#id-1">ContainerRegistryTaskScheduleRunNow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId>, value: string) : ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task_schedule_run_now#timeouts-1">ContainerRegistryTaskScheduleRunNow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId>, value: azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNowTimeouts) : ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryTaskScheduleRunNowState<'ContainerRegistryTaskId>

        member _.Run(state: ContainerRegistryTaskScheduleRunNowState<Present>) : azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNow =
            let config = azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNowConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryTaskScheduleRunNow: missing required arguments. Must call: container_registry_task_id.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryTaskScheduleRunNowState<_>) : azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNow =
            Unchecked.defaultof<azurerm.ContainerRegistryTaskScheduleRunNow.ContainerRegistryTaskScheduleRunNow>
