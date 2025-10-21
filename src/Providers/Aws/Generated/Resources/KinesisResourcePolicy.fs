namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.KinesisResourcePolicy.KinesisResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_resource_policy">aws_kinesis_resource_policy</a>.
    /// </summary>
    type KinesisResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : KinesisResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_resource_policy#policy-1">KinesisResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: KinesisResourcePolicyState<Missing, 'ResourceArn>, value: string) : KinesisResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : KinesisResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_resource_policy#resource_arn-1">KinesisResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: KinesisResourcePolicyState<'Policy, Missing>, value: string) : KinesisResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : KinesisResourcePolicyState<'Policy, Present>)

        member _.Run(state: KinesisResourcePolicyState<Present, Present>) : aws.KinesisResourcePolicy.KinesisResourcePolicy =
            let config = aws.KinesisResourcePolicy.KinesisResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisResourcePolicy.KinesisResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: KinesisResourcePolicyState<_, _>) : aws.KinesisResourcePolicy.KinesisResourcePolicy =
            Unchecked.defaultof<aws.KinesisResourcePolicy.KinesisResourcePolicy>
