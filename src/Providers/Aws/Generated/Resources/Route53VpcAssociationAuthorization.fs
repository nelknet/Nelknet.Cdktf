namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId> = { assignments: ResizeArray<aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization">aws_route53_vpc_association_authorization</a>.
    /// </summary>
    type Route53VpcAssociationAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53VpcAssociationAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53VpcAssociationAuthorizationState<Missing, Missing>)

        member _.Zero(()) : Route53VpcAssociationAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53VpcAssociationAuthorizationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization#vpc_id-1">Route53VpcAssociationAuthorization#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Route53VpcAssociationAuthorizationState<Missing, 'ZoneId>, value: string) : Route53VpcAssociationAuthorizationState<Present, 'ZoneId> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Route53VpcAssociationAuthorizationState<Present, 'ZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization#zone_id-1">Route53VpcAssociationAuthorization#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: Route53VpcAssociationAuthorizationState<'VpcId, Missing>, value: string) : Route53VpcAssociationAuthorizationState<'VpcId, Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : Route53VpcAssociationAuthorizationState<'VpcId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization#id-1">Route53VpcAssociationAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>, value: string) : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization#timeouts-1">Route53VpcAssociationAuthorization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>, value: aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorizationTimeouts) : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_vpc_association_authorization#vpc_region-1">Route53VpcAssociationAuthorization#vpc_region</a>.
        /// </summary>
        [<CustomOperation "vpc_region">]
        member _.VpcRegion(state: Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>, value: string) : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.VpcRegion <- value)
            state : Route53VpcAssociationAuthorizationState<'VpcId, 'ZoneId>

        member _.Run(state: Route53VpcAssociationAuthorizationState<Present, Present>) : aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorization =
            let config = aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorizationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53VpcAssociationAuthorization: missing required arguments. Must call: vpc_id, zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53VpcAssociationAuthorizationState<_, _>) : aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorization =
            Unchecked.defaultof<aws.Route53VpcAssociationAuthorization.Route53VpcAssociationAuthorization>
