namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverFirewallConfigState<'ResourceId> = { assignments: ResizeArray<aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_config">aws_route53_resolver_firewall_config</a>.
    /// </summary>
    type Route53ResolverFirewallConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverFirewallConfigState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallConfigState<Missing>)

        member _.Zero(()) : Route53ResolverFirewallConfigState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverFirewallConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_config#resource_id-1">Route53ResolverFirewallConfig#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Route53ResolverFirewallConfigState<Missing>, value: string) : Route53ResolverFirewallConfigState<Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Route53ResolverFirewallConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_config#firewall_fail_open-1">Route53ResolverFirewallConfig#firewall_fail_open</a>.
        /// </summary>
        [<CustomOperation "firewall_fail_open">]
        member _.FirewallFailOpen(state: Route53ResolverFirewallConfigState<'ResourceId>, value: string) : Route53ResolverFirewallConfigState<'ResourceId> =
            state.assignments.Add(fun config -> config.FirewallFailOpen <- value)
            state : Route53ResolverFirewallConfigState<'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_firewall_config#id-1">Route53ResolverFirewallConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverFirewallConfigState<'ResourceId>, value: string) : Route53ResolverFirewallConfigState<'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverFirewallConfigState<'ResourceId>

        member _.Run(state: Route53ResolverFirewallConfigState<Present>) : aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfig =
            let config = aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfigConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverFirewallConfig: missing required arguments. Must call: resource_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverFirewallConfigState<_>) : aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfig =
            Unchecked.defaultof<aws.Route53ResolverFirewallConfig.Route53ResolverFirewallConfig>
