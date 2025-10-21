namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.MobileNetworkSimGroup.MobileNetworkSimGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group">azurerm_mobile_network_sim_group</a>.
    /// </summary>
    type MobileNetworkSimGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkSimGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkSimGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#location-1">MobileNetworkSimGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkSimGroupState<Missing, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkSimGroupState<Present, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkSimGroupState<Present, 'MobileNetworkId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#mobile_network_id-1">MobileNetworkSimGroup#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkSimGroupState<'Location, Missing, 'Name>, value: string) : MobileNetworkSimGroupState<'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkSimGroupState<'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#name-1">MobileNetworkSimGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, Missing>, value: string) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#encryption_key_url-1">MobileNetworkSimGroup#encryption_key_url</a>.
        /// </summary>
        [<CustomOperation "encryption_key_url">]
        member _.EncryptionKeyUrl(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionKeyUrl <- value)
            state : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#id-1">MobileNetworkSimGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#identity-1">MobileNetworkSimGroup#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>, value: azurerm.MobileNetworkSimGroup.MobileNetworkSimGroupIdentity) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#tags-1">MobileNetworkSimGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>, value: seq<string * string>) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#timeouts-1">MobileNetworkSimGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>, value: azurerm.MobileNetworkSimGroup.MobileNetworkSimGroupTimeouts) : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkSimGroupState<'Location, 'MobileNetworkId, 'Name>

        member _.Run(state: MobileNetworkSimGroupState<Present, Present, Present>) : azurerm.MobileNetworkSimGroup.MobileNetworkSimGroup =
            let config = azurerm.MobileNetworkSimGroup.MobileNetworkSimGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkSimGroup.MobileNetworkSimGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkSimGroup: missing required arguments. Must call: location, mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkSimGroupState<_, _, _>) : azurerm.MobileNetworkSimGroup.MobileNetworkSimGroup =
            Unchecked.defaultof<azurerm.MobileNetworkSimGroup.MobileNetworkSimGroup>
