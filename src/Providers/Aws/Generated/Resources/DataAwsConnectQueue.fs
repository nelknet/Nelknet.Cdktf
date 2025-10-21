namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectQueueState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectQueue.DataAwsConnectQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue">aws_connect_queue</a>.
    /// </summary>
    type DataAwsConnectQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectQueueState<Missing>)

        member _.Zero(()) : DataAwsConnectQueueState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue#instance_id-1">DataAwsConnectQueue#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectQueueState<Missing>, value: string) : DataAwsConnectQueueState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue#id-1">DataAwsConnectQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectQueueState<'InstanceId>, value: string) : DataAwsConnectQueueState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectQueueState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue#name-1">DataAwsConnectQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectQueueState<'InstanceId>, value: string) : DataAwsConnectQueueState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectQueueState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue#queue_id-1">DataAwsConnectQueue#queue_id</a>.
        /// </summary>
        [<CustomOperation "queue_id">]
        member _.QueueId(state: DataAwsConnectQueueState<'InstanceId>, value: string) : DataAwsConnectQueueState<'InstanceId> =
            state.assignments.Add(fun config -> config.QueueId <- value)
            state : DataAwsConnectQueueState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_queue#tags-1">DataAwsConnectQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectQueueState<'InstanceId>, value: seq<string * string>) : DataAwsConnectQueueState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectQueueState<'InstanceId>

        member _.Run(state: DataAwsConnectQueueState<Present>) : aws.DataAwsConnectQueue.DataAwsConnectQueue =
            let config = aws.DataAwsConnectQueue.DataAwsConnectQueueConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectQueue.DataAwsConnectQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectQueue: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectQueueState<_>) : aws.DataAwsConnectQueue.DataAwsConnectQueue =
            Unchecked.defaultof<aws.DataAwsConnectQueue.DataAwsConnectQueue>
