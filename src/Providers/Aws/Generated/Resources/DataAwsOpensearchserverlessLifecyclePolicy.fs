namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchserverlessLifecyclePolicyState<'Name, 'Type> = { assignments: ResizeArray<aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_lifecycle_policy">aws_opensearchserverless_lifecycle_policy</a>.
    /// </summary>
    type DataAwsOpensearchserverlessLifecyclePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchserverlessLifecyclePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessLifecyclePolicyState<Missing, Missing>)

        member _.Zero(()) : DataAwsOpensearchserverlessLifecyclePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessLifecyclePolicyState<Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_lifecycle_policy#name-1">DataAwsOpensearchserverlessLifecyclePolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsOpensearchserverlessLifecyclePolicyState<Missing, 'Type>, value: string) : DataAwsOpensearchserverlessLifecyclePolicyState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessLifecyclePolicyState<Present, 'Type>)

        /// <summary>
        /// Type of lifecycle policy. Must be `retention`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_lifecycle_policy#type-1">DataAwsOpensearchserverlessLifecyclePolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsOpensearchserverlessLifecyclePolicyState<'Name, Missing>, value: string) : DataAwsOpensearchserverlessLifecyclePolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessLifecyclePolicyState<'Name, Present>)

        member _.Run(state: DataAwsOpensearchserverlessLifecyclePolicyState<Present, Present>) : aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicy =
            let config = aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchserverlessLifecyclePolicy: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchserverlessLifecyclePolicyState<_, _>) : aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicy =
            Unchecked.defaultof<aws.DataAwsOpensearchserverlessLifecyclePolicy.DataAwsOpensearchserverlessLifecyclePolicy>
