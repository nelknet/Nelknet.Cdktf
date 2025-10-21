namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter">azurerm_media_services_account_filter</a>.
    /// </summary>
    type MediaServicesAccountFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaServicesAccountFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MediaServicesAccountFilterState<Missing, Missing, Missing>)

        member _.Zero(()) : MediaServicesAccountFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MediaServicesAccountFilterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#media_services_account_name-1">MediaServicesAccountFilter#media_services_account_name</a>.
        /// </summary>
        [<CustomOperation "media_services_account_name">]
        member _.MediaServicesAccountName(state: MediaServicesAccountFilterState<Missing, 'Name, 'ResourceGroupName>, value: string) : MediaServicesAccountFilterState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MediaServicesAccountName <- value)
            ({ assignments = state.assignments } : MediaServicesAccountFilterState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#name-1">MediaServicesAccountFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MediaServicesAccountFilterState<'MediaServicesAccountName, Missing, 'ResourceGroupName>, value: string) : MediaServicesAccountFilterState<'MediaServicesAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MediaServicesAccountFilterState<'MediaServicesAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#resource_group_name-1">MediaServicesAccountFilter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, Missing>, value: string) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#first_quality_bitrate-1">MediaServicesAccountFilter#first_quality_bitrate</a>.
        /// </summary>
        [<CustomOperation "first_quality_bitrate">]
        member _.FirstQualityBitrate(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>, value: double) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FirstQualityBitrate <- value)
            state : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#id-1">MediaServicesAccountFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>, value: string) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// presentation_time_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#presentation_time_range-1">MediaServicesAccountFilter#presentation_time_range</a>
        /// </summary>
        [<CustomOperation "presentation_time_range">]
        member _.PresentationTimeRange(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>, value: azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PresentationTimeRange <- value)
            state : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#timeouts-1">MediaServicesAccountFilter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>, value: azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTimeouts) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// track_selection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#track_selection-1">MediaServicesAccountFilter#track_selection</a> Accepts: azurerm.IResolvable | azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection[]
        /// </summary>
        [<CustomOperation "track_selection">]
        member _.TrackSelection(state: MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TrackSelection <- value)
            state : MediaServicesAccountFilterState<'MediaServicesAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: MediaServicesAccountFilterState<Present, Present, Present>) : azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter =
            let config = azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterConfig()
            for setter in state.assignments do
                setter config
            azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mediaServicesAccountFilter: missing required arguments. Must call: media_services_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MediaServicesAccountFilterState<_, _, _>) : azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter =
            Unchecked.defaultof<azurerm.MediaServicesAccountFilter.MediaServicesAccountFilter>
