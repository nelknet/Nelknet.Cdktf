namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId> = { assignments: ResizeArray<azurerm.PrivateDnsResolver.PrivateDnsResolverConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver">azurerm_private_dns_resolver</a>.
    /// </summary>
    type PrivateDnsResolverBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsResolverState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsResolverState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsResolverState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#location-1">PrivateDnsResolver#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateDnsResolverState<Missing, 'Name, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsResolverState<Present, 'Name, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverState<Present, 'Name, 'ResourceGroupName, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#name-1">PrivateDnsResolver#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsResolverState<'Location, Missing, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsResolverState<'Location, Present, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverState<'Location, Present, 'ResourceGroupName, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#resource_group_name-1">PrivateDnsResolver#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsResolverState<'Location, 'Name, Missing, 'VirtualNetworkId>, value: string) : PrivateDnsResolverState<'Location, 'Name, Present, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverState<'Location, 'Name, Present, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#virtual_network_id-1">PrivateDnsResolver#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            ({ assignments = state.assignments } : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#id-1">PrivateDnsResolver#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#tags-1">PrivateDnsResolver#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>, value: seq<string * string>) : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_resolver#timeouts-1">PrivateDnsResolver#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>, value: azurerm.PrivateDnsResolver.PrivateDnsResolverTimeouts) : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsResolverState<'Location, 'Name, 'ResourceGroupName, 'VirtualNetworkId>

        member _.Run(state: PrivateDnsResolverState<Present, Present, Present, Present>) : azurerm.PrivateDnsResolver.PrivateDnsResolver =
            let config = azurerm.PrivateDnsResolver.PrivateDnsResolverConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsResolver.PrivateDnsResolver(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsResolver: missing required arguments. Must call: location, name, resource_group_name, virtual_network_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsResolverState<_, _, _, _>) : azurerm.PrivateDnsResolver.PrivateDnsResolver =
            Unchecked.defaultof<azurerm.PrivateDnsResolver.PrivateDnsResolver>
