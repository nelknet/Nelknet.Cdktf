namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkProfile.NetworkProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile">azurerm_network_profile</a>.
    /// </summary>
    type NetworkProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkProfileState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkProfileState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// container_network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#container_network_interface-1">NetworkProfile#container_network_interface</a>
        /// </summary>
        [<CustomOperation "container_network_interface">]
        member _.ContainerNetworkInterface(state: NetworkProfileState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkProfile.NetworkProfileContainerNetworkInterface) : NetworkProfileState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerNetworkInterface <- value)
            ({ assignments = state.assignments } : NetworkProfileState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#location-1">NetworkProfile#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkProfileState<'ContainerNetworkInterface, Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkProfileState<'ContainerNetworkInterface, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkProfileState<'ContainerNetworkInterface, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#name-1">NetworkProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkProfileState<'ContainerNetworkInterface, 'Location, Missing, 'ResourceGroupName>, value: string) : NetworkProfileState<'ContainerNetworkInterface, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkProfileState<'ContainerNetworkInterface, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#resource_group_name-1">NetworkProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, Missing>, value: string) : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#id-1">NetworkProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#tags-1">NetworkProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_profile#timeouts-1">NetworkProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkProfile.NetworkProfileTimeouts) : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkProfileState<'ContainerNetworkInterface, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkProfileState<Present, Present, Present, Present>) : azurerm.NetworkProfile.NetworkProfile =
            let config = azurerm.NetworkProfile.NetworkProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkProfile.NetworkProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkProfile: missing required arguments. Must call: container_network_interface, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkProfileState<_, _, _, _>) : azurerm.NetworkProfile.NetworkProfile =
            Unchecked.defaultof<azurerm.NetworkProfile.NetworkProfile>
