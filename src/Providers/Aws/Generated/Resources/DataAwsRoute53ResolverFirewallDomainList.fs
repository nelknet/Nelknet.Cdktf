namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverFirewallDomainListState<'FirewallDomainListId> = { assignments: ResizeArray<aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_domain_list">aws_route53_resolver_firewall_domain_list</a>.
    /// </summary>
    type DataAwsRoute53ResolverFirewallDomainListBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverFirewallDomainListState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallDomainListState<Missing>)

        member _.Zero(()) : DataAwsRoute53ResolverFirewallDomainListState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallDomainListState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_domain_list#firewall_domain_list_id-1">DataAwsRoute53ResolverFirewallDomainList#firewall_domain_list_id</a>.
        /// </summary>
        [<CustomOperation "firewall_domain_list_id">]
        member _.FirewallDomainListId(state: DataAwsRoute53ResolverFirewallDomainListState<Missing>, value: string) : DataAwsRoute53ResolverFirewallDomainListState<Present> =
            state.assignments.Add(fun config -> config.FirewallDomainListId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53ResolverFirewallDomainListState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_domain_list#id-1">DataAwsRoute53ResolverFirewallDomainList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverFirewallDomainListState<'FirewallDomainListId>, value: string) : DataAwsRoute53ResolverFirewallDomainListState<'FirewallDomainListId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverFirewallDomainListState<'FirewallDomainListId>

        member _.Run(state: DataAwsRoute53ResolverFirewallDomainListState<Present>) : aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainList =
            let config = aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainListConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53ResolverFirewallDomainList: missing required arguments. Must call: firewall_domain_list_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53ResolverFirewallDomainListState<_>) : aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainList =
            Unchecked.defaultof<aws.DataAwsRoute53ResolverFirewallDomainList.DataAwsRoute53ResolverFirewallDomainList>
