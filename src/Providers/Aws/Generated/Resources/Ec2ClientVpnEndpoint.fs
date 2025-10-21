namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> = { assignments: ResizeArray<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint">aws_ec2_client_vpn_endpoint</a>.
    /// </summary>
    type Ec2ClientVpnEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ClientVpnEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Ec2ClientVpnEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ClientVpnEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// authentication_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#authentication_options-1">Ec2ClientVpnEndpoint#authentication_options</a> Accepts: aws.IResolvable | aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptions[]
        /// </summary>
        [<CustomOperation "authentication_options">]
        member _.AuthenticationOptions(state: Ec2ClientVpnEndpointState<Missing, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: HashiCorp.Cdktf.IResolvable) : Ec2ClientVpnEndpointState<Present, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.AuthenticationOptions <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnEndpointState<Present, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#client_cidr_block-1">Ec2ClientVpnEndpoint#client_cidr_block</a>.
        /// </summary>
        [<CustomOperation "client_cidr_block">]
        member _.ClientCidrBlock(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, Missing, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, Present, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.ClientCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnEndpointState<'AuthenticationOptions, Present, 'ConnectionLogOptions, 'ServerCertificateArn>)

        /// <summary>
        /// connection_log_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#connection_log_options-1">Ec2ClientVpnEndpoint#connection_log_options</a>
        /// </summary>
        [<CustomOperation "connection_log_options">]
        member _.ConnectionLogOptions(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, Missing, 'ServerCertificateArn>, value: aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptions) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, Present, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.ConnectionLogOptions <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, Present, 'ServerCertificateArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#server_certificate_arn-1">Ec2ClientVpnEndpoint#server_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "server_certificate_arn">]
        member _.ServerCertificateArn(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, Missing>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, Present> =
            state.assignments.Add(fun config -> config.ServerCertificateArn <- value)
            ({ assignments = state.assignments } : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, Present>)

        /// <summary>
        /// client_connect_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#client_connect_options-1">Ec2ClientVpnEndpoint#client_connect_options</a>
        /// </summary>
        [<CustomOperation "client_connect_options">]
        member _.ClientConnectOptions(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptions) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.ClientConnectOptions <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// client_login_banner_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#client_login_banner_options-1">Ec2ClientVpnEndpoint#client_login_banner_options</a>
        /// </summary>
        [<CustomOperation "client_login_banner_options">]
        member _.ClientLoginBannerOptions(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptions) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.ClientLoginBannerOptions <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// client_route_enforcement_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#client_route_enforcement_options-1">Ec2ClientVpnEndpoint#client_route_enforcement_options</a>
        /// </summary>
        [<CustomOperation "client_route_enforcement_options">]
        member _.ClientRouteEnforcementOptions(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptions) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.ClientRouteEnforcementOptions <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#description-1">Ec2ClientVpnEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#disconnect_on_session_timeout-1">Ec2ClientVpnEndpoint#disconnect_on_session_timeout</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disconnect_on_session_timeout">]
        member _.DisconnectOnSessionTimeout(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: bool) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.DisconnectOnSessionTimeout <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#disconnect_on_session_timeout-1">Ec2ClientVpnEndpoint#disconnect_on_session_timeout</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disconnect_on_session_timeout">]
        member _.DisconnectOnSessionTimeout(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: HashiCorp.Cdktf.IResolvable) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.DisconnectOnSessionTimeout <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#dns_servers-1">Ec2ClientVpnEndpoint#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: seq<string>) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#id-1">Ec2ClientVpnEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#security_group_ids-1">Ec2ClientVpnEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: seq<string>) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#self_service_portal-1">Ec2ClientVpnEndpoint#self_service_portal</a>.
        /// </summary>
        [<CustomOperation "self_service_portal">]
        member _.SelfServicePortal(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.SelfServicePortal <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#session_timeout_hours-1">Ec2ClientVpnEndpoint#session_timeout_hours</a>.
        /// </summary>
        [<CustomOperation "session_timeout_hours">]
        member _.SessionTimeoutHours(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: double) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.SessionTimeoutHours <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#split_tunnel-1">Ec2ClientVpnEndpoint#split_tunnel</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "split_tunnel">]
        member _.SplitTunnel(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: bool) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.SplitTunnel <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#split_tunnel-1">Ec2ClientVpnEndpoint#split_tunnel</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "split_tunnel">]
        member _.SplitTunnel(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: HashiCorp.Cdktf.IResolvable) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.SplitTunnel <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#tags-1">Ec2ClientVpnEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: seq<string * string>) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#tags_all-1">Ec2ClientVpnEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: seq<string * string>) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#transport_protocol-1">Ec2ClientVpnEndpoint#transport_protocol</a>.
        /// </summary>
        [<CustomOperation "transport_protocol">]
        member _.TransportProtocol(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.TransportProtocol <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#vpc_id-1">Ec2ClientVpnEndpoint#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: string) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#vpn_port-1">Ec2ClientVpnEndpoint#vpn_port</a>.
        /// </summary>
        [<CustomOperation "vpn_port">]
        member _.VpnPort(state: Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>, value: double) : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn> =
            state.assignments.Add(fun config -> config.VpnPort <- value)
            state : Ec2ClientVpnEndpointState<'AuthenticationOptions, 'ClientCidrBlock, 'ConnectionLogOptions, 'ServerCertificateArn>

        member _.Run(state: Ec2ClientVpnEndpointState<Present, Present, Present, Present>) : aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint =
            let config = aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ClientVpnEndpoint: missing required arguments. Must call: authentication_options, client_cidr_block, connection_log_options, server_certificate_arn.", 9999, IsError = true)>]
        member _.Run(_: Ec2ClientVpnEndpointState<_, _, _, _>) : aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint =
            Unchecked.defaultof<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint>
