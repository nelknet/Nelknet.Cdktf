namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ZoneAssociationState<'VpcId, 'ZoneId> = { assignments: ResizeArray<aws.Route53ZoneAssociation.Route53ZoneAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association">aws_route53_zone_association</a>.
    /// </summary>
    type Route53ZoneAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ZoneAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ZoneAssociationState<Missing, Missing>)

        member _.Zero(()) : Route53ZoneAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ZoneAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association#vpc_id-1">Route53ZoneAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Route53ZoneAssociationState<Missing, 'ZoneId>, value: string) : Route53ZoneAssociationState<Present, 'ZoneId> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Route53ZoneAssociationState<Present, 'ZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association#zone_id-1">Route53ZoneAssociation#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: Route53ZoneAssociationState<'VpcId, Missing>, value: string) : Route53ZoneAssociationState<'VpcId, Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : Route53ZoneAssociationState<'VpcId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association#id-1">Route53ZoneAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ZoneAssociationState<'VpcId, 'ZoneId>, value: string) : Route53ZoneAssociationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ZoneAssociationState<'VpcId, 'ZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association#timeouts-1">Route53ZoneAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ZoneAssociationState<'VpcId, 'ZoneId>, value: aws.Route53ZoneAssociation.Route53ZoneAssociationTimeouts) : Route53ZoneAssociationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ZoneAssociationState<'VpcId, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone_association#vpc_region-1">Route53ZoneAssociation#vpc_region</a>.
        /// </summary>
        [<CustomOperation "vpc_region">]
        member _.VpcRegion(state: Route53ZoneAssociationState<'VpcId, 'ZoneId>, value: string) : Route53ZoneAssociationState<'VpcId, 'ZoneId> =
            state.assignments.Add(fun config -> config.VpcRegion <- value)
            state : Route53ZoneAssociationState<'VpcId, 'ZoneId>

        member _.Run(state: Route53ZoneAssociationState<Present, Present>) : aws.Route53ZoneAssociation.Route53ZoneAssociation =
            let config = aws.Route53ZoneAssociation.Route53ZoneAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ZoneAssociation.Route53ZoneAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ZoneAssociation: missing required arguments. Must call: vpc_id, zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ZoneAssociationState<_, _>) : aws.Route53ZoneAssociation.Route53ZoneAssociation =
            Unchecked.defaultof<aws.Route53ZoneAssociation.Route53ZoneAssociation>
