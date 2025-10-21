namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbState = { assignments: ResizeArray<aws.Alb.AlbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb">aws_alb</a>.
    /// </summary>
    type AlbBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AlbState =
            { assignments = ResizeArray() }

        /// <summary>
        /// access_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#access_logs-1">Alb#access_logs</a>
        /// </summary>
        [<CustomOperation "access_logs">]
        member _.AccessLogs(state: AlbState, value: aws.Alb.AlbAccessLogs) : AlbState =
            state.assignments.Add(fun config -> config.AccessLogs <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#client_keep_alive-1">Alb#client_keep_alive</a>.
        /// </summary>
        [<CustomOperation "client_keep_alive">]
        member _.ClientKeepAlive(state: AlbState, value: double) : AlbState =
            state.assignments.Add(fun config -> config.ClientKeepAlive <- value)
            state : AlbState

        /// <summary>
        /// connection_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#connection_logs-1">Alb#connection_logs</a>
        /// </summary>
        [<CustomOperation "connection_logs">]
        member _.ConnectionLogs(state: AlbState, value: aws.Alb.AlbConnectionLogs) : AlbState =
            state.assignments.Add(fun config -> config.ConnectionLogs <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#customer_owned_ipv4_pool-1">Alb#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#desync_mitigation_mode-1">Alb#desync_mitigation_mode</a>.
        /// </summary>
        [<CustomOperation "desync_mitigation_mode">]
        member _.DesyncMitigationMode(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.DesyncMitigationMode <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#dns_record_client_routing_policy-1">Alb#dns_record_client_routing_policy</a>.
        /// </summary>
        [<CustomOperation "dns_record_client_routing_policy">]
        member _.DnsRecordClientRoutingPolicy(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.DnsRecordClientRoutingPolicy <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#drop_invalid_header_fields-1">Alb#drop_invalid_header_fields</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drop_invalid_header_fields">]
        member _.DropInvalidHeaderFields(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.DropInvalidHeaderFields <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#drop_invalid_header_fields-1">Alb#drop_invalid_header_fields</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drop_invalid_header_fields">]
        member _.DropInvalidHeaderFields(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.DropInvalidHeaderFields <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_cross_zone_load_balancing-1">Alb#enable_cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_cross_zone_load_balancing">]
        member _.EnableCrossZoneLoadBalancing(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableCrossZoneLoadBalancing <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_cross_zone_load_balancing-1">Alb#enable_cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_cross_zone_load_balancing">]
        member _.EnableCrossZoneLoadBalancing(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableCrossZoneLoadBalancing <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_deletion_protection-1">Alb#enable_deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_deletion_protection">]
        member _.EnableDeletionProtection(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableDeletionProtection <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_deletion_protection-1">Alb#enable_deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_deletion_protection">]
        member _.EnableDeletionProtection(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableDeletionProtection <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_http2-1">Alb#enable_http2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_http2-1">Alb#enable_http2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_tls_version_and_cipher_suite_headers-1">Alb#enable_tls_version_and_cipher_suite_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_tls_version_and_cipher_suite_headers">]
        member _.EnableTlsVersionAndCipherSuiteHeaders(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableTlsVersionAndCipherSuiteHeaders <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_tls_version_and_cipher_suite_headers-1">Alb#enable_tls_version_and_cipher_suite_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_tls_version_and_cipher_suite_headers">]
        member _.EnableTlsVersionAndCipherSuiteHeaders(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableTlsVersionAndCipherSuiteHeaders <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_waf_fail_open-1">Alb#enable_waf_fail_open</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_waf_fail_open">]
        member _.EnableWafFailOpen(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableWafFailOpen <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_waf_fail_open-1">Alb#enable_waf_fail_open</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_waf_fail_open">]
        member _.EnableWafFailOpen(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableWafFailOpen <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_xff_client_port-1">Alb#enable_xff_client_port</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_xff_client_port">]
        member _.EnableXffClientPort(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableXffClientPort <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_xff_client_port-1">Alb#enable_xff_client_port</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_xff_client_port">]
        member _.EnableXffClientPort(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableXffClientPort <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_zonal_shift-1">Alb#enable_zonal_shift</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_zonal_shift">]
        member _.EnableZonalShift(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.EnableZonalShift <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enable_zonal_shift-1">Alb#enable_zonal_shift</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_zonal_shift">]
        member _.EnableZonalShift(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.EnableZonalShift <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#enforce_security_group_inbound_rules_on_private_link_traffic-1">Alb#enforce_security_group_inbound_rules_on_private_link_traffic</a>.
        /// </summary>
        [<CustomOperation "enforce_security_group_inbound_rules_on_private_link_traffic">]
        member _.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#id-1">Alb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#idle_timeout-1">Alb#idle_timeout</a>.
        /// </summary>
        [<CustomOperation "idle_timeout">]
        member _.IdleTimeout(state: AlbState, value: double) : AlbState =
            state.assignments.Add(fun config -> config.IdleTimeout <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#internal-1">Alb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#internal-1">Alb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ip_address_type-1">Alb#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : AlbState

        /// <summary>
        /// ipam_pools block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ipam_pools-1">Alb#ipam_pools</a>
        /// </summary>
        [<CustomOperation "ipam_pools">]
        member _.IpamPools(state: AlbState, value: aws.Alb.AlbIpamPools) : AlbState =
            state.assignments.Add(fun config -> config.IpamPools <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#load_balancer_type-1">Alb#load_balancer_type</a>.
        /// </summary>
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.LoadBalancerType <- value)
            state : AlbState

        /// <summary>
        /// minimum_load_balancer_capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#minimum_load_balancer_capacity-1">Alb#minimum_load_balancer_capacity</a>
        /// </summary>
        [<CustomOperation "minimum_load_balancer_capacity">]
        member _.MinimumLoadBalancerCapacity(state: AlbState, value: aws.Alb.AlbMinimumLoadBalancerCapacity) : AlbState =
            state.assignments.Add(fun config -> config.MinimumLoadBalancerCapacity <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#name-1">Alb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#name_prefix-1">Alb#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#preserve_host_header-1">Alb#preserve_host_header</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_host_header">]
        member _.PreserveHostHeader(state: AlbState, value: bool) : AlbState =
            state.assignments.Add(fun config -> config.PreserveHostHeader <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#preserve_host_header-1">Alb#preserve_host_header</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_host_header">]
        member _.PreserveHostHeader(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.PreserveHostHeader <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#security_groups-1">Alb#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: AlbState, value: seq<string>) : AlbState =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : AlbState

        /// <summary>
        /// subnet_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#subnet_mapping-1">Alb#subnet_mapping</a> Accepts: aws.IResolvable | aws.Alb.AlbSubnetMapping[]
        /// </summary>
        [<CustomOperation "subnet_mapping">]
        member _.SubnetMapping(state: AlbState, value: HashiCorp.Cdktf.IResolvable) : AlbState =
            state.assignments.Add(fun config -> config.SubnetMapping <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#subnets-1">Alb#subnets</a>.
        /// </summary>
        [<CustomOperation "subnets">]
        member _.Subnets(state: AlbState, value: seq<string>) : AlbState =
            state.assignments.Add(fun config -> config.Subnets <- (value |> Seq.toArray))
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#tags-1">Alb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AlbState, value: seq<string * string>) : AlbState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#tags_all-1">Alb#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AlbState, value: seq<string * string>) : AlbState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AlbState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#timeouts-1">Alb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AlbState, value: aws.Alb.AlbTimeouts) : AlbState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#xff_header_processing_mode-1">Alb#xff_header_processing_mode</a>.
        /// </summary>
        [<CustomOperation "xff_header_processing_mode">]
        member _.XffHeaderProcessingMode(state: AlbState, value: string) : AlbState =
            state.assignments.Add(fun config -> config.XffHeaderProcessingMode <- value)
            state : AlbState

        member _.Run(state: AlbState) : aws.Alb.Alb =
            let config = aws.Alb.AlbConfig()
            for setter in state.assignments do
                setter config
            aws.Alb.Alb(StackContext.get (), logicalId, config)
