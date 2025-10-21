namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MobileNetwork.MobileNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network">azurerm_mobile_network</a>.
    /// </summary>
    type MobileNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#location-1">MobileNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkState<Missing, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>, value: string) : MobileNetworkState<Present, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkState<Present, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#mobile_country_code-1">MobileNetwork#mobile_country_code</a>.
        /// </summary>
        [<CustomOperation "mobile_country_code">]
        member _.MobileCountryCode(state: MobileNetworkState<'Location, Missing, 'MobileNetworkCode, 'Name, 'ResourceGroupName>, value: string) : MobileNetworkState<'Location, Present, 'MobileNetworkCode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MobileCountryCode <- value)
            ({ assignments = state.assignments } : MobileNetworkState<'Location, Present, 'MobileNetworkCode, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#mobile_network_code-1">MobileNetwork#mobile_network_code</a>.
        /// </summary>
        [<CustomOperation "mobile_network_code">]
        member _.MobileNetworkCode(state: MobileNetworkState<'Location, 'MobileCountryCode, Missing, 'Name, 'ResourceGroupName>, value: string) : MobileNetworkState<'Location, 'MobileCountryCode, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MobileNetworkCode <- value)
            ({ assignments = state.assignments } : MobileNetworkState<'Location, 'MobileCountryCode, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#name-1">MobileNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, Missing, 'ResourceGroupName>, value: string) : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#resource_group_name-1">MobileNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, Missing>, value: string) : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#id-1">MobileNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>, value: string) : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#tags-1">MobileNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network#timeouts-1">MobileNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>, value: azurerm.MobileNetwork.MobileNetworkTimeouts) : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkState<'Location, 'MobileCountryCode, 'MobileNetworkCode, 'Name, 'ResourceGroupName>

        member _.Run(state: MobileNetworkState<Present, Present, Present, Present, Present>) : azurerm.MobileNetwork.MobileNetwork =
            let config = azurerm.MobileNetwork.MobileNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetwork.MobileNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetwork: missing required arguments. Must call: location, mobile_country_code, mobile_network_code, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkState<_, _, _, _, _>) : azurerm.MobileNetwork.MobileNetwork =
            Unchecked.defaultof<azurerm.MobileNetwork.MobileNetwork>
