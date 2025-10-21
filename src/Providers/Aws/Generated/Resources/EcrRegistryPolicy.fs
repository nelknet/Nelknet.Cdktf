namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrRegistryPolicyState<'Policy> = { assignments: ResizeArray<aws.EcrRegistryPolicy.EcrRegistryPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_policy">aws_ecr_registry_policy</a>.
    /// </summary>
    type EcrRegistryPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrRegistryPolicyState<Missing> =
            ({ assignments = ResizeArray() } : EcrRegistryPolicyState<Missing>)

        member _.Zero(()) : EcrRegistryPolicyState<Missing> =
            ({ assignments = ResizeArray() } : EcrRegistryPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_policy#policy-1">EcrRegistryPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: EcrRegistryPolicyState<Missing>, value: string) : EcrRegistryPolicyState<Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : EcrRegistryPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_policy#id-1">EcrRegistryPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrRegistryPolicyState<'Policy>, value: string) : EcrRegistryPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrRegistryPolicyState<'Policy>

        member _.Run(state: EcrRegistryPolicyState<Present>) : aws.EcrRegistryPolicy.EcrRegistryPolicy =
            let config = aws.EcrRegistryPolicy.EcrRegistryPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EcrRegistryPolicy.EcrRegistryPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrRegistryPolicy: missing required arguments. Must call: policy.", 9999, IsError = true)>]
        member _.Run(_: EcrRegistryPolicyState<_>) : aws.EcrRegistryPolicy.EcrRegistryPolicy =
            Unchecked.defaultof<aws.EcrRegistryPolicy.EcrRegistryPolicy>
