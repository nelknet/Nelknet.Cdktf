namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchserverlessSecurityPolicyState<'Name, 'Type> = { assignments: ResizeArray<aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_policy">aws_opensearchserverless_security_policy</a>.
    /// </summary>
    type DataAwsOpensearchserverlessSecurityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchserverlessSecurityPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessSecurityPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAwsOpensearchserverlessSecurityPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessSecurityPolicyState<Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_policy#name-1">DataAwsOpensearchserverlessSecurityPolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsOpensearchserverlessSecurityPolicyState<Missing, 'Type>, value: string) : DataAwsOpensearchserverlessSecurityPolicyState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessSecurityPolicyState<Present, 'Type>)

        /// <summary>
        /// Type of security policy. One of `encryption` or `network`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_policy#type-1">DataAwsOpensearchserverlessSecurityPolicy#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsOpensearchserverlessSecurityPolicyState<'Name, Missing>, value: string) : DataAwsOpensearchserverlessSecurityPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessSecurityPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_policy#id-1">DataAwsOpensearchserverlessSecurityPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOpensearchserverlessSecurityPolicyState<'Name, 'Type>, value: string) : DataAwsOpensearchserverlessSecurityPolicyState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOpensearchserverlessSecurityPolicyState<'Name, 'Type>

        member _.Run(state: DataAwsOpensearchserverlessSecurityPolicyState<Present, Present>) : aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicy =
            let config = aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchserverlessSecurityPolicy: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchserverlessSecurityPolicyState<_, _>) : aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicy =
            Unchecked.defaultof<aws.DataAwsOpensearchserverlessSecurityPolicy.DataAwsOpensearchserverlessSecurityPolicy>
