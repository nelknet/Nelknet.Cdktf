namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type> = { assignments: ResizeArray<azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item">azurerm_application_insights_analytics_item</a>.
    /// </summary>
    type ApplicationInsightsAnalyticsItemBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsAnalyticsItemState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsAnalyticsItemState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsAnalyticsItemState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsAnalyticsItemState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#application_insights_id-1">ApplicationInsightsAnalyticsItem#application_insights_id</a>.
        /// </summary>
        [<CustomOperation "application_insights_id">]
        member _.ApplicationInsightsId(state: ApplicationInsightsAnalyticsItemState<Missing, 'Content, 'Name, 'Scope, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<Present, 'Content, 'Name, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.ApplicationInsightsId <- value)
            ({ assignments = state.assignments } : ApplicationInsightsAnalyticsItemState<Present, 'Content, 'Name, 'Scope, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#content-1">ApplicationInsightsAnalyticsItem#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, Missing, 'Name, 'Scope, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, Present, 'Name, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, Present, 'Name, 'Scope, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#name-1">ApplicationInsightsAnalyticsItem#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, Missing, 'Scope, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, Present, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, Present, 'Scope, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#scope-1">ApplicationInsightsAnalyticsItem#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, Missing, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#type-1">ApplicationInsightsAnalyticsItem#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, Missing>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#function_alias-1">ApplicationInsightsAnalyticsItem#function_alias</a>.
        /// </summary>
        [<CustomOperation "function_alias">]
        member _.FunctionAlias(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.FunctionAlias <- value)
            state : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#id-1">ApplicationInsightsAnalyticsItem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>, value: string) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_analytics_item#timeouts-1">ApplicationInsightsAnalyticsItem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>, value: azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItemTimeouts) : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsAnalyticsItemState<'ApplicationInsightsId, 'Content, 'Name, 'Scope, 'Type>

        member _.Run(state: ApplicationInsightsAnalyticsItemState<Present, Present, Present, Present, Present>) : azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItem =
            let config = azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItemConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsAnalyticsItem: missing required arguments. Must call: application_insights_id, content, name, scope, type.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsAnalyticsItemState<_, _, _, _, _>) : azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItem =
            Unchecked.defaultof<azurerm.ApplicationInsightsAnalyticsItem.ApplicationInsightsAnalyticsItem>
