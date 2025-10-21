namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, 'Type> = { assignments: ResizeArray<aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_lifecycle_policy">aws_opensearchserverless_lifecycle_policy</a>.
    /// </summary>
    type OpensearchserverlessLifecyclePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessLifecyclePolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchserverlessLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessLifecyclePolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_lifecycle_policy#name-1">OpensearchserverlessLifecyclePolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessLifecyclePolicyState<Missing, 'Policy, 'Type>, value: string) : OpensearchserverlessLifecyclePolicyState<Present, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessLifecyclePolicyState<Present, 'Policy, 'Type>)

        /// <summary>
        /// JSON policy document to use as the content for the new policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_lifecycle_policy#policy-1">OpensearchserverlessLifecyclePolicy#policy</a>
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: OpensearchserverlessLifecyclePolicyState<'Name, Missing, 'Type>, value: string) : OpensearchserverlessLifecyclePolicyState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : OpensearchserverlessLifecyclePolicyState<'Name, Present, 'Type>)

        /// <summary>
        /// Type of lifecycle policy. Must be `retention`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_lifecycle_policy#type-1">OpensearchserverlessLifecyclePolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, Missing>, value: string) : OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, Present>)

        /// <summary>
        /// Description of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_lifecycle_policy#description-1">OpensearchserverlessLifecyclePolicy#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, 'Type>, value: string) : OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpensearchserverlessLifecyclePolicyState<'Name, 'Policy, 'Type>

        member _.Run(state: OpensearchserverlessLifecyclePolicyState<Present, Present, Present>) : aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicy =
            let config = aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessLifecyclePolicy: missing required arguments. Must call: name, policy, type.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessLifecyclePolicyState<_, _, _>) : aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicy =
            Unchecked.defaultof<aws.OpensearchserverlessLifecyclePolicy.OpensearchserverlessLifecyclePolicy>
