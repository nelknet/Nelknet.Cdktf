namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint">azurerm_private_dns_resolver_outbound_endpoint</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverOutboundEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverOutboundEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverOutboundEndpointState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverOutboundEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverOutboundEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#name-1">DataAzurermPrivateDnsResolverOutboundEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverOutboundEndpointState<Missing, 'PrivateDnsResolverId>, value: string) : DataAzurermPrivateDnsResolverOutboundEndpointState<Present, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverOutboundEndpointState<Present, 'PrivateDnsResolverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#private_dns_resolver_id-1">DataAzurermPrivateDnsResolverOutboundEndpoint#private_dns_resolver_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_resolver_id">]
        member _.PrivateDnsResolverId(state: DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, Missing>, value: string) : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateDnsResolverId <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#id-1">DataAzurermPrivateDnsResolverOutboundEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId>, value: string) : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#timeouts-1">DataAzurermPrivateDnsResolverOutboundEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId>, value: azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpointTimeouts) : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverOutboundEndpointState<'Name, 'PrivateDnsResolverId>

        member _.Run(state: DataAzurermPrivateDnsResolverOutboundEndpointState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpoint =
            let config = azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolverOutboundEndpoint: missing required arguments. Must call: name, private_dns_resolver_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverOutboundEndpointState<_, _>) : azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpoint =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpoint>
