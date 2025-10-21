namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSqsQueueState<'Name> = { assignments: ResizeArray<aws.DataAwsSqsQueue.DataAwsSqsQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queue">aws_sqs_queue</a>.
    /// </summary>
    type DataAwsSqsQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSqsQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSqsQueueState<Missing>)

        member _.Zero(()) : DataAwsSqsQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSqsQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queue#name-1">DataAwsSqsQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSqsQueueState<Missing>, value: string) : DataAwsSqsQueueState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSqsQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queue#id-1">DataAwsSqsQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSqsQueueState<'Name>, value: string) : DataAwsSqsQueueState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSqsQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queue#tags-1">DataAwsSqsQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSqsQueueState<'Name>, value: seq<string * string>) : DataAwsSqsQueueState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSqsQueueState<'Name>

        member _.Run(state: DataAwsSqsQueueState<Present>) : aws.DataAwsSqsQueue.DataAwsSqsQueue =
            let config = aws.DataAwsSqsQueue.DataAwsSqsQueueConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSqsQueue.DataAwsSqsQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSqsQueue: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSqsQueueState<_>) : aws.DataAwsSqsQueue.DataAwsSqsQueue =
            Unchecked.defaultof<aws.DataAwsSqsQueue.DataAwsSqsQueue>
