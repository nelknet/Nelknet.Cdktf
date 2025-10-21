namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsTopicDataProtectionPolicyState<'Arn, 'Policy> = { assignments: ResizeArray<aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_data_protection_policy">aws_sns_topic_data_protection_policy</a>.
    /// </summary>
    type SnsTopicDataProtectionPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsTopicDataProtectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicDataProtectionPolicyState<Missing, Missing>)

        member _.Zero(()) : SnsTopicDataProtectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsTopicDataProtectionPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_data_protection_policy#arn-1">SnsTopicDataProtectionPolicy#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: SnsTopicDataProtectionPolicyState<Missing, 'Policy>, value: string) : SnsTopicDataProtectionPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : SnsTopicDataProtectionPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_data_protection_policy#policy-1">SnsTopicDataProtectionPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SnsTopicDataProtectionPolicyState<'Arn, Missing>, value: string) : SnsTopicDataProtectionPolicyState<'Arn, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SnsTopicDataProtectionPolicyState<'Arn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic_data_protection_policy#id-1">SnsTopicDataProtectionPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsTopicDataProtectionPolicyState<'Arn, 'Policy>, value: string) : SnsTopicDataProtectionPolicyState<'Arn, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsTopicDataProtectionPolicyState<'Arn, 'Policy>

        member _.Run(state: SnsTopicDataProtectionPolicyState<Present, Present>) : aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicy =
            let config = aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.snsTopicDataProtectionPolicy: missing required arguments. Must call: arn, policy.", 9999, IsError = true)>]
        member _.Run(_: SnsTopicDataProtectionPolicyState<_, _>) : aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicy =
            Unchecked.defaultof<aws.SnsTopicDataProtectionPolicy.SnsTopicDataProtectionPolicy>
