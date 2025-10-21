namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> = { assignments: ResizeArray<aws.ConnectQueue.ConnectQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue">aws_connect_queue</a>.
    /// </summary>
    type ConnectQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectQueueState<Missing, Missing, Missing>)

        member _.Zero(()) : ConnectQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectQueueState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#hours_of_operation_id-1">ConnectQueue#hours_of_operation_id</a>.
        /// </summary>
        [<CustomOperation "hours_of_operation_id">]
        member _.HoursOfOperationId(state: ConnectQueueState<Missing, 'InstanceId, 'Name>, value: string) : ConnectQueueState<Present, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.HoursOfOperationId <- value)
            ({ assignments = state.assignments } : ConnectQueueState<Present, 'InstanceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#instance_id-1">ConnectQueue#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectQueueState<'HoursOfOperationId, Missing, 'Name>, value: string) : ConnectQueueState<'HoursOfOperationId, Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectQueueState<'HoursOfOperationId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#name-1">ConnectQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, Missing>, value: string) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectQueueState<'HoursOfOperationId, 'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#description-1">ConnectQueue#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: string) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#id-1">ConnectQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: string) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#max_contacts-1">ConnectQueue#max_contacts</a>.
        /// </summary>
        [<CustomOperation "max_contacts">]
        member _.MaxContacts(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: double) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.MaxContacts <- value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// outbound_caller_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_config-1">ConnectQueue#outbound_caller_config</a>
        /// </summary>
        [<CustomOperation "outbound_caller_config">]
        member _.OutboundCallerConfig(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: aws.ConnectQueue.ConnectQueueOutboundCallerConfig) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.OutboundCallerConfig <- value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#quick_connect_ids-1">ConnectQueue#quick_connect_ids</a>.
        /// </summary>
        [<CustomOperation "quick_connect_ids">]
        member _.QuickConnectIds(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: seq<string>) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.QuickConnectIds <- (value |> Seq.toArray))
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#status-1">ConnectQueue#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: string) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#tags-1">ConnectQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: seq<string * string>) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#tags_all-1">ConnectQueue#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>, value: seq<string * string>) : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectQueueState<'HoursOfOperationId, 'InstanceId, 'Name>

        member _.Run(state: ConnectQueueState<Present, Present, Present>) : aws.ConnectQueue.ConnectQueue =
            let config = aws.ConnectQueue.ConnectQueueConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectQueue.ConnectQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectQueue: missing required arguments. Must call: hours_of_operation_id, instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectQueueState<_, _, _>) : aws.ConnectQueue.ConnectQueue =
            Unchecked.defaultof<aws.ConnectQueue.ConnectQueue>
