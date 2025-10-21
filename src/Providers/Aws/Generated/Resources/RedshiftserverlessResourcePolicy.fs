namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_resource_policy">aws_redshiftserverless_resource_policy</a>.
    /// </summary>
    type RedshiftserverlessResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_resource_policy#policy-1">RedshiftserverlessResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: RedshiftserverlessResourcePolicyState<Missing, 'ResourceArn>, value: string) : RedshiftserverlessResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : RedshiftserverlessResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_resource_policy#resource_arn-1">RedshiftserverlessResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: RedshiftserverlessResourcePolicyState<'Policy, Missing>, value: string) : RedshiftserverlessResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : RedshiftserverlessResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_resource_policy#id-1">RedshiftserverlessResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessResourcePolicyState<'Policy, 'ResourceArn>, value: string) : RedshiftserverlessResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: RedshiftserverlessResourcePolicyState<Present, Present>) : aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicy =
            let config = aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessResourcePolicyState<_, _>) : aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicy =
            Unchecked.defaultof<aws.RedshiftserverlessResourcePolicy.RedshiftserverlessResourcePolicy>
