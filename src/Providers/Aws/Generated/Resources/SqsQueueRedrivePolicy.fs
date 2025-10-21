namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SqsQueueRedrivePolicyState<'QueueUrl, 'RedrivePolicy> = { assignments: ResizeArray<aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_policy">aws_sqs_queue_redrive_policy</a>.
    /// </summary>
    type SqsQueueRedrivePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SqsQueueRedrivePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueueRedrivePolicyState<Missing, Missing>)

        member _.Zero(()) : SqsQueueRedrivePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueueRedrivePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_policy#queue_url-1">SqsQueueRedrivePolicy#queue_url</a>.
        /// </summary>
        [<CustomOperation "queue_url">]
        member _.QueueUrl(state: SqsQueueRedrivePolicyState<Missing, 'RedrivePolicy>, value: string) : SqsQueueRedrivePolicyState<Present, 'RedrivePolicy> =
            state.assignments.Add(fun config -> config.QueueUrl <- value)
            ({ assignments = state.assignments } : SqsQueueRedrivePolicyState<Present, 'RedrivePolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_policy#redrive_policy-1">SqsQueueRedrivePolicy#redrive_policy</a>.
        /// </summary>
        [<CustomOperation "redrive_policy">]
        member _.RedrivePolicy(state: SqsQueueRedrivePolicyState<'QueueUrl, Missing>, value: string) : SqsQueueRedrivePolicyState<'QueueUrl, Present> =
            state.assignments.Add(fun config -> config.RedrivePolicy <- value)
            ({ assignments = state.assignments } : SqsQueueRedrivePolicyState<'QueueUrl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_policy#id-1">SqsQueueRedrivePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SqsQueueRedrivePolicyState<'QueueUrl, 'RedrivePolicy>, value: string) : SqsQueueRedrivePolicyState<'QueueUrl, 'RedrivePolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SqsQueueRedrivePolicyState<'QueueUrl, 'RedrivePolicy>

        member _.Run(state: SqsQueueRedrivePolicyState<Present, Present>) : aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicy =
            let config = aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sqsQueueRedrivePolicy: missing required arguments. Must call: queue_url, redrive_policy.", 9999, IsError = true)>]
        member _.Run(_: SqsQueueRedrivePolicyState<_, _>) : aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicy =
            Unchecked.defaultof<aws.SqsQueueRedrivePolicy.SqsQueueRedrivePolicy>
