namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName> = { assignments: ResizeArray<aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain_service_access_policy">aws_cloudsearch_domain_service_access_policy</a>.
    /// </summary>
    type CloudsearchDomainServiceAccessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudsearchDomainServiceAccessPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudsearchDomainServiceAccessPolicyState<Missing, Missing>)

        member _.Zero(()) : CloudsearchDomainServiceAccessPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudsearchDomainServiceAccessPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain_service_access_policy#access_policy-1">CloudsearchDomainServiceAccessPolicy#access_policy</a>.
        /// </summary>
        [<CustomOperation "access_policy">]
        member _.AccessPolicy(state: CloudsearchDomainServiceAccessPolicyState<Missing, 'DomainName>, value: string) : CloudsearchDomainServiceAccessPolicyState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.AccessPolicy <- value)
            ({ assignments = state.assignments } : CloudsearchDomainServiceAccessPolicyState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain_service_access_policy#domain_name-1">CloudsearchDomainServiceAccessPolicy#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, Missing>, value: string) : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain_service_access_policy#id-1">CloudsearchDomainServiceAccessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName>, value: string) : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain_service_access_policy#timeouts-1">CloudsearchDomainServiceAccessPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName>, value: aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicyTimeouts) : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudsearchDomainServiceAccessPolicyState<'AccessPolicy, 'DomainName>

        member _.Run(state: CloudsearchDomainServiceAccessPolicyState<Present, Present>) : aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicy =
            let config = aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudsearchDomainServiceAccessPolicy: missing required arguments. Must call: access_policy, domain_name.", 9999, IsError = true)>]
        member _.Run(_: CloudsearchDomainServiceAccessPolicyState<_, _>) : aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicy =
            Unchecked.defaultof<aws.CloudsearchDomainServiceAccessPolicy.CloudsearchDomainServiceAccessPolicy>
