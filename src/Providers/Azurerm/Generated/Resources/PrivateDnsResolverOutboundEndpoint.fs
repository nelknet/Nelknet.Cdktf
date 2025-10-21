namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId> = { assignments: ResizeArray<azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint">azurerm_private_dns_resolver_outbound_endpoint</a>.
    /// </summary>
    type PrivateDnsResolverOutboundEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverOutboundEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverOutboundEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverOutboundEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverOutboundEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#location-1">PrivateDnsResolverOutboundEndpoint#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateDnsResolverOutboundEndpointState<Missing, 'Name, 'PrivateDnsResolverId, 'SubnetId>, value: string) : PrivateDnsResolverOutboundEndpointState<Present, 'Name, 'PrivateDnsResolverId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverOutboundEndpointState<Present, 'Name, 'PrivateDnsResolverId, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#name-1">PrivateDnsResolverOutboundEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverOutboundEndpointState<'Location, Missing, 'PrivateDnsResolverId, 'SubnetId>, value: string) : PrivateDnsResolverOutboundEndpointState<'Location, Present, 'PrivateDnsResolverId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverOutboundEndpointState<'Location, Present, 'PrivateDnsResolverId, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#private_dns_resolver_id-1">PrivateDnsResolverOutboundEndpoint#private_dns_resolver_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_resolver_id">]
        member _.PrivateDnsResolverId(state: PrivateDnsResolverOutboundEndpointState<'Location, 'Name, Missing, 'SubnetId>, value: string) : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateDnsResolverId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#subnet_id-1">PrivateDnsResolverOutboundEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, Missing>, value: string) : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#id-1">PrivateDnsResolverOutboundEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>, value: string) : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#tags-1">PrivateDnsResolverOutboundEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>, value: seq<string * string>) : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver_outbound_endpoint#timeouts-1">PrivateDnsResolverOutboundEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>, value: azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpointTimeouts) : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverOutboundEndpointState<'Location, 'Name, 'PrivateDnsResolverId, 'SubnetId>

        member _.Run(state: PrivateDnsResolverOutboundEndpointState<Present, Present, Present, Present>) : azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpoint =
            let config = azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolverOutboundEndpoint: missing required arguments. Must call: location, name, private_dns_resolver_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverOutboundEndpointState<_, _, _, _>) : azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpoint =
            Unchecked.defaultof<azurerm.PrivateDnsResolverOutboundEndpoint.PrivateDnsResolverOutboundEndpoint>
