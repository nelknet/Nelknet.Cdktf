namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SqsQueueRedriveAllowPolicyState<'QueueUrl, 'RedriveAllowPolicy> = { assignments: ResizeArray<aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_allow_policy">aws_sqs_queue_redrive_allow_policy</a>.
    /// </summary>
    type SqsQueueRedriveAllowPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SqsQueueRedriveAllowPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueueRedriveAllowPolicyState<Missing, Missing>)

        member _.Zero(()) : SqsQueueRedriveAllowPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SqsQueueRedriveAllowPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_allow_policy#queue_url-1">SqsQueueRedriveAllowPolicy#queue_url</a>.
        /// </summary>
        [<CustomOperation "queue_url">]
        member _.QueueUrl(state: SqsQueueRedriveAllowPolicyState<Missing, 'RedriveAllowPolicy>, value: string) : SqsQueueRedriveAllowPolicyState<Present, 'RedriveAllowPolicy> =
            state.assignments.Add(fun config -> config.QueueUrl <- value)
            ({ assignments = state.assignments } : SqsQueueRedriveAllowPolicyState<Present, 'RedriveAllowPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_allow_policy#redrive_allow_policy-1">SqsQueueRedriveAllowPolicy#redrive_allow_policy</a>.
        /// </summary>
        [<CustomOperation "redrive_allow_policy">]
        member _.RedriveAllowPolicy(state: SqsQueueRedriveAllowPolicyState<'QueueUrl, Missing>, value: string) : SqsQueueRedriveAllowPolicyState<'QueueUrl, Present> =
            state.assignments.Add(fun config -> config.RedriveAllowPolicy <- value)
            ({ assignments = state.assignments } : SqsQueueRedriveAllowPolicyState<'QueueUrl, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue_redrive_allow_policy#id-1">SqsQueueRedriveAllowPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SqsQueueRedriveAllowPolicyState<'QueueUrl, 'RedriveAllowPolicy>, value: string) : SqsQueueRedriveAllowPolicyState<'QueueUrl, 'RedriveAllowPolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SqsQueueRedriveAllowPolicyState<'QueueUrl, 'RedriveAllowPolicy>

        member _.Run(state: SqsQueueRedriveAllowPolicyState<Present, Present>) : aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicy =
            let config = aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sqsQueueRedriveAllowPolicy: missing required arguments. Must call: queue_url, redrive_allow_policy.", 9999, IsError = true)>]
        member _.Run(_: SqsQueueRedriveAllowPolicyState<_, _>) : aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicy =
            Unchecked.defaultof<aws.SqsQueueRedriveAllowPolicy.SqsQueueRedriveAllowPolicy>
