namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.WebPubsub.WebPubsubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub">azurerm_web_pubsub</a>.
    /// </summary>
    type WebPubsubBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WebPubsubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#location-1">WebPubsub#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WebPubsubState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : WebPubsubState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WebPubsubState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#name-1">WebPubsub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebPubsubState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : WebPubsubState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebPubsubState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#resource_group_name-1">WebPubsub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WebPubsubState<'Location, 'Name, Missing, 'Sku>, value: string) : WebPubsubState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WebPubsubState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#sku-1">WebPubsub#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : WebPubsubState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#aad_auth_enabled-1">WebPubsub#aad_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "aad_auth_enabled">]
        member _.AadAuthEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AadAuthEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#aad_auth_enabled-1">WebPubsub#aad_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "aad_auth_enabled">]
        member _.AadAuthEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AadAuthEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#capacity-1">WebPubsub#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#id-1">WebPubsub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#identity-1">WebPubsub#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.WebPubsub.WebPubsubIdentity) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// live_trace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#live_trace-1">WebPubsub#live_trace</a>
        /// </summary>
        [<CustomOperation "live_trace">]
        member _.LiveTrace(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.WebPubsub.WebPubsubLiveTrace) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LiveTrace <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#local_auth_enabled-1">WebPubsub#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#local_auth_enabled-1">WebPubsub#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#public_network_access_enabled-1">WebPubsub#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#public_network_access_enabled-1">WebPubsub#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#tags-1">WebPubsub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#timeouts-1">WebPubsub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.WebPubsub.WebPubsubTimeouts) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#tls_client_cert_enabled-1">WebPubsub#tls_client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_client_cert_enabled">]
        member _.TlsClientCertEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TlsClientCertEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub#tls_client_cert_enabled-1">WebPubsub#tls_client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_client_cert_enabled">]
        member _.TlsClientCertEnabled(state: WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TlsClientCertEnabled <- value)
            state : WebPubsubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: WebPubsubState<Present, Present, Present, Present>) : azurerm.WebPubsub.WebPubsub =
            let config = azurerm.WebPubsub.WebPubsubConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsub.WebPubsub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsub: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubState<_, _, _, _>) : azurerm.WebPubsub.WebPubsub =
            Unchecked.defaultof<azurerm.WebPubsub.WebPubsub>
