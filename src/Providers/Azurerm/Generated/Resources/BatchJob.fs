namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchJobState<'BatchPoolId, 'Name> = { assignments: ResizeArray<azurerm.BatchJob.BatchJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job">azurerm_batch_job</a>.
    /// </summary>
    type BatchJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobState<Missing, Missing>)

        member _.Zero(()) : BatchJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#batch_pool_id-1">BatchJob#batch_pool_id</a>.
        /// </summary>
        [<CustomOperation "batch_pool_id">]
        member _.BatchPoolId(state: BatchJobState<Missing, 'Name>, value: string) : BatchJobState<Present, 'Name> =
            state.assignments.Add(fun config -> config.BatchPoolId <- value)
            ({ assignments = state.assignments } : BatchJobState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#name-1">BatchJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchJobState<'BatchPoolId, Missing>, value: string) : BatchJobState<'BatchPoolId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchJobState<'BatchPoolId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#common_environment_properties-1">BatchJob#common_environment_properties</a>.
        /// </summary>
        [<CustomOperation "common_environment_properties">]
        member _.CommonEnvironmentProperties(state: BatchJobState<'BatchPoolId, 'Name>, value: seq<string * string>) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.CommonEnvironmentProperties <- dict value)
            state : BatchJobState<'BatchPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#display_name-1">BatchJob#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BatchJobState<'BatchPoolId, 'Name>, value: string) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BatchJobState<'BatchPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#id-1">BatchJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchJobState<'BatchPoolId, 'Name>, value: string) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchJobState<'BatchPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#priority-1">BatchJob#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: BatchJobState<'BatchPoolId, 'Name>, value: double) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : BatchJobState<'BatchPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#task_retry_maximum-1">BatchJob#task_retry_maximum</a>.
        /// </summary>
        [<CustomOperation "task_retry_maximum">]
        member _.TaskRetryMaximum(state: BatchJobState<'BatchPoolId, 'Name>, value: double) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.TaskRetryMaximum <- value)
            state : BatchJobState<'BatchPoolId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_job#timeouts-1">BatchJob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchJobState<'BatchPoolId, 'Name>, value: azurerm.BatchJob.BatchJobTimeouts) : BatchJobState<'BatchPoolId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchJobState<'BatchPoolId, 'Name>

        member _.Run(state: BatchJobState<Present, Present>) : azurerm.BatchJob.BatchJob =
            let config = azurerm.BatchJob.BatchJobConfig()
            for setter in state.assignments do
                setter config
            azurerm.BatchJob.BatchJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.batchJob: missing required arguments. Must call: batch_pool_id, name.", 9999, IsError = true)>]
        member _.Run(_: BatchJobState<_, _>) : azurerm.BatchJob.BatchJob =
            Unchecked.defaultof<azurerm.BatchJob.BatchJob>
