namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecordState<'Name, 'Type, 'ZoneId> = { assignments: ResizeArray<aws.Route53Record.Route53RecordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record">aws_route53_record</a>.
    /// </summary>
    type Route53RecordBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecordState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53RecordState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecordState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#name-1">Route53Record#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53RecordState<Missing, 'Type, 'ZoneId>, value: string) : Route53RecordState<Present, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53RecordState<Present, 'Type, 'ZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#type-1">Route53Record#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: Route53RecordState<'Name, Missing, 'ZoneId>, value: string) : Route53RecordState<'Name, Present, 'ZoneId> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : Route53RecordState<'Name, Present, 'ZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#zone_id-1">Route53Record#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: Route53RecordState<'Name, 'Type, Missing>, value: string) : Route53RecordState<'Name, 'Type, Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : Route53RecordState<'Name, 'Type, Present>)

        /// <summary>
        /// alias block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#alias-1">Route53Record#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordAlias) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#allow_overwrite-1">Route53Record#allow_overwrite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_overwrite">]
        member _.AllowOverwrite(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: bool) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.AllowOverwrite <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#allow_overwrite-1">Route53Record#allow_overwrite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_overwrite">]
        member _.AllowOverwrite(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: HashiCorp.Cdktf.IResolvable) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.AllowOverwrite <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// cidr_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#cidr_routing_policy-1">Route53Record#cidr_routing_policy</a>
        /// </summary>
        [<CustomOperation "cidr_routing_policy">]
        member _.CidrRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordCidrRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.CidrRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// failover_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#failover_routing_policy-1">Route53Record#failover_routing_policy</a>
        /// </summary>
        [<CustomOperation "failover_routing_policy">]
        member _.FailoverRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordFailoverRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.FailoverRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// geolocation_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geolocation_routing_policy-1">Route53Record#geolocation_routing_policy</a>
        /// </summary>
        [<CustomOperation "geolocation_routing_policy">]
        member _.GeolocationRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordGeolocationRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.GeolocationRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// geoproximity_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#geoproximity_routing_policy-1">Route53Record#geoproximity_routing_policy</a>
        /// </summary>
        [<CustomOperation "geoproximity_routing_policy">]
        member _.GeoproximityRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordGeoproximityRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.GeoproximityRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#health_check_id-1">Route53Record#health_check_id</a>.
        /// </summary>
        [<CustomOperation "health_check_id">]
        member _.HealthCheckId(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: string) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.HealthCheckId <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#id-1">Route53Record#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: string) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// latency_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#latency_routing_policy-1">Route53Record#latency_routing_policy</a>
        /// </summary>
        [<CustomOperation "latency_routing_policy">]
        member _.LatencyRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordLatencyRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.LatencyRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#multivalue_answer_routing_policy-1">Route53Record#multivalue_answer_routing_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multivalue_answer_routing_policy">]
        member _.MultivalueAnswerRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: bool) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.MultivalueAnswerRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#multivalue_answer_routing_policy-1">Route53Record#multivalue_answer_routing_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multivalue_answer_routing_policy">]
        member _.MultivalueAnswerRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: HashiCorp.Cdktf.IResolvable) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.MultivalueAnswerRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#records-1">Route53Record#records</a>.
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: seq<string>) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Records <- (value |> Seq.toArray))
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#set_identifier-1">Route53Record#set_identifier</a>.
        /// </summary>
        [<CustomOperation "set_identifier">]
        member _.SetIdentifier(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: string) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.SetIdentifier <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#timeouts-1">Route53Record#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordTimeouts) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#ttl-1">Route53Record#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: double) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        /// <summary>
        /// weighted_routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#weighted_routing_policy-1">Route53Record#weighted_routing_policy</a>
        /// </summary>
        [<CustomOperation "weighted_routing_policy">]
        member _.WeightedRoutingPolicy(state: Route53RecordState<'Name, 'Type, 'ZoneId>, value: aws.Route53Record.Route53RecordWeightedRoutingPolicy) : Route53RecordState<'Name, 'Type, 'ZoneId> =
            state.assignments.Add(fun config -> config.WeightedRoutingPolicy <- value)
            state : Route53RecordState<'Name, 'Type, 'ZoneId>

        member _.Run(state: Route53RecordState<Present, Present, Present>) : aws.Route53Record.Route53Record =
            let config = aws.Route53Record.Route53RecordConfig()
            for setter in state.assignments do
                setter config
            aws.Route53Record.Route53Record(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53Record: missing required arguments. Must call: name, type, zone_id.", 9999, IsError = true)>]
        member _.Run(_: Route53RecordState<_, _, _>) : aws.Route53Record.Route53Record =
            Unchecked.defaultof<aws.Route53Record.Route53Record>
