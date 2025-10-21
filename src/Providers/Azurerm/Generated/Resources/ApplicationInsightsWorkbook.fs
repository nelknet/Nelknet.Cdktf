namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook">azurerm_application_insights_workbook</a>.
    /// </summary>
    type ApplicationInsightsWorkbookBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsWorkbookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWorkbookState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsWorkbookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWorkbookState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#data_json-1">ApplicationInsightsWorkbook#data_json</a>.
        /// </summary>
        [<CustomOperation "data_json">]
        member _.DataJson(state: ApplicationInsightsWorkbookState<Missing, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<Present, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataJson <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookState<Present, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#display_name-1">ApplicationInsightsWorkbook#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApplicationInsightsWorkbookState<'DataJson, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookState<'DataJson, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#location-1">ApplicationInsightsWorkbook#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, Missing, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#name-1">ApplicationInsightsWorkbook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, Missing, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#resource_group_name-1">ApplicationInsightsWorkbook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, Missing>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#category-1">ApplicationInsightsWorkbook#category</a>.
        /// </summary>
        [<CustomOperation "category">]
        member _.Category(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Category <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#description-1">ApplicationInsightsWorkbook#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#id-1">ApplicationInsightsWorkbook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#identity-1">ApplicationInsightsWorkbook#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbookIdentity) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#source_id-1">ApplicationInsightsWorkbook#source_id</a>.
        /// </summary>
        [<CustomOperation "source_id">]
        member _.SourceId(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceId <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#storage_container_id-1">ApplicationInsightsWorkbook#storage_container_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_id">]
        member _.StorageContainerId(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageContainerId <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#tags-1">ApplicationInsightsWorkbook#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook#timeouts-1">ApplicationInsightsWorkbook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbookTimeouts) : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsWorkbookState<'DataJson, 'DisplayName, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ApplicationInsightsWorkbookState<Present, Present, Present, Present, Present>) : azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbook =
            let config = azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbookConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsWorkbook: missing required arguments. Must call: data_json, display_name, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsWorkbookState<_, _, _, _, _>) : azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbook =
            Unchecked.defaultof<azurerm.ApplicationInsightsWorkbook.ApplicationInsightsWorkbook>
