namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchJobQueueState<'Name, 'Priority, 'State> = { assignments: ResizeArray<aws.BatchJobQueue.BatchJobQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue">aws_batch_job_queue</a>.
    /// </summary>
    type BatchJobQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchJobQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobQueueState<Missing, Missing, Missing>)

        member _.Zero(()) : BatchJobQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobQueueState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#name-1">BatchJobQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchJobQueueState<Missing, 'Priority, 'State>, value: string) : BatchJobQueueState<Present, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchJobQueueState<Present, 'Priority, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#priority-1">BatchJobQueue#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: BatchJobQueueState<'Name, Missing, 'State>, value: double) : BatchJobQueueState<'Name, Present, 'State> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : BatchJobQueueState<'Name, Present, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#state-1">BatchJobQueue#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: BatchJobQueueState<'Name, 'Priority, Missing>, value: string) : BatchJobQueueState<'Name, 'Priority, Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : BatchJobQueueState<'Name, 'Priority, Present>)

        /// <summary>
        /// compute_environment_order block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#compute_environment_order-1">BatchJobQueue#compute_environment_order</a> Accepts: aws.IResolvable | aws.BatchJobQueue.BatchJobQueueComputeEnvironmentOrder[]
        /// </summary>
        [<CustomOperation "compute_environment_order">]
        member _.ComputeEnvironmentOrder(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: HashiCorp.Cdktf.IResolvable) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.ComputeEnvironmentOrder <- value)
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#compute_environments-1">BatchJobQueue#compute_environments</a>.
        /// </summary>
        [<CustomOperation "compute_environments">]
        member _.ComputeEnvironments(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: seq<string>) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.ComputeEnvironments <- (value |> Seq.toArray))
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        /// <summary>
        /// job_state_time_limit_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#job_state_time_limit_action-1">BatchJobQueue#job_state_time_limit_action</a> Accepts: aws.IResolvable | aws.BatchJobQueue.BatchJobQueueJobStateTimeLimitAction[]
        /// </summary>
        [<CustomOperation "job_state_time_limit_action">]
        member _.JobStateTimeLimitAction(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: HashiCorp.Cdktf.IResolvable) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.JobStateTimeLimitAction <- value)
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#scheduling_policy_arn-1">BatchJobQueue#scheduling_policy_arn</a>.
        /// </summary>
        [<CustomOperation "scheduling_policy_arn">]
        member _.SchedulingPolicyArn(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: string) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.SchedulingPolicyArn <- value)
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#tags-1">BatchJobQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: seq<string * string>) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#timeouts-1">BatchJobQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchJobQueueState<'Name, 'Priority, 'State>, value: aws.BatchJobQueue.BatchJobQueueTimeouts) : BatchJobQueueState<'Name, 'Priority, 'State> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchJobQueueState<'Name, 'Priority, 'State>

        member _.Run(state: BatchJobQueueState<Present, Present, Present>) : aws.BatchJobQueue.BatchJobQueue =
            let config = aws.BatchJobQueue.BatchJobQueueConfig()
            for setter in state.assignments do
                setter config
            aws.BatchJobQueue.BatchJobQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.batchJobQueue: missing required arguments. Must call: name, priority, state.", 9999, IsError = true)>]
        member _.Run(_: BatchJobQueueState<_, _, _>) : aws.BatchJobQueue.BatchJobQueue =
            Unchecked.defaultof<aws.BatchJobQueue.BatchJobQueue>
