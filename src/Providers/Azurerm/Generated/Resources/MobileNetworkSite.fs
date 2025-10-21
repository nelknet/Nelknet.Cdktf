namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.MobileNetworkSite.MobileNetworkSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site">azurerm_mobile_network_site</a>.
    /// </summary>
    type MobileNetworkSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkSiteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSiteState<Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkSiteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSiteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#location-1">MobileNetworkSite#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkSiteState<Missing, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkSiteState<Present, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkSiteState<Present, 'MobileNetworkId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#mobile_network_id-1">MobileNetworkSite#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkSiteState<'Location, Missing, 'Name>, value: string) : MobileNetworkSiteState<'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkSiteState<'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#name-1">MobileNetworkSite#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkSiteState<'Location, 'MobileNetworkId, Missing>, value: string) : MobileNetworkSiteState<'Location, 'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkSiteState<'Location, 'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#id-1">MobileNetworkSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>, value: string) : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#tags-1">MobileNetworkSite#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>, value: seq<string * string>) : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_site#timeouts-1">MobileNetworkSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>, value: azurerm.MobileNetworkSite.MobileNetworkSiteTimeouts) : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkSiteState<'Location, 'MobileNetworkId, 'Name>

        member _.Run(state: MobileNetworkSiteState<Present, Present, Present>) : azurerm.MobileNetworkSite.MobileNetworkSite =
            let config = azurerm.MobileNetworkSite.MobileNetworkSiteConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkSite.MobileNetworkSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkSite: missing required arguments. Must call: location, mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkSiteState<_, _, _>) : azurerm.MobileNetworkSite.MobileNetworkSite =
            Unchecked.defaultof<azurerm.MobileNetworkSite.MobileNetworkSite>
