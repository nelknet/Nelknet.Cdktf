namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessAccessPolicyState<'Name, 'Policy, 'Type> = { assignments: ResizeArray<aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_access_policy">aws_opensearchserverless_access_policy</a>.
    /// </summary>
    type OpensearchserverlessAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessAccessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchserverlessAccessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessAccessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_access_policy#name-1">OpensearchserverlessAccessPolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessAccessPolicyState<Missing, 'Policy, 'Type>, value: string) : OpensearchserverlessAccessPolicyState<Present, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessAccessPolicyState<Present, 'Policy, 'Type>)

        /// <summary>
        /// JSON policy document to use as the content for the new policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_access_policy#policy-1">OpensearchserverlessAccessPolicy#policy</a>
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: OpensearchserverlessAccessPolicyState<'Name, Missing, 'Type>, value: string) : OpensearchserverlessAccessPolicyState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : OpensearchserverlessAccessPolicyState<'Name, Present, 'Type>)

        /// <summary>
        /// Type of access policy. Must be `data`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_access_policy#type-1">OpensearchserverlessAccessPolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpensearchserverlessAccessPolicyState<'Name, 'Policy, Missing>, value: string) : OpensearchserverlessAccessPolicyState<'Name, 'Policy, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : OpensearchserverlessAccessPolicyState<'Name, 'Policy, Present>)

        /// <summary>
        /// Description of the policy. Typically used to store information about the permissions defined in the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_access_policy#description-1">OpensearchserverlessAccessPolicy#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpensearchserverlessAccessPolicyState<'Name, 'Policy, 'Type>, value: string) : OpensearchserverlessAccessPolicyState<'Name, 'Policy, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpensearchserverlessAccessPolicyState<'Name, 'Policy, 'Type>

        member _.Run(state: OpensearchserverlessAccessPolicyState<Present, Present, Present>) : aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicy =
            let config = aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessAccessPolicy: missing required arguments. Must call: name, policy, type.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessAccessPolicyState<_, _, _>) : aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicy =
            Unchecked.defaultof<aws.OpensearchserverlessAccessPolicy.OpensearchserverlessAccessPolicy>
