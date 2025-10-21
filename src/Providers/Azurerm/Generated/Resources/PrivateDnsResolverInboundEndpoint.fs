namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId> = { assignments: ResizeArray<azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint">azurerm_private_dns_resolver_inbound_endpoint</a>.
    /// </summary>
    type PrivateDnsResolverInboundEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverInboundEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverInboundEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverInboundEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverInboundEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// ip_configurations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#ip_configurations-1">PrivateDnsResolverInboundEndpoint#ip_configurations</a>
        /// </summary>
        [<CustomOperation "ip_configurations">]
        member _.IpConfigurations(state: PrivateDnsResolverInboundEndpointState<Missing, 'Location, 'Name, 'PrivateDnsResolverId>, value: azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpointIpConfigurations) : PrivateDnsResolverInboundEndpointState<Present, 'Location, 'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.IpConfigurations <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverInboundEndpointState<Present, 'Location, 'Name, 'PrivateDnsResolverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#location-1">PrivateDnsResolverInboundEndpoint#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, Missing, 'Name, 'PrivateDnsResolverId>, value: string) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, Present, 'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverInboundEndpointState<'IpConfigurations, Present, 'Name, 'PrivateDnsResolverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#name-1">PrivateDnsResolverInboundEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, Missing, 'PrivateDnsResolverId>, value: string) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, Present, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, Present, 'PrivateDnsResolverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#private_dns_resolver_id-1">PrivateDnsResolverInboundEndpoint#private_dns_resolver_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_resolver_id">]
        member _.PrivateDnsResolverId(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, Missing>, value: string) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateDnsResolverId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#id-1">PrivateDnsResolverInboundEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>, value: string) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#tags-1">PrivateDnsResolverInboundEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>, value: seq<string * string>) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_inbound_endpoint#timeouts-1">PrivateDnsResolverInboundEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>, value: azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpointTimeouts) : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverInboundEndpointState<'IpConfigurations, 'Location, 'Name, 'PrivateDnsResolverId>

        member _.Run(state: PrivateDnsResolverInboundEndpointState<Present, Present, Present, Present>) : azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpoint =
            let config = azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolverInboundEndpoint: missing required arguments. Must call: ip_configurations, location, name, private_dns_resolver_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverInboundEndpointState<_, _, _, _>) : azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpoint =
            Unchecked.defaultof<azurerm.PrivateDnsResolverInboundEndpoint.PrivateDnsResolverInboundEndpoint>
