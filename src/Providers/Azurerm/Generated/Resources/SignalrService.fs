namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.SignalrService.SignalrServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service">azurerm_signalr_service</a>.
    /// </summary>
    type SignalrServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignalrServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SignalrServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#location-1">SignalrService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SignalrServiceState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SignalrServiceState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SignalrServiceState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#name-1">SignalrService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SignalrServiceState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : SignalrServiceState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SignalrServiceState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#resource_group_name-1">SignalrService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SignalrServiceState<'Location, 'Name, Missing, 'Sku>, value: string) : SignalrServiceState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SignalrServiceState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#sku-1">SignalrService#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.SignalrService.SignalrServiceSku) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#aad_auth_enabled-1">SignalrService#aad_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "aad_auth_enabled">]
        member _.AadAuthEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AadAuthEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#aad_auth_enabled-1">SignalrService#aad_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "aad_auth_enabled">]
        member _.AadAuthEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AadAuthEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#connectivity_logs_enabled-1">SignalrService#connectivity_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "connectivity_logs_enabled">]
        member _.ConnectivityLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ConnectivityLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#connectivity_logs_enabled-1">SignalrService#connectivity_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "connectivity_logs_enabled">]
        member _.ConnectivityLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ConnectivityLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// cors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#cors-1">SignalrService#cors</a> Accepts: azurerm.IResolvable | azurerm.SignalrService.SignalrServiceCors[]
        /// </summary>
        [<CustomOperation "cors">]
        member _.Cors(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Cors <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#http_request_logs_enabled-1">SignalrService#http_request_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http_request_logs_enabled">]
        member _.HttpRequestLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HttpRequestLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#http_request_logs_enabled-1">SignalrService#http_request_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http_request_logs_enabled">]
        member _.HttpRequestLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HttpRequestLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#id-1">SignalrService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#identity-1">SignalrService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.SignalrService.SignalrServiceIdentity) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// live_trace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#live_trace-1">SignalrService#live_trace</a>
        /// </summary>
        [<CustomOperation "live_trace">]
        member _.LiveTrace(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.SignalrService.SignalrServiceLiveTrace) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LiveTrace <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#live_trace_enabled-1">SignalrService#live_trace_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "live_trace_enabled">]
        member _.LiveTraceEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LiveTraceEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#live_trace_enabled-1">SignalrService#live_trace_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "live_trace_enabled">]
        member _.LiveTraceEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LiveTraceEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#local_auth_enabled-1">SignalrService#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#local_auth_enabled-1">SignalrService#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#messaging_logs_enabled-1">SignalrService#messaging_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "messaging_logs_enabled">]
        member _.MessagingLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MessagingLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#messaging_logs_enabled-1">SignalrService#messaging_logs_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "messaging_logs_enabled">]
        member _.MessagingLogsEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MessagingLogsEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#public_network_access_enabled-1">SignalrService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#public_network_access_enabled-1">SignalrService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#serverless_connection_timeout_in_seconds-1">SignalrService#serverless_connection_timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "serverless_connection_timeout_in_seconds">]
        member _.ServerlessConnectionTimeoutInSeconds(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ServerlessConnectionTimeoutInSeconds <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#service_mode-1">SignalrService#service_mode</a>.
        /// </summary>
        [<CustomOperation "service_mode">]
        member _.ServiceMode(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ServiceMode <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#tags-1">SignalrService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#timeouts-1">SignalrService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.SignalrService.SignalrServiceTimeouts) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#tls_client_cert_enabled-1">SignalrService#tls_client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_client_cert_enabled">]
        member _.TlsClientCertEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TlsClientCertEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#tls_client_cert_enabled-1">SignalrService#tls_client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_client_cert_enabled">]
        member _.TlsClientCertEnabled(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TlsClientCertEnabled <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// upstream_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#upstream_endpoint-1">SignalrService#upstream_endpoint</a> Accepts: azurerm.IResolvable | azurerm.SignalrService.SignalrServiceUpstreamEndpoint[]
        /// </summary>
        [<CustomOperation "upstream_endpoint">]
        member _.UpstreamEndpoint(state: SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.UpstreamEndpoint <- value)
            state : SignalrServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: SignalrServiceState<Present, Present, Present, Present>) : azurerm.SignalrService.SignalrService =
            let config = azurerm.SignalrService.SignalrServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SignalrService.SignalrService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.signalrService: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: SignalrServiceState<_, _, _, _>) : azurerm.SignalrService.SignalrService =
            Unchecked.defaultof<azurerm.SignalrService.SignalrService>
