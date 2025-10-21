namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverDnssecConfigState<'ResourceId> = { assignments: ResizeArray<aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_dnssec_config">aws_route53_resolver_dnssec_config</a>.
    /// </summary>
    type Route53ResolverDnssecConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverDnssecConfigState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverDnssecConfigState<Missing>)

        member _.Zero(()) : Route53ResolverDnssecConfigState<Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverDnssecConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_dnssec_config#resource_id-1">Route53ResolverDnssecConfig#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Route53ResolverDnssecConfigState<Missing>, value: string) : Route53ResolverDnssecConfigState<Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Route53ResolverDnssecConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_dnssec_config#id-1">Route53ResolverDnssecConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverDnssecConfigState<'ResourceId>, value: string) : Route53ResolverDnssecConfigState<'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverDnssecConfigState<'ResourceId>

        member _.Run(state: Route53ResolverDnssecConfigState<Present>) : aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfig =
            let config = aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfigConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverDnssecConfig: missing required arguments. Must call: resource_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverDnssecConfigState<_>) : aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfig =
            Unchecked.defaultof<aws.Route53ResolverDnssecConfig.Route53ResolverDnssecConfig>
