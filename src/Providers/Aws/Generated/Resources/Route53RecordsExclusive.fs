namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecordsExclusiveState<'ZoneId> = { assignments: ResizeArray<aws.Route53RecordsExclusive.Route53RecordsExclusiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive">aws_route53_records_exclusive</a>.
    /// </summary>
    type Route53RecordsExclusiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecordsExclusiveState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecordsExclusiveState<Missing>)

        member _.Zero(()) : Route53RecordsExclusiveState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecordsExclusiveState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#zone_id-1">Route53RecordsExclusive#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: Route53RecordsExclusiveState<Missing>, value: string) : Route53RecordsExclusiveState<Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : Route53RecordsExclusiveState<Present>)

        /// <summary>
        /// resource_record_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#resource_record_set-1">Route53RecordsExclusive#resource_record_set</a> Accepts: aws.IResolvable | aws.Route53RecordsExclusive.Route53RecordsExclusiveResourceRecordSet[]
        /// </summary>
        [<CustomOperation "resource_record_set">]
        member _.ResourceRecordSet(state: Route53RecordsExclusiveState<'ZoneId>, value: HashiCorp.Cdktf.IResolvable) : Route53RecordsExclusiveState<'ZoneId> =
            state.assignments.Add(fun config -> config.ResourceRecordSet <- value)
            state : Route53RecordsExclusiveState<'ZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_records_exclusive#timeouts-1">Route53RecordsExclusive#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecordsExclusiveState<'ZoneId>, value: aws.Route53RecordsExclusive.Route53RecordsExclusiveTimeouts) : Route53RecordsExclusiveState<'ZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecordsExclusiveState<'ZoneId>

        member _.Run(state: Route53RecordsExclusiveState<Present>) : aws.Route53RecordsExclusive.Route53RecordsExclusive =
            let config = aws.Route53RecordsExclusive.Route53RecordsExclusiveConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecordsExclusive.Route53RecordsExclusive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecordsExclusive: missing required arguments. Must call: zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53RecordsExclusiveState<_>) : aws.Route53RecordsExclusive.Route53RecordsExclusive =
            Unchecked.defaultof<aws.Route53RecordsExclusive.Route53RecordsExclusive>
