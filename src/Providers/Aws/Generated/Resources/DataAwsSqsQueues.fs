namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSqsQueuesState = { assignments: ResizeArray<aws.DataAwsSqsQueues.DataAwsSqsQueuesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queues">aws_sqs_queues</a>.
    /// </summary>
    type DataAwsSqsQueuesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSqsQueuesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSqsQueuesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queues#id-1">DataAwsSqsQueues#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSqsQueuesState, value: string) : DataAwsSqsQueuesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSqsQueuesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sqs_queues#queue_name_prefix-1">DataAwsSqsQueues#queue_name_prefix</a>.
        /// </summary>
        [<CustomOperation "queue_name_prefix">]
        member _.QueueNamePrefix(state: DataAwsSqsQueuesState, value: string) : DataAwsSqsQueuesState =
            state.assignments.Add(fun config -> config.QueueNamePrefix <- value)
            state : DataAwsSqsQueuesState

        member _.Run(state: DataAwsSqsQueuesState) : aws.DataAwsSqsQueues.DataAwsSqsQueues =
            let config = aws.DataAwsSqsQueues.DataAwsSqsQueuesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSqsQueues.DataAwsSqsQueues(StackContext.get (), logicalId, config)
