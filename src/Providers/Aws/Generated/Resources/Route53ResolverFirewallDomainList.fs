namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverFirewallDomainListState<'Name> = { assignments: ResizeArray<aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list">aws_route53_resolver_firewall_domain_list</a>.
    /// </summary>
    type Route53ResolverFirewallDomainListBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverFirewallDomainListState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallDomainListState<Missing>)

        member _.Zero(()) : Route53ResolverFirewallDomainListState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallDomainListState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list#name-1">Route53ResolverFirewallDomainList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverFirewallDomainListState<Missing>, value: string) : Route53ResolverFirewallDomainListState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallDomainListState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list#domains-1">Route53ResolverFirewallDomainList#domains</a>.
        /// </summary>
        [<CustomOperation "domains">]
        member _.Domains(state: Route53ResolverFirewallDomainListState<'Name>, value: seq<string>) : Route53ResolverFirewallDomainListState<'Name> =
            state.assignments.Add(fun config -> config.Domains <- (value |> Seq.toArray))
            state : Route53ResolverFirewallDomainListState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list#id-1">Route53ResolverFirewallDomainList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverFirewallDomainListState<'Name>, value: string) : Route53ResolverFirewallDomainListState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverFirewallDomainListState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list#tags-1">Route53ResolverFirewallDomainList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverFirewallDomainListState<'Name>, value: seq<string * string>) : Route53ResolverFirewallDomainListState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverFirewallDomainListState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_domain_list#tags_all-1">Route53ResolverFirewallDomainList#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverFirewallDomainListState<'Name>, value: seq<string * string>) : Route53ResolverFirewallDomainListState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverFirewallDomainListState<'Name>

        member _.Run(state: Route53ResolverFirewallDomainListState<Present>) : aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainList =
            let config = aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainListConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverFirewallDomainList: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverFirewallDomainListState<_>) : aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainList =
            Unchecked.defaultof<aws.Route53ResolverFirewallDomainList.Route53ResolverFirewallDomainList>
