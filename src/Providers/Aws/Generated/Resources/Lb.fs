namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbState = { assignments: ResizeArray<aws.Lb.LbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb">aws_lb</a>.
    /// </summary>
    type LbBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LbState =
            { assignments = ResizeArray() }

        /// <summary>
        /// access_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#access_logs-1">Lb#access_logs</a>
        /// </summary>
        [<CustomOperation "access_logs">]
        member _.AccessLogs(state: LbState, value: aws.Lb.LbAccessLogs) : LbState =
            state.assignments.Add(fun config -> config.AccessLogs <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#client_keep_alive-1">Lb#client_keep_alive</a>.
        /// </summary>
        [<CustomOperation "client_keep_alive">]
        member _.ClientKeepAlive(state: LbState, value: double) : LbState =
            state.assignments.Add(fun config -> config.ClientKeepAlive <- value)
            state : LbState

        /// <summary>
        /// connection_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#connection_logs-1">Lb#connection_logs</a>
        /// </summary>
        [<CustomOperation "connection_logs">]
        member _.ConnectionLogs(state: LbState, value: aws.Lb.LbConnectionLogs) : LbState =
            state.assignments.Add(fun config -> config.ConnectionLogs <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#customer_owned_ipv4_pool-1">Lb#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#desync_mitigation_mode-1">Lb#desync_mitigation_mode</a>.
        /// </summary>
        [<CustomOperation "desync_mitigation_mode">]
        member _.DesyncMitigationMode(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.DesyncMitigationMode <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#dns_record_client_routing_policy-1">Lb#dns_record_client_routing_policy</a>.
        /// </summary>
        [<CustomOperation "dns_record_client_routing_policy">]
        member _.DnsRecordClientRoutingPolicy(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.DnsRecordClientRoutingPolicy <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#drop_invalid_header_fields-1">Lb#drop_invalid_header_fields</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drop_invalid_header_fields">]
        member _.DropInvalidHeaderFields(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.DropInvalidHeaderFields <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#drop_invalid_header_fields-1">Lb#drop_invalid_header_fields</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "drop_invalid_header_fields">]
        member _.DropInvalidHeaderFields(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.DropInvalidHeaderFields <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_cross_zone_load_balancing-1">Lb#enable_cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_cross_zone_load_balancing">]
        member _.EnableCrossZoneLoadBalancing(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableCrossZoneLoadBalancing <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_cross_zone_load_balancing-1">Lb#enable_cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_cross_zone_load_balancing">]
        member _.EnableCrossZoneLoadBalancing(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableCrossZoneLoadBalancing <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_deletion_protection-1">Lb#enable_deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_deletion_protection">]
        member _.EnableDeletionProtection(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableDeletionProtection <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_deletion_protection-1">Lb#enable_deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_deletion_protection">]
        member _.EnableDeletionProtection(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableDeletionProtection <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_http2-1">Lb#enable_http2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_http2-1">Lb#enable_http2</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_tls_version_and_cipher_suite_headers-1">Lb#enable_tls_version_and_cipher_suite_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_tls_version_and_cipher_suite_headers">]
        member _.EnableTlsVersionAndCipherSuiteHeaders(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableTlsVersionAndCipherSuiteHeaders <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_tls_version_and_cipher_suite_headers-1">Lb#enable_tls_version_and_cipher_suite_headers</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_tls_version_and_cipher_suite_headers">]
        member _.EnableTlsVersionAndCipherSuiteHeaders(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableTlsVersionAndCipherSuiteHeaders <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_waf_fail_open-1">Lb#enable_waf_fail_open</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_waf_fail_open">]
        member _.EnableWafFailOpen(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableWafFailOpen <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_waf_fail_open-1">Lb#enable_waf_fail_open</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_waf_fail_open">]
        member _.EnableWafFailOpen(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableWafFailOpen <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_xff_client_port-1">Lb#enable_xff_client_port</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_xff_client_port">]
        member _.EnableXffClientPort(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableXffClientPort <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_xff_client_port-1">Lb#enable_xff_client_port</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_xff_client_port">]
        member _.EnableXffClientPort(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableXffClientPort <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_zonal_shift-1">Lb#enable_zonal_shift</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_zonal_shift">]
        member _.EnableZonalShift(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.EnableZonalShift <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enable_zonal_shift-1">Lb#enable_zonal_shift</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_zonal_shift">]
        member _.EnableZonalShift(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.EnableZonalShift <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#enforce_security_group_inbound_rules_on_private_link_traffic-1">Lb#enforce_security_group_inbound_rules_on_private_link_traffic</a>.
        /// </summary>
        [<CustomOperation "enforce_security_group_inbound_rules_on_private_link_traffic">]
        member _.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#id-1">Lb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#idle_timeout-1">Lb#idle_timeout</a>.
        /// </summary>
        [<CustomOperation "idle_timeout">]
        member _.IdleTimeout(state: LbState, value: double) : LbState =
            state.assignments.Add(fun config -> config.IdleTimeout <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#internal-1">Lb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#internal-1">Lb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#ip_address_type-1">Lb#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : LbState

        /// <summary>
        /// ipam_pools block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#ipam_pools-1">Lb#ipam_pools</a>
        /// </summary>
        [<CustomOperation "ipam_pools">]
        member _.IpamPools(state: LbState, value: aws.Lb.LbIpamPools) : LbState =
            state.assignments.Add(fun config -> config.IpamPools <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#load_balancer_type-1">Lb#load_balancer_type</a>.
        /// </summary>
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.LoadBalancerType <- value)
            state : LbState

        /// <summary>
        /// minimum_load_balancer_capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#minimum_load_balancer_capacity-1">Lb#minimum_load_balancer_capacity</a>
        /// </summary>
        [<CustomOperation "minimum_load_balancer_capacity">]
        member _.MinimumLoadBalancerCapacity(state: LbState, value: aws.Lb.LbMinimumLoadBalancerCapacity) : LbState =
            state.assignments.Add(fun config -> config.MinimumLoadBalancerCapacity <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#name-1">Lb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#name_prefix-1">Lb#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#preserve_host_header-1">Lb#preserve_host_header</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_host_header">]
        member _.PreserveHostHeader(state: LbState, value: bool) : LbState =
            state.assignments.Add(fun config -> config.PreserveHostHeader <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#preserve_host_header-1">Lb#preserve_host_header</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_host_header">]
        member _.PreserveHostHeader(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.PreserveHostHeader <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#security_groups-1">Lb#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: LbState, value: seq<string>) : LbState =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : LbState

        /// <summary>
        /// subnet_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#subnet_mapping-1">Lb#subnet_mapping</a> Accepts: aws.IResolvable | aws.Lb.LbSubnetMapping[]
        /// </summary>
        [<CustomOperation "subnet_mapping">]
        member _.SubnetMapping(state: LbState, value: HashiCorp.Cdktf.IResolvable) : LbState =
            state.assignments.Add(fun config -> config.SubnetMapping <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#subnets-1">Lb#subnets</a>.
        /// </summary>
        [<CustomOperation "subnets">]
        member _.Subnets(state: LbState, value: seq<string>) : LbState =
            state.assignments.Add(fun config -> config.Subnets <- (value |> Seq.toArray))
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#tags-1">Lb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbState, value: seq<string * string>) : LbState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#tags_all-1">Lb#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LbState, value: seq<string * string>) : LbState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LbState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#timeouts-1">Lb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbState, value: aws.Lb.LbTimeouts) : LbState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#xff_header_processing_mode-1">Lb#xff_header_processing_mode</a>.
        /// </summary>
        [<CustomOperation "xff_header_processing_mode">]
        member _.XffHeaderProcessingMode(state: LbState, value: string) : LbState =
            state.assignments.Add(fun config -> config.XffHeaderProcessingMode <- value)
            state : LbState

        member _.Run(state: LbState) : aws.Lb.Lb =
            let config = aws.Lb.LbConfig()
            for setter in state.assignments do
                setter config
            aws.Lb.Lb(StackContext.get (), logicalId, config)
