namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnConnectionState<'CustomerGatewayId, 'Type> = { assignments: ResizeArray<aws.VpnConnection.VpnConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection">aws_vpn_connection</a>.
    /// </summary>
    type VpnConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnConnectionState<Missing, Missing>)

        member _.Zero(()) : VpnConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#customer_gateway_id-1">VpnConnection#customer_gateway_id</a>.
        /// </summary>
        [<CustomOperation "customer_gateway_id">]
        member _.CustomerGatewayId(state: VpnConnectionState<Missing, 'Type>, value: string) : VpnConnectionState<Present, 'Type> =
            state.assignments.Add(fun config -> config.CustomerGatewayId <- value)
            ({ assignments = state.assignments } : VpnConnectionState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#type-1">VpnConnection#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VpnConnectionState<'CustomerGatewayId, Missing>, value: string) : VpnConnectionState<'CustomerGatewayId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VpnConnectionState<'CustomerGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#enable_acceleration-1">VpnConnection#enable_acceleration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_acceleration">]
        member _.EnableAcceleration(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: bool) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.EnableAcceleration <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#enable_acceleration-1">VpnConnection#enable_acceleration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_acceleration">]
        member _.EnableAcceleration(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.EnableAcceleration <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#id-1">VpnConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#local_ipv4_network_cidr-1">VpnConnection#local_ipv4_network_cidr</a>.
        /// </summary>
        [<CustomOperation "local_ipv4_network_cidr">]
        member _.LocalIpv4NetworkCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.LocalIpv4NetworkCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#local_ipv6_network_cidr-1">VpnConnection#local_ipv6_network_cidr</a>.
        /// </summary>
        [<CustomOperation "local_ipv6_network_cidr">]
        member _.LocalIpv6NetworkCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.LocalIpv6NetworkCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#outside_ip_address_type-1">VpnConnection#outside_ip_address_type</a>.
        /// </summary>
        [<CustomOperation "outside_ip_address_type">]
        member _.OutsideIpAddressType(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.OutsideIpAddressType <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#preshared_key_storage-1">VpnConnection#preshared_key_storage</a>.
        /// </summary>
        [<CustomOperation "preshared_key_storage">]
        member _.PresharedKeyStorage(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.PresharedKeyStorage <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#remote_ipv4_network_cidr-1">VpnConnection#remote_ipv4_network_cidr</a>.
        /// </summary>
        [<CustomOperation "remote_ipv4_network_cidr">]
        member _.RemoteIpv4NetworkCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.RemoteIpv4NetworkCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#remote_ipv6_network_cidr-1">VpnConnection#remote_ipv6_network_cidr</a>.
        /// </summary>
        [<CustomOperation "remote_ipv6_network_cidr">]
        member _.RemoteIpv6NetworkCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.RemoteIpv6NetworkCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#static_routes_only-1">VpnConnection#static_routes_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "static_routes_only">]
        member _.StaticRoutesOnly(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: bool) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.StaticRoutesOnly <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#static_routes_only-1">VpnConnection#static_routes_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "static_routes_only">]
        member _.StaticRoutesOnly(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.StaticRoutesOnly <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tags-1">VpnConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string * string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tags_all-1">VpnConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string * string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#transit_gateway_id-1">VpnConnection#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#transport_transit_gateway_attachment_id-1">VpnConnection#transport_transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transport_transit_gateway_attachment_id">]
        member _.TransportTransitGatewayAttachmentId(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.TransportTransitGatewayAttachmentId <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_dpd_timeout_action-1">VpnConnection#tunnel1_dpd_timeout_action</a>.
        /// </summary>
        [<CustomOperation "tunnel1_dpd_timeout_action">]
        member _.Tunnel1DpdTimeoutAction(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1DpdTimeoutAction <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_dpd_timeout_seconds-1">VpnConnection#tunnel1_dpd_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel1_dpd_timeout_seconds">]
        member _.Tunnel1DpdTimeoutSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1DpdTimeoutSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_enable_tunnel_lifecycle_control-1">VpnConnection#tunnel1_enable_tunnel_lifecycle_control</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tunnel1_enable_tunnel_lifecycle_control">]
        member _.Tunnel1EnableTunnelLifecycleControl(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: bool) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1EnableTunnelLifecycleControl <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_enable_tunnel_lifecycle_control-1">VpnConnection#tunnel1_enable_tunnel_lifecycle_control</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tunnel1_enable_tunnel_lifecycle_control">]
        member _.Tunnel1EnableTunnelLifecycleControl(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1EnableTunnelLifecycleControl <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_ike_versions-1">VpnConnection#tunnel1_ike_versions</a>.
        /// </summary>
        [<CustomOperation "tunnel1_ike_versions">]
        member _.Tunnel1IkeVersions(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1IkeVersions <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_inside_cidr-1">VpnConnection#tunnel1_inside_cidr</a>.
        /// </summary>
        [<CustomOperation "tunnel1_inside_cidr">]
        member _.Tunnel1InsideCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1InsideCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_inside_ipv6_cidr-1">VpnConnection#tunnel1_inside_ipv6_cidr</a>.
        /// </summary>
        [<CustomOperation "tunnel1_inside_ipv6_cidr">]
        member _.Tunnel1InsideIpv6Cidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1InsideIpv6Cidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// tunnel1_log_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_log_options-1">VpnConnection#tunnel1_log_options</a>
        /// </summary>
        [<CustomOperation "tunnel1_log_options">]
        member _.Tunnel1LogOptions(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: aws.VpnConnection.VpnConnectionTunnel1LogOptions) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1LogOptions <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase1_dh_group_numbers-1">VpnConnection#tunnel1_phase1_dh_group_numbers</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase1_dh_group_numbers">]
        member _.Tunnel1Phase1DhGroupNumbers(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<double>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase1DhGroupNumbers <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase1_encryption_algorithms-1">VpnConnection#tunnel1_phase1_encryption_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase1_encryption_algorithms">]
        member _.Tunnel1Phase1EncryptionAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase1EncryptionAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase1_integrity_algorithms-1">VpnConnection#tunnel1_phase1_integrity_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase1_integrity_algorithms">]
        member _.Tunnel1Phase1IntegrityAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase1IntegrityAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase1_lifetime_seconds-1">VpnConnection#tunnel1_phase1_lifetime_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase1_lifetime_seconds">]
        member _.Tunnel1Phase1LifetimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase1LifetimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase2_dh_group_numbers-1">VpnConnection#tunnel1_phase2_dh_group_numbers</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase2_dh_group_numbers">]
        member _.Tunnel1Phase2DhGroupNumbers(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<double>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase2DhGroupNumbers <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase2_encryption_algorithms-1">VpnConnection#tunnel1_phase2_encryption_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase2_encryption_algorithms">]
        member _.Tunnel1Phase2EncryptionAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase2EncryptionAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase2_integrity_algorithms-1">VpnConnection#tunnel1_phase2_integrity_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase2_integrity_algorithms">]
        member _.Tunnel1Phase2IntegrityAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase2IntegrityAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_phase2_lifetime_seconds-1">VpnConnection#tunnel1_phase2_lifetime_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel1_phase2_lifetime_seconds">]
        member _.Tunnel1Phase2LifetimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1Phase2LifetimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_preshared_key-1">VpnConnection#tunnel1_preshared_key</a>.
        /// </summary>
        [<CustomOperation "tunnel1_preshared_key">]
        member _.Tunnel1PresharedKey(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1PresharedKey <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_rekey_fuzz_percentage-1">VpnConnection#tunnel1_rekey_fuzz_percentage</a>.
        /// </summary>
        [<CustomOperation "tunnel1_rekey_fuzz_percentage">]
        member _.Tunnel1RekeyFuzzPercentage(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1RekeyFuzzPercentage <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_rekey_margin_time_seconds-1">VpnConnection#tunnel1_rekey_margin_time_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel1_rekey_margin_time_seconds">]
        member _.Tunnel1RekeyMarginTimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1RekeyMarginTimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_replay_window_size-1">VpnConnection#tunnel1_replay_window_size</a>.
        /// </summary>
        [<CustomOperation "tunnel1_replay_window_size">]
        member _.Tunnel1ReplayWindowSize(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1ReplayWindowSize <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel1_startup_action-1">VpnConnection#tunnel1_startup_action</a>.
        /// </summary>
        [<CustomOperation "tunnel1_startup_action">]
        member _.Tunnel1StartupAction(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel1StartupAction <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_dpd_timeout_action-1">VpnConnection#tunnel2_dpd_timeout_action</a>.
        /// </summary>
        [<CustomOperation "tunnel2_dpd_timeout_action">]
        member _.Tunnel2DpdTimeoutAction(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2DpdTimeoutAction <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_dpd_timeout_seconds-1">VpnConnection#tunnel2_dpd_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel2_dpd_timeout_seconds">]
        member _.Tunnel2DpdTimeoutSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2DpdTimeoutSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_enable_tunnel_lifecycle_control-1">VpnConnection#tunnel2_enable_tunnel_lifecycle_control</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tunnel2_enable_tunnel_lifecycle_control">]
        member _.Tunnel2EnableTunnelLifecycleControl(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: bool) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2EnableTunnelLifecycleControl <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_enable_tunnel_lifecycle_control-1">VpnConnection#tunnel2_enable_tunnel_lifecycle_control</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tunnel2_enable_tunnel_lifecycle_control">]
        member _.Tunnel2EnableTunnelLifecycleControl(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2EnableTunnelLifecycleControl <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_ike_versions-1">VpnConnection#tunnel2_ike_versions</a>.
        /// </summary>
        [<CustomOperation "tunnel2_ike_versions">]
        member _.Tunnel2IkeVersions(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2IkeVersions <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_inside_cidr-1">VpnConnection#tunnel2_inside_cidr</a>.
        /// </summary>
        [<CustomOperation "tunnel2_inside_cidr">]
        member _.Tunnel2InsideCidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2InsideCidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_inside_ipv6_cidr-1">VpnConnection#tunnel2_inside_ipv6_cidr</a>.
        /// </summary>
        [<CustomOperation "tunnel2_inside_ipv6_cidr">]
        member _.Tunnel2InsideIpv6Cidr(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2InsideIpv6Cidr <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// tunnel2_log_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_log_options-1">VpnConnection#tunnel2_log_options</a>
        /// </summary>
        [<CustomOperation "tunnel2_log_options">]
        member _.Tunnel2LogOptions(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: aws.VpnConnection.VpnConnectionTunnel2LogOptions) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2LogOptions <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase1_dh_group_numbers-1">VpnConnection#tunnel2_phase1_dh_group_numbers</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase1_dh_group_numbers">]
        member _.Tunnel2Phase1DhGroupNumbers(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<double>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase1DhGroupNumbers <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase1_encryption_algorithms-1">VpnConnection#tunnel2_phase1_encryption_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase1_encryption_algorithms">]
        member _.Tunnel2Phase1EncryptionAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase1EncryptionAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase1_integrity_algorithms-1">VpnConnection#tunnel2_phase1_integrity_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase1_integrity_algorithms">]
        member _.Tunnel2Phase1IntegrityAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase1IntegrityAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase1_lifetime_seconds-1">VpnConnection#tunnel2_phase1_lifetime_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase1_lifetime_seconds">]
        member _.Tunnel2Phase1LifetimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase1LifetimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase2_dh_group_numbers-1">VpnConnection#tunnel2_phase2_dh_group_numbers</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase2_dh_group_numbers">]
        member _.Tunnel2Phase2DhGroupNumbers(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<double>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase2DhGroupNumbers <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase2_encryption_algorithms-1">VpnConnection#tunnel2_phase2_encryption_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase2_encryption_algorithms">]
        member _.Tunnel2Phase2EncryptionAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase2EncryptionAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase2_integrity_algorithms-1">VpnConnection#tunnel2_phase2_integrity_algorithms</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase2_integrity_algorithms">]
        member _.Tunnel2Phase2IntegrityAlgorithms(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: seq<string>) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase2IntegrityAlgorithms <- (value |> Seq.toArray))
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_phase2_lifetime_seconds-1">VpnConnection#tunnel2_phase2_lifetime_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel2_phase2_lifetime_seconds">]
        member _.Tunnel2Phase2LifetimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2Phase2LifetimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_preshared_key-1">VpnConnection#tunnel2_preshared_key</a>.
        /// </summary>
        [<CustomOperation "tunnel2_preshared_key">]
        member _.Tunnel2PresharedKey(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2PresharedKey <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_rekey_fuzz_percentage-1">VpnConnection#tunnel2_rekey_fuzz_percentage</a>.
        /// </summary>
        [<CustomOperation "tunnel2_rekey_fuzz_percentage">]
        member _.Tunnel2RekeyFuzzPercentage(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2RekeyFuzzPercentage <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_rekey_margin_time_seconds-1">VpnConnection#tunnel2_rekey_margin_time_seconds</a>.
        /// </summary>
        [<CustomOperation "tunnel2_rekey_margin_time_seconds">]
        member _.Tunnel2RekeyMarginTimeSeconds(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2RekeyMarginTimeSeconds <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_replay_window_size-1">VpnConnection#tunnel2_replay_window_size</a>.
        /// </summary>
        [<CustomOperation "tunnel2_replay_window_size">]
        member _.Tunnel2ReplayWindowSize(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: double) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2ReplayWindowSize <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel2_startup_action-1">VpnConnection#tunnel2_startup_action</a>.
        /// </summary>
        [<CustomOperation "tunnel2_startup_action">]
        member _.Tunnel2StartupAction(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.Tunnel2StartupAction <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#tunnel_inside_ip_version-1">VpnConnection#tunnel_inside_ip_version</a>.
        /// </summary>
        [<CustomOperation "tunnel_inside_ip_version">]
        member _.TunnelInsideIpVersion(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.TunnelInsideIpVersion <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection#vpn_gateway_id-1">VpnConnection#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: VpnConnectionState<'CustomerGatewayId, 'Type>, value: string) : VpnConnectionState<'CustomerGatewayId, 'Type> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            state : VpnConnectionState<'CustomerGatewayId, 'Type>

        member _.Run(state: VpnConnectionState<Present, Present>) : aws.VpnConnection.VpnConnection =
            let config = aws.VpnConnection.VpnConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.VpnConnection.VpnConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpnConnection: missing required arguments. Must call: customer_gateway_id, type.", 9999, IsError = true)>]
        member _.Run(_: VpnConnectionState<_, _>) : aws.VpnConnection.VpnConnection =
            Unchecked.defaultof<aws.VpnConnection.VpnConnection>
