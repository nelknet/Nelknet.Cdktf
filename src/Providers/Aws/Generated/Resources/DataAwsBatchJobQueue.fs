namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBatchJobQueueState<'Name> = { assignments: ResizeArray<aws.DataAwsBatchJobQueue.DataAwsBatchJobQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_queue">aws_batch_job_queue</a>.
    /// </summary>
    type DataAwsBatchJobQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBatchJobQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchJobQueueState<Missing>)

        member _.Zero(()) : DataAwsBatchJobQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchJobQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_queue#name-1">DataAwsBatchJobQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBatchJobQueueState<Missing>, value: string) : DataAwsBatchJobQueueState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsBatchJobQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_queue#id-1">DataAwsBatchJobQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBatchJobQueueState<'Name>, value: string) : DataAwsBatchJobQueueState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBatchJobQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_queue#tags-1">DataAwsBatchJobQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBatchJobQueueState<'Name>, value: seq<string * string>) : DataAwsBatchJobQueueState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBatchJobQueueState<'Name>

        member _.Run(state: DataAwsBatchJobQueueState<Present>) : aws.DataAwsBatchJobQueue.DataAwsBatchJobQueue =
            let config = aws.DataAwsBatchJobQueue.DataAwsBatchJobQueueConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBatchJobQueue.DataAwsBatchJobQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBatchJobQueue: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBatchJobQueueState<_>) : aws.DataAwsBatchJobQueue.DataAwsBatchJobQueue =
            Unchecked.defaultof<aws.DataAwsBatchJobQueue.DataAwsBatchJobQueue>
