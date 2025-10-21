namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.RedshiftResourcePolicy.RedshiftResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_resource_policy">aws_redshift_resource_policy</a>.
    /// </summary>
    type RedshiftResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : RedshiftResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_resource_policy#policy-1">RedshiftResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: RedshiftResourcePolicyState<Missing, 'ResourceArn>, value: string) : RedshiftResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : RedshiftResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_resource_policy#resource_arn-1">RedshiftResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: RedshiftResourcePolicyState<'Policy, Missing>, value: string) : RedshiftResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : RedshiftResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_resource_policy#id-1">RedshiftResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftResourcePolicyState<'Policy, 'ResourceArn>, value: string) : RedshiftResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: RedshiftResourcePolicyState<Present, Present>) : aws.RedshiftResourcePolicy.RedshiftResourcePolicy =
            let config = aws.RedshiftResourcePolicy.RedshiftResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftResourcePolicy.RedshiftResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftResourcePolicyState<_, _>) : aws.RedshiftResourcePolicy.RedshiftResourcePolicy =
            Unchecked.defaultof<aws.RedshiftResourcePolicy.RedshiftResourcePolicy>
