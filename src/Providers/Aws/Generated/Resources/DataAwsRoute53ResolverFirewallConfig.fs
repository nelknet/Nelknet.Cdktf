namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53ResolverFirewallConfigState<'ResourceId> = { assignments: ResizeArray<aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_config">aws_route53_resolver_firewall_config</a>.
    /// </summary>
    type DataAwsRoute53ResolverFirewallConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53ResolverFirewallConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallConfigState<Missing>)

        member _.Zero(()) : DataAwsRoute53ResolverFirewallConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53ResolverFirewallConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_config#resource_id-1">DataAwsRoute53ResolverFirewallConfig#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: DataAwsRoute53ResolverFirewallConfigState<Missing>, value: string) : DataAwsRoute53ResolverFirewallConfigState<Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53ResolverFirewallConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_resolver_firewall_config#id-1">DataAwsRoute53ResolverFirewallConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53ResolverFirewallConfigState<'ResourceId>, value: string) : DataAwsRoute53ResolverFirewallConfigState<'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53ResolverFirewallConfigState<'ResourceId>

        member _.Run(state: DataAwsRoute53ResolverFirewallConfigState<Present>) : aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfig =
            let config = aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53ResolverFirewallConfig: missing required arguments. Must call: resource_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53ResolverFirewallConfigState<_>) : aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfig =
            Unchecked.defaultof<aws.DataAwsRoute53ResolverFirewallConfig.DataAwsRoute53ResolverFirewallConfig>
