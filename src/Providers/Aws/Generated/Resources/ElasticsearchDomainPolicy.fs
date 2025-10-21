namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName> = { assignments: ResizeArray<aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_policy">aws_elasticsearch_domain_policy</a>.
    /// </summary>
    type ElasticsearchDomainPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticsearchDomainPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainPolicyState<Missing, Missing>)

        member _.Zero(()) : ElasticsearchDomainPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticsearchDomainPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_policy#access_policies-1">ElasticsearchDomainPolicy#access_policies</a>.
        /// </summary>
        [<CustomOperation "access_policies">]
        member _.AccessPolicies(state: ElasticsearchDomainPolicyState<Missing, 'DomainName>, value: string) : ElasticsearchDomainPolicyState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.AccessPolicies <- value)
            ({ assignments = state.assignments } : ElasticsearchDomainPolicyState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_policy#domain_name-1">ElasticsearchDomainPolicy#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ElasticsearchDomainPolicyState<'AccessPolicies, Missing>, value: string) : ElasticsearchDomainPolicyState<'AccessPolicies, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ElasticsearchDomainPolicyState<'AccessPolicies, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_policy#id-1">ElasticsearchDomainPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName>, value: string) : ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_policy#timeouts-1">ElasticsearchDomainPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName>, value: aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicyTimeouts) : ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticsearchDomainPolicyState<'AccessPolicies, 'DomainName>

        member _.Run(state: ElasticsearchDomainPolicyState<Present, Present>) : aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicy =
            let config = aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticsearchDomainPolicy: missing required arguments. Must call: access_policies, domain_name.", 9999, IsError = true)>]
        member _.Run(_: ElasticsearchDomainPolicyState<_, _>) : aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicy =
            Unchecked.defaultof<aws.ElasticsearchDomainPolicy.ElasticsearchDomainPolicy>
