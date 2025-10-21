namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> = { assignments: ResizeArray<azurerm.MobileNetworkSlice.MobileNetworkSliceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice">azurerm_mobile_network_slice</a>.
    /// </summary>
    type MobileNetworkSliceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkSliceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSliceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkSliceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSliceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#location-1">MobileNetworkSlice#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkSliceState<Missing, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: string) : MobileNetworkSliceState<Present, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkSliceState<Present, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#mobile_network_id-1">MobileNetworkSlice#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkSliceState<'Location, Missing, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: string) : MobileNetworkSliceState<'Location, Present, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkSliceState<'Location, Present, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#name-1">MobileNetworkSlice#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, Missing, 'SingleNetworkSliceSelectionAssistanceInformation>, value: string) : MobileNetworkSliceState<'Location, 'MobileNetworkId, Present, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkSliceState<'Location, 'MobileNetworkId, Present, 'SingleNetworkSliceSelectionAssistanceInformation>)

        /// <summary>
        /// single_network_slice_selection_assistance_information block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#single_network_slice_selection_assistance_information-1">MobileNetworkSlice#single_network_slice_selection_assistance_information</a>
        /// </summary>
        [<CustomOperation "single_network_slice_selection_assistance_information">]
        member _.SingleNetworkSliceSelectionAssistanceInformation(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, Missing>, value: azurerm.MobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation) : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SingleNetworkSliceSelectionAssistanceInformation <- value)
            ({ assignments = state.assignments } : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#description-1">MobileNetworkSlice#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: string) : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#id-1">MobileNetworkSlice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: string) : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#tags-1">MobileNetworkSlice#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: seq<string * string>) : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#timeouts-1">MobileNetworkSlice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>, value: azurerm.MobileNetworkSlice.MobileNetworkSliceTimeouts) : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkSliceState<'Location, 'MobileNetworkId, 'Name, 'SingleNetworkSliceSelectionAssistanceInformation>

        member _.Run(state: MobileNetworkSliceState<Present, Present, Present, Present>) : azurerm.MobileNetworkSlice.MobileNetworkSlice =
            let config = azurerm.MobileNetworkSlice.MobileNetworkSliceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkSlice.MobileNetworkSlice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkSlice: missing required arguments. Must call: location, mobile_network_id, name, single_network_slice_selection_assistance_information.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkSliceState<_, _, _, _>) : azurerm.MobileNetworkSlice.MobileNetworkSlice =
            Unchecked.defaultof<azurerm.MobileNetworkSlice.MobileNetworkSlice>
