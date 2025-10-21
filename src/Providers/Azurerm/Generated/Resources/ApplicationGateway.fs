namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ApplicationGateway.ApplicationGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway">azurerm_application_gateway</a>.
    /// </summary>
    type ApplicationGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// backend_address_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_address_pool-1">ApplicationGateway#backend_address_pool</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayBackendAddressPool[]
        /// </summary>
        [<CustomOperation "backend_address_pool">]
        member _.BackendAddressPool(state: ApplicationGatewayState<Missing, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<Present, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BackendAddressPool <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<Present, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// backend_http_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_http_settings-1">ApplicationGateway#backend_http_settings</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayBackendHttpSettings[]
        /// </summary>
        [<CustomOperation "backend_http_settings">]
        member _.BackendHttpSettings(state: ApplicationGatewayState<'BackendAddressPool, Missing, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, Present, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BackendHttpSettings <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, Present, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// frontend_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#frontend_ip_configuration-1">ApplicationGateway#frontend_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayFrontendIpConfiguration[]
        /// </summary>
        [<CustomOperation "frontend_ip_configuration">]
        member _.FrontendIpConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, Missing, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, Present, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FrontendIpConfiguration <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, Present, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// frontend_port block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#frontend_port-1">ApplicationGateway#frontend_port</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayFrontendPort[]
        /// </summary>
        [<CustomOperation "frontend_port">]
        member _.FrontendPort(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, Missing, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, Present, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FrontendPort <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, Present, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// gateway_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#gateway_ip_configuration-1">ApplicationGateway#gateway_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayGatewayIpConfiguration[]
        /// </summary>
        [<CustomOperation "gateway_ip_configuration">]
        member _.GatewayIpConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, Missing, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, Present, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.GatewayIpConfiguration <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, Present, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// http_listener block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#http_listener-1">ApplicationGateway#http_listener</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayHttpListener[]
        /// </summary>
        [<CustomOperation "http_listener">]
        member _.HttpListener(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, Missing, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, Present, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HttpListener <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, Present, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#location-1">ApplicationGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, Missing, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: string) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, Present, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, Present, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name-1">ApplicationGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, Missing, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: string) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, Present, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, Present, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// request_routing_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_routing_rule-1">ApplicationGateway#request_routing_rule</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayRequestRoutingRule[]
        /// </summary>
        [<CustomOperation "request_routing_rule">]
        member _.RequestRoutingRule(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, Missing, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RequestRoutingRule <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#resource_group_name-1">ApplicationGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, Missing, 'Sku>, value: string) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#sku-1">ApplicationGateway#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, Missing>, value: azurerm.ApplicationGateway.ApplicationGatewaySku) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, Present>)

        /// <summary>
        /// authentication_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#authentication_certificate-1">ApplicationGateway#authentication_certificate</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayAuthenticationCertificate[]
        /// </summary>
        [<CustomOperation "authentication_certificate">]
        member _.AuthenticationCertificate(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AuthenticationCertificate <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// autoscale_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#autoscale_configuration-1">ApplicationGateway#autoscale_configuration</a>
        /// </summary>
        [<CustomOperation "autoscale_configuration">]
        member _.AutoscaleConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewayAutoscaleConfiguration) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoscaleConfiguration <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// custom_error_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#custom_error_configuration-1">ApplicationGateway#custom_error_configuration</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayCustomErrorConfiguration[]
        /// </summary>
        [<CustomOperation "custom_error_configuration">]
        member _.CustomErrorConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomErrorConfiguration <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#enable_http2-1">ApplicationGateway#enable_http2</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: bool) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#enable_http2-1">ApplicationGateway#enable_http2</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_http2">]
        member _.EnableHttp2(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EnableHttp2 <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#fips_enabled-1">ApplicationGateway#fips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: bool) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#fips_enabled-1">ApplicationGateway#fips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#firewall_policy_id-1">ApplicationGateway#firewall_policy_id</a>.
        /// </summary>
        [<CustomOperation "firewall_policy_id">]
        member _.FirewallPolicyId(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: string) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FirewallPolicyId <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#force_firewall_policy_association-1">ApplicationGateway#force_firewall_policy_association</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "force_firewall_policy_association">]
        member _.ForceFirewallPolicyAssociation(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: bool) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ForceFirewallPolicyAssociation <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#force_firewall_policy_association-1">ApplicationGateway#force_firewall_policy_association</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "force_firewall_policy_association">]
        member _.ForceFirewallPolicyAssociation(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ForceFirewallPolicyAssociation <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// global block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#global-1">ApplicationGateway#global</a>
        /// </summary>
        [<CustomOperation "global">]
        member _.Global(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewayGlobal) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Global <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#id-1">ApplicationGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: string) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#identity-1">ApplicationGateway#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewayIdentity) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#private_link_configuration-1">ApplicationGateway#private_link_configuration</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayPrivateLinkConfiguration[]
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// probe block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#probe-1">ApplicationGateway#probe</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayProbe[]
        /// </summary>
        [<CustomOperation "probe">]
        member _.Probe(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Probe <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// redirect_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_configuration-1">ApplicationGateway#redirect_configuration</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayRedirectConfiguration[]
        /// </summary>
        [<CustomOperation "redirect_configuration">]
        member _.RedirectConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RedirectConfiguration <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// rewrite_rule_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rewrite_rule_set-1">ApplicationGateway#rewrite_rule_set</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayRewriteRuleSet[]
        /// </summary>
        [<CustomOperation "rewrite_rule_set">]
        member _.RewriteRuleSet(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RewriteRuleSet <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// ssl_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#ssl_certificate-1">ApplicationGateway#ssl_certificate</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewaySslCertificate[]
        /// </summary>
        [<CustomOperation "ssl_certificate">]
        member _.SslCertificate(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SslCertificate <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// ssl_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#ssl_policy-1">ApplicationGateway#ssl_policy</a>
        /// </summary>
        [<CustomOperation "ssl_policy">]
        member _.SslPolicy(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewaySslPolicy) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SslPolicy <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// ssl_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#ssl_profile-1">ApplicationGateway#ssl_profile</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewaySslProfile[]
        /// </summary>
        [<CustomOperation "ssl_profile">]
        member _.SslProfile(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SslProfile <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#tags-1">ApplicationGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#timeouts-1">ApplicationGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewayTimeouts) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// trusted_client_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#trusted_client_certificate-1">ApplicationGateway#trusted_client_certificate</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayTrustedClientCertificate[]
        /// </summary>
        [<CustomOperation "trusted_client_certificate">]
        member _.TrustedClientCertificate(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TrustedClientCertificate <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// trusted_root_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#trusted_root_certificate-1">ApplicationGateway#trusted_root_certificate</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayTrustedRootCertificate[]
        /// </summary>
        [<CustomOperation "trusted_root_certificate">]
        member _.TrustedRootCertificate(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TrustedRootCertificate <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// url_path_map block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url_path_map-1">ApplicationGateway#url_path_map</a> Accepts: azurerm.IResolvable | azurerm.ApplicationGateway.ApplicationGatewayUrlPathMap[]
        /// </summary>
        [<CustomOperation "url_path_map">]
        member _.UrlPathMap(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UrlPathMap <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// waf_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#waf_configuration-1">ApplicationGateway#waf_configuration</a>
        /// </summary>
        [<CustomOperation "waf_configuration">]
        member _.WafConfiguration(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: azurerm.ApplicationGateway.ApplicationGatewayWafConfiguration) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.WafConfiguration <- value)
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#zones-1">ApplicationGateway#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>, value: seq<string>) : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : ApplicationGatewayState<'BackendAddressPool, 'BackendHttpSettings, 'FrontendIpConfiguration, 'FrontendPort, 'GatewayIpConfiguration, 'HttpListener, 'Location, 'Name, 'RequestRoutingRule, 'ResourceGroupName, 'Sku>

        member _.Run(state: ApplicationGatewayState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ApplicationGateway.ApplicationGateway =
            let config = azurerm.ApplicationGateway.ApplicationGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationGateway.ApplicationGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationGateway: missing required arguments. Must call: backend_address_pool, backend_http_settings, frontend_ip_configuration, frontend_port, gateway_ip_configuration, http_listener, location, name, request_routing_rule, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ApplicationGatewayState<_, _, _, _, _, _, _, _, _, _, _>) : azurerm.ApplicationGateway.ApplicationGateway =
            Unchecked.defaultof<azurerm.ApplicationGateway.ApplicationGateway>
