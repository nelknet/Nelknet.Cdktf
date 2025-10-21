namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.FluidRelayServer.FluidRelayServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server">azurerm_fluid_relay_server</a>.
    /// </summary>
    type FluidRelayServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : FluidRelayServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FluidRelayServerState<Missing, Missing, Missing>)

        member _.Zero(()) : FluidRelayServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FluidRelayServerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#location-1">FluidRelayServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: FluidRelayServerState<Missing, 'Name, 'ResourceGroupName>, value: string) : FluidRelayServerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : FluidRelayServerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#name-1">FluidRelayServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FluidRelayServerState<'Location, Missing, 'ResourceGroupName>, value: string) : FluidRelayServerState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FluidRelayServerState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#resource_group_name-1">FluidRelayServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FluidRelayServerState<'Location, 'Name, Missing>, value: string) : FluidRelayServerState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FluidRelayServerState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#id-1">FluidRelayServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#identity-1">FluidRelayServer#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FluidRelayServer.FluidRelayServerIdentity) : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#storage_sku-1">FluidRelayServer#storage_sku</a>.
        /// </summary>
        [<CustomOperation "storage_sku">]
        member _.StorageSku(state: FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageSku <- value)
            state : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#tags-1">FluidRelayServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/fluid_relay_server#timeouts-1">FluidRelayServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FluidRelayServer.FluidRelayServerTimeouts) : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FluidRelayServerState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: FluidRelayServerState<Present, Present, Present>) : azurerm.FluidRelayServer.FluidRelayServer =
            let config = azurerm.FluidRelayServer.FluidRelayServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.FluidRelayServer.FluidRelayServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.fluidRelayServer: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: FluidRelayServerState<_, _, _>) : azurerm.FluidRelayServer.FluidRelayServer =
            Unchecked.defaultof<azurerm.FluidRelayServer.FluidRelayServer>
