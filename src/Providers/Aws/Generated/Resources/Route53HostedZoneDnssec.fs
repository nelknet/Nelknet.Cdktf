namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53HostedZoneDnssecState<'HostedZoneId> = { assignments: ResizeArray<aws.Route53HostedZoneDnssec.Route53HostedZoneDnssecConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_hosted_zone_dnssec">aws_route53_hosted_zone_dnssec</a>.
    /// </summary>
    type Route53HostedZoneDnssecBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53HostedZoneDnssecState<Missing> =
            ({ assignments = ResizeArray() } : Route53HostedZoneDnssecState<Missing>)

        member _.Zero(()) : Route53HostedZoneDnssecState<Missing> =
            ({ assignments = ResizeArray() } : Route53HostedZoneDnssecState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_hosted_zone_dnssec#hosted_zone_id-1">Route53HostedZoneDnssec#hosted_zone_id</a>.
        /// </summary>
        [<CustomOperation "hosted_zone_id">]
        member _.HostedZoneId(state: Route53HostedZoneDnssecState<Missing>, value: string) : Route53HostedZoneDnssecState<Present> =
            state.assignments.Add(fun config -> config.HostedZoneId <- value)
            ({ assignments = state.assignments } : Route53HostedZoneDnssecState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_hosted_zone_dnssec#id-1">Route53HostedZoneDnssec#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53HostedZoneDnssecState<'HostedZoneId>, value: string) : Route53HostedZoneDnssecState<'HostedZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53HostedZoneDnssecState<'HostedZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_hosted_zone_dnssec#signing_status-1">Route53HostedZoneDnssec#signing_status</a>.
        /// </summary>
        [<CustomOperation "signing_status">]
        member _.SigningStatus(state: Route53HostedZoneDnssecState<'HostedZoneId>, value: string) : Route53HostedZoneDnssecState<'HostedZoneId> =
            state.assignments.Add(fun config -> config.SigningStatus <- value)
            state : Route53HostedZoneDnssecState<'HostedZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_hosted_zone_dnssec#timeouts-1">Route53HostedZoneDnssec#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53HostedZoneDnssecState<'HostedZoneId>, value: aws.Route53HostedZoneDnssec.Route53HostedZoneDnssecTimeouts) : Route53HostedZoneDnssecState<'HostedZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53HostedZoneDnssecState<'HostedZoneId>

        member _.Run(state: Route53HostedZoneDnssecState<Present>) : aws.Route53HostedZoneDnssec.Route53HostedZoneDnssec =
            let config = aws.Route53HostedZoneDnssec.Route53HostedZoneDnssecConfig()
            for setter in state.assignments do
                setter config
            aws.Route53HostedZoneDnssec.Route53HostedZoneDnssec(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53HostedZoneDnssec: missing required arguments. Must call: hosted_zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53HostedZoneDnssecState<_>) : aws.Route53HostedZoneDnssec.Route53HostedZoneDnssec =
            Unchecked.defaultof<aws.Route53HostedZoneDnssec.Route53HostedZoneDnssec>
