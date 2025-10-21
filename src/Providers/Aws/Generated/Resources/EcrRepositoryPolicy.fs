namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrRepositoryPolicyState<'Policy, 'Repository> = { assignments: ResizeArray<aws.EcrRepositoryPolicy.EcrRepositoryPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_policy">aws_ecr_repository_policy</a>.
    /// </summary>
    type EcrRepositoryPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrRepositoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryPolicyState<Missing, Missing>)

        member _.Zero(()) : EcrRepositoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_policy#policy-1">EcrRepositoryPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: EcrRepositoryPolicyState<Missing, 'Repository>, value: string) : EcrRepositoryPolicyState<Present, 'Repository> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : EcrRepositoryPolicyState<Present, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_policy#repository-1">EcrRepositoryPolicy#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: EcrRepositoryPolicyState<'Policy, Missing>, value: string) : EcrRepositoryPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : EcrRepositoryPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository_policy#id-1">EcrRepositoryPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrRepositoryPolicyState<'Policy, 'Repository>, value: string) : EcrRepositoryPolicyState<'Policy, 'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrRepositoryPolicyState<'Policy, 'Repository>

        member _.Run(state: EcrRepositoryPolicyState<Present, Present>) : aws.EcrRepositoryPolicy.EcrRepositoryPolicy =
            let config = aws.EcrRepositoryPolicy.EcrRepositoryPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EcrRepositoryPolicy.EcrRepositoryPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrRepositoryPolicy: missing required arguments. Must call: policy, repository.", 9999, IsError = true)>]
        member _.Run(_: EcrRepositoryPolicyState<_, _>) : aws.EcrRepositoryPolicy.EcrRepositoryPolicy =
            Unchecked.defaultof<aws.EcrRepositoryPolicy.EcrRepositoryPolicy>
