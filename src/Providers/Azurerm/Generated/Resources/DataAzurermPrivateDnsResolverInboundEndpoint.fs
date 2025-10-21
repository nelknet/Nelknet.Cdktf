namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint">azurerm_private_dns_resolver_inbound_endpoint</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverInboundEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverInboundEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverInboundEndpointState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverInboundEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverInboundEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#name-1">DataAzurermPrivateDnsResolverInboundEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverInboundEndpointState<Missing, 'PrivateDnsResolverId>, value: string) : DataAzurermPrivateDnsResolverInboundEndpointState<Present, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverInboundEndpointState<Present, 'PrivateDnsResolverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#private_dns_resolver_id-1">DataAzurermPrivateDnsResolverInboundEndpoint#private_dns_resolver_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_resolver_id">]
        member _.PrivateDnsResolverId(state: DataAzurermPrivateDnsResolverInboundEndpointState<'Name, Missing>, value: string) : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateDnsResolverId <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#id-1">DataAzurermPrivateDnsResolverInboundEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId>, value: string) : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#timeouts-1">DataAzurermPrivateDnsResolverInboundEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId>, value: azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpointTimeouts) : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverInboundEndpointState<'Name, 'PrivateDnsResolverId>

        member _.Run(state: DataAzurermPrivateDnsResolverInboundEndpointState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpoint =
            let config = azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolverInboundEndpoint: missing required arguments. Must call: name, private_dns_resolver_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverInboundEndpointState<_, _>) : azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpoint =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpoint>
