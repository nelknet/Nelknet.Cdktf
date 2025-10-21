namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrLifecyclePolicyState<'Policy, 'Repository> = { assignments: ResizeArray<aws.EcrLifecyclePolicy.EcrLifecyclePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_lifecycle_policy">aws_ecr_lifecycle_policy</a>.
    /// </summary>
    type EcrLifecyclePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrLifecyclePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrLifecyclePolicyState<Missing, Missing>)

        member _.Zero(()) : EcrLifecyclePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrLifecyclePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_lifecycle_policy#policy-1">EcrLifecyclePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: EcrLifecyclePolicyState<Missing, 'Repository>, value: string) : EcrLifecyclePolicyState<Present, 'Repository> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : EcrLifecyclePolicyState<Present, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_lifecycle_policy#repository-1">EcrLifecyclePolicy#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: EcrLifecyclePolicyState<'Policy, Missing>, value: string) : EcrLifecyclePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : EcrLifecyclePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_lifecycle_policy#id-1">EcrLifecyclePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrLifecyclePolicyState<'Policy, 'Repository>, value: string) : EcrLifecyclePolicyState<'Policy, 'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrLifecyclePolicyState<'Policy, 'Repository>

        member _.Run(state: EcrLifecyclePolicyState<Present, Present>) : aws.EcrLifecyclePolicy.EcrLifecyclePolicy =
            let config = aws.EcrLifecyclePolicy.EcrLifecyclePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EcrLifecyclePolicy.EcrLifecyclePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrLifecyclePolicy: missing required arguments. Must call: policy, repository.", 9999, IsError = true)>]
        member _.Run(_: EcrLifecyclePolicyState<_, _>) : aws.EcrLifecyclePolicy.EcrLifecyclePolicy =
            Unchecked.defaultof<aws.EcrLifecyclePolicy.EcrLifecyclePolicy>
