namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchserverlessAccessPolicyState<'Name, 'Type> = { assignments: ResizeArray<aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_access_policy">aws_opensearchserverless_access_policy</a>.
    /// </summary>
    type DataAwsOpensearchserverlessAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchserverlessAccessPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessAccessPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAwsOpensearchserverlessAccessPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessAccessPolicyState<Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_access_policy#name-1">DataAwsOpensearchserverlessAccessPolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsOpensearchserverlessAccessPolicyState<Missing, 'Type>, value: string) : DataAwsOpensearchserverlessAccessPolicyState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessAccessPolicyState<Present, 'Type>)

        /// <summary>
        /// Type of access policy. Must be `data`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_access_policy#type-1">DataAwsOpensearchserverlessAccessPolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsOpensearchserverlessAccessPolicyState<'Name, Missing>, value: string) : DataAwsOpensearchserverlessAccessPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessAccessPolicyState<'Name, Present>)

        member _.Run(state: DataAwsOpensearchserverlessAccessPolicyState<Present, Present>) : aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicy =
            let config = aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchserverlessAccessPolicy: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchserverlessAccessPolicyState<_, _>) : aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicy =
            Unchecked.defaultof<aws.DataAwsOpensearchserverlessAccessPolicy.DataAwsOpensearchserverlessAccessPolicy>
