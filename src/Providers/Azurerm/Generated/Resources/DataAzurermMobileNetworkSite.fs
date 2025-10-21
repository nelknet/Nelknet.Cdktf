namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site">azurerm_mobile_network_site</a>.
    /// </summary>
    type DataAzurermMobileNetworkSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSiteState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSiteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#mobile_network_id-1">DataAzurermMobileNetworkSite#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkSiteState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkSiteState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSiteState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#name-1">DataAzurermMobileNetworkSite#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkSiteState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkSiteState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSiteState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#id-1">DataAzurermMobileNetworkSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_site#timeouts-1">DataAzurermMobileNetworkSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteTimeouts) : DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkSiteState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkSiteState<Present, Present>) : azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSite =
            let config = azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSiteConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkSite: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkSiteState<_, _>) : azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSite =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkSite.DataAzurermMobileNetworkSite>
