namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, 'ResourceId> = { assignments: ResizeArray<aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config_association">aws_route53_resolver_query_log_config_association</a>.
    /// </summary>
    type Route53ResolverQueryLogConfigAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverQueryLogConfigAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverQueryLogConfigAssociationState<Missing, Missing>)

        member _.Zero(()) : Route53ResolverQueryLogConfigAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverQueryLogConfigAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config_association#resolver_query_log_config_id-1">Route53ResolverQueryLogConfigAssociation#resolver_query_log_config_id</a>.
        /// </summary>
        [<CustomOperation "resolver_query_log_config_id">]
        member _.ResolverQueryLogConfigId(state: Route53ResolverQueryLogConfigAssociationState<Missing, 'ResourceId>, value: string) : Route53ResolverQueryLogConfigAssociationState<Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.ResolverQueryLogConfigId <- value)
            ({ assignments = state.assignments } : Route53ResolverQueryLogConfigAssociationState<Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config_association#resource_id-1">Route53ResolverQueryLogConfigAssociation#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, Missing>, value: string) : Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_query_log_config_association#id-1">Route53ResolverQueryLogConfigAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, 'ResourceId>, value: string) : Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverQueryLogConfigAssociationState<'ResolverQueryLogConfigId, 'ResourceId>

        member _.Run(state: Route53ResolverQueryLogConfigAssociationState<Present, Present>) : aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociation =
            let config = aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverQueryLogConfigAssociation: missing required arguments. Must call: resolver_query_log_config_id, resource_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverQueryLogConfigAssociationState<_, _>) : aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociation =
            Unchecked.defaultof<aws.Route53ResolverQueryLogConfigAssociation.Route53ResolverQueryLogConfigAssociation>
