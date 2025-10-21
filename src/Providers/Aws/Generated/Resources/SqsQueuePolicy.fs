namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SqsQueuePolicyState<'Policy, 'QueueUrl> = { assignments: ResizeArray<aws.SqsQueuePolicy.SqsQueuePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_policy">aws_sqs_queue_policy</a>.
    /// </summary>
    type SqsQueuePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SqsQueuePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueuePolicyState<Missing, Missing>)

        member _.Zero(()) : SqsQueuePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueuePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_policy#policy-1">SqsQueuePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SqsQueuePolicyState<Missing, 'QueueUrl>, value: string) : SqsQueuePolicyState<Present, 'QueueUrl> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SqsQueuePolicyState<Present, 'QueueUrl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_policy#queue_url-1">SqsQueuePolicy#queue_url</a>.
        /// </summary>
        [<CustomOperation "queue_url">]
        member _.QueueUrl(state: SqsQueuePolicyState<'Policy, Missing>, value: string) : SqsQueuePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.QueueUrl <- value)
            ({ assignments = state.assignments } : SqsQueuePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_policy#id-1">SqsQueuePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SqsQueuePolicyState<'Policy, 'QueueUrl>, value: string) : SqsQueuePolicyState<'Policy, 'QueueUrl> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SqsQueuePolicyState<'Policy, 'QueueUrl>

        member _.Run(state: SqsQueuePolicyState<Present, Present>) : aws.SqsQueuePolicy.SqsQueuePolicy =
            let config = aws.SqsQueuePolicy.SqsQueuePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SqsQueuePolicy.SqsQueuePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sqsQueuePolicy: missing required arguments. Must call: policy, queue_url.", 9999, IsError = true)>]
        member _.Run(_: SqsQueuePolicyState<_, _>) : aws.SqsQueuePolicy.SqsQueuePolicy =
            Unchecked.defaultof<aws.SqsQueuePolicy.SqsQueuePolicy>
