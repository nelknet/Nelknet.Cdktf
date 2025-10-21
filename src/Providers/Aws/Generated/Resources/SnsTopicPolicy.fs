namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsTopicPolicyState<'Arn, 'Policy> = { assignments: ResizeArray<aws.SnsTopicPolicy.SnsTopicPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_policy">aws_sns_topic_policy</a>.
    /// </summary>
    type SnsTopicPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsTopicPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicPolicyState<Missing, Missing>)

        member _.Zero(()) : SnsTopicPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_policy#arn-1">SnsTopicPolicy#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: SnsTopicPolicyState<Missing, 'Policy>, value: string) : SnsTopicPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : SnsTopicPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_policy#policy-1">SnsTopicPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SnsTopicPolicyState<'Arn, Missing>, value: string) : SnsTopicPolicyState<'Arn, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SnsTopicPolicyState<'Arn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_policy#id-1">SnsTopicPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsTopicPolicyState<'Arn, 'Policy>, value: string) : SnsTopicPolicyState<'Arn, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsTopicPolicyState<'Arn, 'Policy>

        member _.Run(state: SnsTopicPolicyState<Present, Present>) : aws.SnsTopicPolicy.SnsTopicPolicy =
            let config = aws.SnsTopicPolicy.SnsTopicPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SnsTopicPolicy.SnsTopicPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.snsTopicPolicy: missing required arguments. Must call: arn, policy.", 9999, IsError = true)>]
        member _.Run(_: SnsTopicPolicyState<_, _>) : aws.SnsTopicPolicy.SnsTopicPolicy =
            Unchecked.defaultof<aws.SnsTopicPolicy.SnsTopicPolicy>
