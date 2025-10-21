namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbTargetGroupState = { assignments: ResizeArray<aws.AlbTargetGroup.AlbTargetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group">aws_alb_target_group</a>.
    /// </summary>
    type AlbTargetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbTargetGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AlbTargetGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#connection_termination-1">AlbTargetGroup#connection_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_termination">]
        member _.ConnectionTermination(state: AlbTargetGroupState, value: bool) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.ConnectionTermination <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#connection_termination-1">AlbTargetGroup#connection_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_termination">]
        member _.ConnectionTermination(state: AlbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.ConnectionTermination <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#deregistration_delay-1">AlbTargetGroup#deregistration_delay</a>.
        /// </summary>
        [<CustomOperation "deregistration_delay">]
        member _.DeregistrationDelay(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.DeregistrationDelay <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// health_check block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#health_check-1">AlbTargetGroup#health_check</a>
        /// </summary>
        [<CustomOperation "health_check">]
        member _.HealthCheck(state: AlbTargetGroupState, value: aws.AlbTargetGroup.AlbTargetGroupHealthCheck) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.HealthCheck <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#id-1">AlbTargetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#ip_address_type-1">AlbTargetGroup#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#lambda_multi_value_headers_enabled-1">AlbTargetGroup#lambda_multi_value_headers_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "lambda_multi_value_headers_enabled">]
        member _.LambdaMultiValueHeadersEnabled(state: AlbTargetGroupState, value: bool) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.LambdaMultiValueHeadersEnabled <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#lambda_multi_value_headers_enabled-1">AlbTargetGroup#lambda_multi_value_headers_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "lambda_multi_value_headers_enabled">]
        member _.LambdaMultiValueHeadersEnabled(state: AlbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.LambdaMultiValueHeadersEnabled <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#load_balancing_algorithm_type-1">AlbTargetGroup#load_balancing_algorithm_type</a>.
        /// </summary>
        [<CustomOperation "load_balancing_algorithm_type">]
        member _.LoadBalancingAlgorithmType(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAlgorithmType <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#load_balancing_anomaly_mitigation-1">AlbTargetGroup#load_balancing_anomaly_mitigation</a>.
        /// </summary>
        [<CustomOperation "load_balancing_anomaly_mitigation">]
        member _.LoadBalancingAnomalyMitigation(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingAnomalyMitigation <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#load_balancing_cross_zone_enabled-1">AlbTargetGroup#load_balancing_cross_zone_enabled</a>.
        /// </summary>
        [<CustomOperation "load_balancing_cross_zone_enabled">]
        member _.LoadBalancingCrossZoneEnabled(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.LoadBalancingCrossZoneEnabled <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#name-1">AlbTargetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#name_prefix-1">AlbTargetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#port-1">AlbTargetGroup#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: AlbTargetGroupState, value: double) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#preserve_client_ip-1">AlbTargetGroup#preserve_client_ip</a>.
        /// </summary>
        [<CustomOperation "preserve_client_ip">]
        member _.PreserveClientIp(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.PreserveClientIp <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#protocol-1">AlbTargetGroup#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#protocol_version-1">AlbTargetGroup#protocol_version</a>.
        /// </summary>
        [<CustomOperation "protocol_version">]
        member _.ProtocolVersion(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.ProtocolVersion <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#proxy_protocol_v2-1">AlbTargetGroup#proxy_protocol_v2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "proxy_protocol_v2">]
        member _.ProxyProtocolV2(state: AlbTargetGroupState, value: bool) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.ProxyProtocolV2 <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#proxy_protocol_v2-1">AlbTargetGroup#proxy_protocol_v2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "proxy_protocol_v2">]
        member _.ProxyProtocolV2(state: AlbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.ProxyProtocolV2 <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#slow_start-1">AlbTargetGroup#slow_start</a>.
        /// </summary>
        [<CustomOperation "slow_start">]
        member _.SlowStart(state: AlbTargetGroupState, value: double) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.SlowStart <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// stickiness block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#stickiness-1">AlbTargetGroup#stickiness</a>
        /// </summary>
        [<CustomOperation "stickiness">]
        member _.Stickiness(state: AlbTargetGroupState, value: aws.AlbTargetGroup.AlbTargetGroupStickiness) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Stickiness <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#tags-1">AlbTargetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AlbTargetGroupState, value: seq<string * string>) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#tags_all-1">AlbTargetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AlbTargetGroupState, value: seq<string * string>) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AlbTargetGroupState

        /// <summary>
        /// target_failover block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#target_failover-1">AlbTargetGroup#target_failover</a> Accepts: aws.IResolvable | aws.AlbTargetGroup.AlbTargetGroupTargetFailover[]
        /// </summary>
        [<CustomOperation "target_failover">]
        member _.TargetFailover(state: AlbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetFailover <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// target_group_health block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#target_group_health-1">AlbTargetGroup#target_group_health</a>
        /// </summary>
        [<CustomOperation "target_group_health">]
        member _.TargetGroupHealth(state: AlbTargetGroupState, value: aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealth) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetGroupHealth <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// target_health_state block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#target_health_state-1">AlbTargetGroup#target_health_state</a> Accepts: aws.IResolvable | aws.AlbTargetGroup.AlbTargetGroupTargetHealthState[]
        /// </summary>
        [<CustomOperation "target_health_state">]
        member _.TargetHealthState(state: AlbTargetGroupState, value: HashiCorp.Cdktf.IResolvable) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetHealthState <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#target_type-1">AlbTargetGroup#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.TargetType <- value)
            state : AlbTargetGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#vpc_id-1">AlbTargetGroup#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: AlbTargetGroupState, value: string) : AlbTargetGroupState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : AlbTargetGroupState

        member _.Run(state: AlbTargetGroupState) : aws.AlbTargetGroup.AlbTargetGroup =
            let config = aws.AlbTargetGroup.AlbTargetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.AlbTargetGroup.AlbTargetGroup(StackContext.get (), logicalId, config)
