namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAdvisorRecommendationsState = { assignments: ResizeArray<azurerm.DataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations">azurerm_advisor_recommendations</a>.
    /// </summary>
    type DataAzurermAdvisorRecommendationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAdvisorRecommendationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermAdvisorRecommendationsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#filter_by_category-1">DataAzurermAdvisorRecommendations#filter_by_category</a>.
        /// </summary>
        [<CustomOperation "filter_by_category">]
        member _.FilterByCategory(state: DataAzurermAdvisorRecommendationsState, value: seq<string>) : DataAzurermAdvisorRecommendationsState =
            state.assignments.Add(fun config -> config.FilterByCategory <- (value |> Seq.toArray))
            state : DataAzurermAdvisorRecommendationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#filter_by_resource_groups-1">DataAzurermAdvisorRecommendations#filter_by_resource_groups</a>.
        /// </summary>
        [<CustomOperation "filter_by_resource_groups">]
        member _.FilterByResourceGroups(state: DataAzurermAdvisorRecommendationsState, value: seq<string>) : DataAzurermAdvisorRecommendationsState =
            state.assignments.Add(fun config -> config.FilterByResourceGroups <- (value |> Seq.toArray))
            state : DataAzurermAdvisorRecommendationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#id-1">DataAzurermAdvisorRecommendations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAdvisorRecommendationsState, value: string) : DataAzurermAdvisorRecommendationsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAdvisorRecommendationsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/advisor_recommendations#timeouts-1">DataAzurermAdvisorRecommendations#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAdvisorRecommendationsState, value: azurerm.DataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsTimeouts) : DataAzurermAdvisorRecommendationsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAdvisorRecommendationsState

        member _.Run(state: DataAzurermAdvisorRecommendationsState) : azurerm.DataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendations =
            let config = azurerm.DataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendationsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAdvisorRecommendations.DataAzurermAdvisorRecommendations(StackContext.get (), logicalId, config)
