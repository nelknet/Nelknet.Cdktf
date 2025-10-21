namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessSecurityPolicyState<'Name, 'Policy, 'Type> = { assignments: ResizeArray<aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_policy">aws_opensearchserverless_security_policy</a>.
    /// </summary>
    type OpensearchserverlessSecurityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessSecurityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessSecurityPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchserverlessSecurityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessSecurityPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_policy#name-1">OpensearchserverlessSecurityPolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessSecurityPolicyState<Missing, 'Policy, 'Type>, value: string) : OpensearchserverlessSecurityPolicyState<Present, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessSecurityPolicyState<Present, 'Policy, 'Type>)

        /// <summary>
        /// JSON policy document to use as the content for the new policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_policy#policy-1">OpensearchserverlessSecurityPolicy#policy</a>
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: OpensearchserverlessSecurityPolicyState<'Name, Missing, 'Type>, value: string) : OpensearchserverlessSecurityPolicyState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : OpensearchserverlessSecurityPolicyState<'Name, Present, 'Type>)

        /// <summary>
        /// Type of security policy. One of `encryption` or `network`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_policy#type-1">OpensearchserverlessSecurityPolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpensearchserverlessSecurityPolicyState<'Name, 'Policy, Missing>, value: string) : OpensearchserverlessSecurityPolicyState<'Name, 'Policy, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : OpensearchserverlessSecurityPolicyState<'Name, 'Policy, Present>)

        /// <summary>
        /// Description of the policy. Typically used to store information about the permissions defined in the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_policy#description-1">OpensearchserverlessSecurityPolicy#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpensearchserverlessSecurityPolicyState<'Name, 'Policy, 'Type>, value: string) : OpensearchserverlessSecurityPolicyState<'Name, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpensearchserverlessSecurityPolicyState<'Name, 'Policy, 'Type>

        member _.Run(state: OpensearchserverlessSecurityPolicyState<Present, Present, Present>) : aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicy =
            let config = aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessSecurityPolicy: missing required arguments. Must call: name, policy, type.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessSecurityPolicyState<_, _, _>) : aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicy =
            Unchecked.defaultof<aws.OpensearchserverlessSecurityPolicy.OpensearchserverlessSecurityPolicy>
