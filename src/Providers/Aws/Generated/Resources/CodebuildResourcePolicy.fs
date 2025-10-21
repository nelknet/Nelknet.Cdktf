namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.CodebuildResourcePolicy.CodebuildResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_resource_policy">aws_codebuild_resource_policy</a>.
    /// </summary>
    type CodebuildResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : CodebuildResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_resource_policy#policy-1">CodebuildResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: CodebuildResourcePolicyState<Missing, 'ResourceArn>, value: string) : CodebuildResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : CodebuildResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_resource_policy#resource_arn-1">CodebuildResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: CodebuildResourcePolicyState<'Policy, Missing>, value: string) : CodebuildResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : CodebuildResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_resource_policy#id-1">CodebuildResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodebuildResourcePolicyState<'Policy, 'ResourceArn>, value: string) : CodebuildResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodebuildResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: CodebuildResourcePolicyState<Present, Present>) : aws.CodebuildResourcePolicy.CodebuildResourcePolicy =
            let config = aws.CodebuildResourcePolicy.CodebuildResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildResourcePolicy.CodebuildResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: CodebuildResourcePolicyState<_, _>) : aws.CodebuildResourcePolicy.CodebuildResourcePolicy =
            Unchecked.defaultof<aws.CodebuildResourcePolicy.CodebuildResourcePolicy>
