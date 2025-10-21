namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53HealthCheckState<'Type> = { assignments: ResizeArray<aws.Route53HealthCheck.Route53HealthCheckConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check">aws_route53_health_check</a>.
    /// </summary>
    type Route53HealthCheckBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53HealthCheckState<Missing> =
            ({ assignments = ResizeArray() } : Route53HealthCheckState<Missing>)

        member _.Zero(()) : Route53HealthCheckState<Missing> =
            ({ assignments = ResizeArray() } : Route53HealthCheckState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#type-1">Route53HealthCheck#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: Route53HealthCheckState<Missing>, value: string) : Route53HealthCheckState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : Route53HealthCheckState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#child_healthchecks-1">Route53HealthCheck#child_healthchecks</a>.
        /// </summary>
        [<CustomOperation "child_healthchecks">]
        member _.ChildHealthchecks(state: Route53HealthCheckState<'Type>, value: seq<string>) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.ChildHealthchecks <- (value |> Seq.toArray))
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#child_health_threshold-1">Route53HealthCheck#child_health_threshold</a>.
        /// </summary>
        [<CustomOperation "child_health_threshold">]
        member _.ChildHealthThreshold(state: Route53HealthCheckState<'Type>, value: double) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.ChildHealthThreshold <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#cloudwatch_alarm_name-1">Route53HealthCheck#cloudwatch_alarm_name</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_alarm_name">]
        member _.CloudwatchAlarmName(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.CloudwatchAlarmName <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#cloudwatch_alarm_region-1">Route53HealthCheck#cloudwatch_alarm_region</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_alarm_region">]
        member _.CloudwatchAlarmRegion(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.CloudwatchAlarmRegion <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#disabled-1">Route53HealthCheck#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: Route53HealthCheckState<'Type>, value: bool) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#disabled-1">Route53HealthCheck#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: Route53HealthCheckState<'Type>, value: HashiCorp.Cdktf.IResolvable) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#enable_sni-1">Route53HealthCheck#enable_sni</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sni">]
        member _.EnableSni(state: Route53HealthCheckState<'Type>, value: bool) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.EnableSni <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#enable_sni-1">Route53HealthCheck#enable_sni</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sni">]
        member _.EnableSni(state: Route53HealthCheckState<'Type>, value: HashiCorp.Cdktf.IResolvable) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.EnableSni <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#failure_threshold-1">Route53HealthCheck#failure_threshold</a>.
        /// </summary>
        [<CustomOperation "failure_threshold">]
        member _.FailureThreshold(state: Route53HealthCheckState<'Type>, value: double) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.FailureThreshold <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#fqdn-1">Route53HealthCheck#fqdn</a>.
        /// </summary>
        [<CustomOperation "fqdn">]
        member _.Fqdn(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Fqdn <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#id-1">Route53HealthCheck#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#insufficient_data_health_status-1">Route53HealthCheck#insufficient_data_health_status</a>.
        /// </summary>
        [<CustomOperation "insufficient_data_health_status">]
        member _.InsufficientDataHealthStatus(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.InsufficientDataHealthStatus <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#invert_healthcheck-1">Route53HealthCheck#invert_healthcheck</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invert_healthcheck">]
        member _.InvertHealthcheck(state: Route53HealthCheckState<'Type>, value: bool) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.InvertHealthcheck <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#invert_healthcheck-1">Route53HealthCheck#invert_healthcheck</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invert_healthcheck">]
        member _.InvertHealthcheck(state: Route53HealthCheckState<'Type>, value: HashiCorp.Cdktf.IResolvable) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.InvertHealthcheck <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#ip_address-1">Route53HealthCheck#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#measure_latency-1">Route53HealthCheck#measure_latency</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "measure_latency">]
        member _.MeasureLatency(state: Route53HealthCheckState<'Type>, value: bool) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.MeasureLatency <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#measure_latency-1">Route53HealthCheck#measure_latency</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "measure_latency">]
        member _.MeasureLatency(state: Route53HealthCheckState<'Type>, value: HashiCorp.Cdktf.IResolvable) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.MeasureLatency <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#port-1">Route53HealthCheck#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: Route53HealthCheckState<'Type>, value: double) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#reference_name-1">Route53HealthCheck#reference_name</a>.
        /// </summary>
        [<CustomOperation "reference_name">]
        member _.ReferenceName(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.ReferenceName <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#regions-1">Route53HealthCheck#regions</a>.
        /// </summary>
        [<CustomOperation "regions">]
        member _.Regions(state: Route53HealthCheckState<'Type>, value: seq<string>) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Regions <- (value |> Seq.toArray))
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#request_interval-1">Route53HealthCheck#request_interval</a>.
        /// </summary>
        [<CustomOperation "request_interval">]
        member _.RequestInterval(state: Route53HealthCheckState<'Type>, value: double) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.RequestInterval <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#resource_path-1">Route53HealthCheck#resource_path</a>.
        /// </summary>
        [<CustomOperation "resource_path">]
        member _.ResourcePath(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.ResourcePath <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#routing_control_arn-1">Route53HealthCheck#routing_control_arn</a>.
        /// </summary>
        [<CustomOperation "routing_control_arn">]
        member _.RoutingControlArn(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.RoutingControlArn <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#search_string-1">Route53HealthCheck#search_string</a>.
        /// </summary>
        [<CustomOperation "search_string">]
        member _.SearchString(state: Route53HealthCheckState<'Type>, value: string) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.SearchString <- value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#tags-1">Route53HealthCheck#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53HealthCheckState<'Type>, value: seq<string * string>) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#tags_all-1">Route53HealthCheck#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53HealthCheckState<'Type>, value: seq<string * string>) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53HealthCheckState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_health_check#triggers-1">Route53HealthCheck#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: Route53HealthCheckState<'Type>, value: seq<string * string>) : Route53HealthCheckState<'Type> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : Route53HealthCheckState<'Type>

        member _.Run(state: Route53HealthCheckState<Present>) : aws.Route53HealthCheck.Route53HealthCheck =
            let config = aws.Route53HealthCheck.Route53HealthCheckConfig()
            for setter in state.assignments do
                setter config
            aws.Route53HealthCheck.Route53HealthCheck(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53HealthCheck: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: Route53HealthCheckState<_>) : aws.Route53HealthCheck.Route53HealthCheck =
            Unchecked.defaultof<aws.Route53HealthCheck.Route53HealthCheck>
