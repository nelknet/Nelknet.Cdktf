namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverConfigState<'AutodefinedReverseFlag, 'ResourceId> = { assignments: ResizeArray<aws.Route53ResolverConfig.Route53ResolverConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_config">aws_route53_resolver_config</a>.
    /// </summary>
    type Route53ResolverConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverConfigState<Missing, Missing>)

        member _.Zero(()) : Route53ResolverConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverConfigState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_config#autodefined_reverse_flag-1">Route53ResolverConfig#autodefined_reverse_flag</a>.
        /// </summary>
        [<CustomOperation "autodefined_reverse_flag">]
        member _.AutodefinedReverseFlag(state: Route53ResolverConfigState<Missing, 'ResourceId>, value: string) : Route53ResolverConfigState<Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.AutodefinedReverseFlag <- value)
            ({ assignments = state.assignments } : Route53ResolverConfigState<Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_config#resource_id-1">Route53ResolverConfig#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Route53ResolverConfigState<'AutodefinedReverseFlag, Missing>, value: string) : Route53ResolverConfigState<'AutodefinedReverseFlag, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Route53ResolverConfigState<'AutodefinedReverseFlag, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_config#id-1">Route53ResolverConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverConfigState<'AutodefinedReverseFlag, 'ResourceId>, value: string) : Route53ResolverConfigState<'AutodefinedReverseFlag, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverConfigState<'AutodefinedReverseFlag, 'ResourceId>

        member _.Run(state: Route53ResolverConfigState<Present, Present>) : aws.Route53ResolverConfig.Route53ResolverConfig =
            let config = aws.Route53ResolverConfig.Route53ResolverConfigConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverConfig.Route53ResolverConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverConfig: missing required arguments. Must call: autodefined_reverse_flag, resource_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverConfigState<_, _>) : aws.Route53ResolverConfig.Route53ResolverConfig =
            Unchecked.defaultof<aws.Route53ResolverConfig.Route53ResolverConfig>
