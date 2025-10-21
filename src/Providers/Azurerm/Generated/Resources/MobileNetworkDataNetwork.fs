namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network">azurerm_mobile_network_data_network</a>.
    /// </summary>
    type MobileNetworkDataNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkDataNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkDataNetworkState<Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkDataNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkDataNetworkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#location-1">MobileNetworkDataNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkDataNetworkState<Missing, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkDataNetworkState<Present, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkDataNetworkState<Present, 'MobileNetworkId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#mobile_network_id-1">MobileNetworkDataNetwork#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkDataNetworkState<'Location, Missing, 'Name>, value: string) : MobileNetworkDataNetworkState<'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkDataNetworkState<'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#name-1">MobileNetworkDataNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, Missing>, value: string) : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#description-1">MobileNetworkDataNetwork#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#id-1">MobileNetworkDataNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#tags-1">MobileNetworkDataNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>, value: seq<string * string>) : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_data_network#timeouts-1">MobileNetworkDataNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>, value: azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetworkTimeouts) : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkDataNetworkState<'Location, 'MobileNetworkId, 'Name>

        member _.Run(state: MobileNetworkDataNetworkState<Present, Present, Present>) : azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetwork =
            let config = azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkDataNetwork: missing required arguments. Must call: location, mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkDataNetworkState<_, _, _>) : azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetwork =
            Unchecked.defaultof<azurerm.MobileNetworkDataNetwork.MobileNetworkDataNetwork>
