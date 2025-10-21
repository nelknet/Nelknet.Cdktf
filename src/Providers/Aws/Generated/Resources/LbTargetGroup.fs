namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbTargetGroupState = { assignments: ResizeArray<aws.LbTargetGroup.LbTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group">aws_lb_target_group</a>.
    /// </summary>
    type LbTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbTargetGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LbTargetGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#connection_termination-1">LbTargetGroup#connection_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_termination">]
        member _.ConnectionTermination(state: LbTargetGroupState, value: bool) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.ConnectionTermination <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#connection_termination-1">LbTargetGroup#connection_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_termination">]
        member _.ConnectionTermination(state: LbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.ConnectionTermination <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#deregistration_delay-1">LbTargetGroup#deregistration_delay</a>.
        /// </summary>
        [<CustomOperation "deregistration_delay">]
        member _.DeregistrationDelay(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.DeregistrationDelay <- value)
            state : LbTargetGroupState

        /// <summary>
        /// health_check block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#health_check-1">LbTargetGroup#health_check</a>
        /// </summary>
        [<CustomOperation "health_check">]
        member _.HealthCheck(state: LbTargetGroupState, value: aws.LbTargetGroup.LbTargetGroupHealthCheck) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.HealthCheck <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#id-1">LbTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#ip_address_type-1">LbTargetGroup#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#lambda_multi_value_headers_enabled-1">LbTargetGroup#lambda_multi_value_headers_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "lambda_multi_value_headers_enabled">]
        member _.LambdaMultiValueHeadersEnabled(state: LbTargetGroupState, value: bool) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.LambdaMultiValueHeadersEnabled <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#lambda_multi_value_headers_enabled-1">LbTargetGroup#lambda_multi_value_headers_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "lambda_multi_value_headers_enabled">]
        member _.LambdaMultiValueHeadersEnabled(state: LbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.LambdaMultiValueHeadersEnabled <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#load_balancing_algorithm_type-1">LbTargetGroup#load_balancing_algorithm_type</a>.
        /// </summary>
        [<CustomOperation "load_balancing_algorithm_type">]
        member _.LoadBalancingAlgorithmType(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAlgorithmType <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#load_balancing_anomaly_mitigation-1">LbTargetGroup#load_balancing_anomaly_mitigation</a>.
        /// </summary>
        [<CustomOperation "load_balancing_anomaly_mitigation">]
        member _.LoadBalancingAnomalyMitigation(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAnomalyMitigation <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#load_balancing_cross_zone_enabled-1">LbTargetGroup#load_balancing_cross_zone_enabled</a>.
        /// </summary>
        [<CustomOperation "load_balancing_cross_zone_enabled">]
        member _.LoadBalancingCrossZoneEnabled(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingCrossZoneEnabled <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#name-1">LbTargetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#name_prefix-1">LbTargetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#port-1">LbTargetGroup#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: LbTargetGroupState, value: double) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#preserve_client_ip-1">LbTargetGroup#preserve_client_ip</a>.
        /// </summary>
        [<CustomOperation "preserve_client_ip">]
        member _.PreserveClientIp(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.PreserveClientIp <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#protocol-1">LbTargetGroup#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#protocol_version-1">LbTargetGroup#protocol_version</a>.
        /// </summary>
        [<CustomOperation "protocol_version">]
        member _.ProtocolVersion(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.ProtocolVersion <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#proxy_protocol_v2-1">LbTargetGroup#proxy_protocol_v2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "proxy_protocol_v2">]
        member _.ProxyProtocolV2(state: LbTargetGroupState, value: bool) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.ProxyProtocolV2 <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#proxy_protocol_v2-1">LbTargetGroup#proxy_protocol_v2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "proxy_protocol_v2">]
        member _.ProxyProtocolV2(state: LbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.ProxyProtocolV2 <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#slow_start-1">LbTargetGroup#slow_start</a>.
        /// </summary>
        [<CustomOperation "slow_start">]
        member _.SlowStart(state: LbTargetGroupState, value: double) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.SlowStart <- value)
            state : LbTargetGroupState

        /// <summary>
        /// stickiness block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#stickiness-1">LbTargetGroup#stickiness</a>
        /// </summary>
        [<CustomOperation "stickiness">]
        member _.Stickiness(state: LbTargetGroupState, value: aws.LbTargetGroup.LbTargetGroupStickiness) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Stickiness <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#tags-1">LbTargetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbTargetGroupState, value: seq<string * string>) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#tags_all-1">LbTargetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LbTargetGroupState, value: seq<string * string>) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LbTargetGroupState

        /// <summary>
        /// target_failover block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#target_failover-1">LbTargetGroup#target_failover</a> Accepts: aws.IResolvable | aws.LbTargetGroup.LbTargetGroupTargetFailover[]
        /// </summary>
        [<CustomOperation "target_failover">]
        member _.TargetFailover(state: LbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetFailover <- value)
            state : LbTargetGroupState

        /// <summary>
        /// target_group_health block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#target_group_health-1">LbTargetGroup#target_group_health</a>
        /// </summary>
        [<CustomOperation "target_group_health">]
        member _.TargetGroupHealth(state: LbTargetGroupState, value: aws.LbTargetGroup.LbTargetGroupTargetGroupHealth) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetGroupHealth <- value)
            state : LbTargetGroupState

        /// <summary>
        /// target_health_state block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#target_health_state-1">LbTargetGroup#target_health_state</a> Accepts: aws.IResolvable | aws.LbTargetGroup.LbTargetGroupTargetHealthState[]
        /// </summary>
        [<CustomOperation "target_health_state">]
        member _.TargetHealthState(state: LbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetHealthState <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#target_type-1">LbTargetGroup#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetType <- value)
            state : LbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#vpc_id-1">LbTargetGroup#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: LbTargetGroupState, value: string) : LbTargetGroupState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : LbTargetGroupState

        member _.Run(state: LbTargetGroupState) : aws.LbTargetGroup.LbTargetGroup =
            let config = aws.LbTargetGroup.LbTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.LbTargetGroup.LbTargetGroup(StackContext.get (), logicalId, config)
