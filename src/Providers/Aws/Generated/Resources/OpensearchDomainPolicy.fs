namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchDomainPolicyState<'AccessPolicies, 'DomainName> = { assignments: ResizeArray<aws.OpensearchDomainPolicy.OpensearchDomainPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_policy">aws_opensearch_domain_policy</a>.
    /// </summary>
    type OpensearchDomainPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchDomainPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainPolicyState<Missing, Missing>)

        member _.Zero(()) : OpensearchDomainPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchDomainPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_policy#access_policies-1">OpensearchDomainPolicy#access_policies</a>.
        /// </summary>
        [<CustomOperation "access_policies">]
        member _.AccessPolicies(state: OpensearchDomainPolicyState<Missing, 'DomainName>, value: string) : OpensearchDomainPolicyState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.AccessPolicies <- value)
            ({ assignments = state.assignments } : OpensearchDomainPolicyState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_policy#domain_name-1">OpensearchDomainPolicy#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: OpensearchDomainPolicyState<'AccessPolicies, Missing>, value: string) : OpensearchDomainPolicyState<'AccessPolicies, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : OpensearchDomainPolicyState<'AccessPolicies, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_policy#id-1">OpensearchDomainPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchDomainPolicyState<'AccessPolicies, 'DomainName>, value: string) : OpensearchDomainPolicyState<'AccessPolicies, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchDomainPolicyState<'AccessPolicies, 'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_policy#timeouts-1">OpensearchDomainPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchDomainPolicyState<'AccessPolicies, 'DomainName>, value: aws.OpensearchDomainPolicy.OpensearchDomainPolicyTimeouts) : OpensearchDomainPolicyState<'AccessPolicies, 'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchDomainPolicyState<'AccessPolicies, 'DomainName>

        member _.Run(state: OpensearchDomainPolicyState<Present, Present>) : aws.OpensearchDomainPolicy.OpensearchDomainPolicy =
            let config = aws.OpensearchDomainPolicy.OpensearchDomainPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchDomainPolicy.OpensearchDomainPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchDomainPolicy: missing required arguments. Must call: access_policies, domain_name.", 9999, IsError = true)>]
        member _.Run(_: OpensearchDomainPolicyState<_, _>) : aws.OpensearchDomainPolicy.OpensearchDomainPolicy =
            Unchecked.defaultof<aws.OpensearchDomainPolicy.OpensearchDomainPolicy>
