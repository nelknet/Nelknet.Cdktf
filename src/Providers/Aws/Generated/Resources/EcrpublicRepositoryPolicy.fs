namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrpublicRepositoryPolicyState<'Policy, 'RepositoryName> = { assignments: ResizeArray<aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository_policy">aws_ecrpublic_repository_policy</a>.
    /// </summary>
    type EcrpublicRepositoryPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrpublicRepositoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrpublicRepositoryPolicyState<Missing, Missing>)

        member _.Zero(()) : EcrpublicRepositoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrpublicRepositoryPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository_policy#policy-1">EcrpublicRepositoryPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: EcrpublicRepositoryPolicyState<Missing, 'RepositoryName>, value: string) : EcrpublicRepositoryPolicyState<Present, 'RepositoryName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : EcrpublicRepositoryPolicyState<Present, 'RepositoryName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository_policy#repository_name-1">EcrpublicRepositoryPolicy#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: EcrpublicRepositoryPolicyState<'Policy, Missing>, value: string) : EcrpublicRepositoryPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : EcrpublicRepositoryPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository_policy#id-1">EcrpublicRepositoryPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrpublicRepositoryPolicyState<'Policy, 'RepositoryName>, value: string) : EcrpublicRepositoryPolicyState<'Policy, 'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrpublicRepositoryPolicyState<'Policy, 'RepositoryName>

        member _.Run(state: EcrpublicRepositoryPolicyState<Present, Present>) : aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicy =
            let config = aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrpublicRepositoryPolicy: missing required arguments. Must call: policy, repository_name.", 9999, IsError = true)>]
        member _.Run(_: EcrpublicRepositoryPolicyState<_, _>) : aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicy =
            Unchecked.defaultof<aws.EcrpublicRepositoryPolicy.EcrpublicRepositoryPolicy>
