namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53QueryLogState<'CloudwatchLogGroupArn, 'ZoneId> = { assignments: ResizeArray<aws.Route53QueryLog.Route53QueryLogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_query_log">aws_route53_query_log</a>.
    /// </summary>
    type Route53QueryLogBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53QueryLogState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53QueryLogState<Missing, Missing>)

        member _.Zero(()) : Route53QueryLogState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53QueryLogState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_query_log#cloudwatch_log_group_arn-1">Route53QueryLog#cloudwatch_log_group_arn</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_log_group_arn">]
        member _.CloudwatchLogGroupArn(state: Route53QueryLogState<Missing, 'ZoneId>, value: string) : Route53QueryLogState<Present, 'ZoneId> =
            state.assignments.Add(fun config -> config.CloudwatchLogGroupArn <- value)
            ({ assignments = state.assignments } : Route53QueryLogState<Present, 'ZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_query_log#zone_id-1">Route53QueryLog#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: Route53QueryLogState<'CloudwatchLogGroupArn, Missing>, value: string) : Route53QueryLogState<'CloudwatchLogGroupArn, Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : Route53QueryLogState<'CloudwatchLogGroupArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_query_log#id-1">Route53QueryLog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53QueryLogState<'CloudwatchLogGroupArn, 'ZoneId>, value: string) : Route53QueryLogState<'CloudwatchLogGroupArn, 'ZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53QueryLogState<'CloudwatchLogGroupArn, 'ZoneId>

        member _.Run(state: Route53QueryLogState<Present, Present>) : aws.Route53QueryLog.Route53QueryLog =
            let config = aws.Route53QueryLog.Route53QueryLogConfig()
            for setter in state.assignments do
                setter config
            aws.Route53QueryLog.Route53QueryLog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53QueryLog: missing required arguments. Must call: cloudwatch_log_group_arn, zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53QueryLogState<_, _>) : aws.Route53QueryLog.Route53QueryLog =
            Unchecked.defaultof<aws.Route53QueryLog.Route53QueryLog>
