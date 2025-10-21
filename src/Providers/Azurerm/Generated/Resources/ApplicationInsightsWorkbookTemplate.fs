namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> = { assignments: ResizeArray<azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template">azurerm_application_insights_workbook_template</a>.
    /// </summary>
    type ApplicationInsightsWorkbookTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsWorkbookTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWorkbookTemplateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsWorkbookTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsWorkbookTemplateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// galleries block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#galleries-1">ApplicationInsightsWorkbookTemplate#galleries</a> Accepts: azurerm.IResolvable | azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplateGalleries[]
        /// </summary>
        [<CustomOperation "galleries">]
        member _.Galleries(state: ApplicationInsightsWorkbookTemplateState<Missing, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsWorkbookTemplateState<Present, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Galleries <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookTemplateState<Present, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#location-1">ApplicationInsightsWorkbookTemplate#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationInsightsWorkbookTemplateState<'Galleries, Missing, 'Name, 'ResourceGroupName, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, Present, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookTemplateState<'Galleries, Present, 'Name, 'ResourceGroupName, 'TemplateData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#name-1">ApplicationInsightsWorkbookTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, Missing, 'ResourceGroupName, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, Present, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, Present, 'ResourceGroupName, 'TemplateData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#resource_group_name-1">ApplicationInsightsWorkbookTemplate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, Missing, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, Present, 'TemplateData> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, Present, 'TemplateData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#template_data-1">ApplicationInsightsWorkbookTemplate#template_data</a>.
        /// </summary>
        [<CustomOperation "template_data">]
        member _.TemplateData(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.TemplateData <- value)
            ({ assignments = state.assignments } : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#author-1">ApplicationInsightsWorkbookTemplate#author</a>.
        /// </summary>
        [<CustomOperation "author">]
        member _.Author(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Author <- value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#id-1">ApplicationInsightsWorkbookTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#localized-1">ApplicationInsightsWorkbookTemplate#localized</a>.
        /// </summary>
        [<CustomOperation "localized">]
        member _.Localized(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: string) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Localized <- value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#priority-1">ApplicationInsightsWorkbookTemplate#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: double) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#tags-1">ApplicationInsightsWorkbookTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: seq<string * string>) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_workbook_template#timeouts-1">ApplicationInsightsWorkbookTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>, value: azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplateTimeouts) : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsWorkbookTemplateState<'Galleries, 'Location, 'Name, 'ResourceGroupName, 'TemplateData>

        member _.Run(state: ApplicationInsightsWorkbookTemplateState<Present, Present, Present, Present, Present>) : azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplate =
            let config = azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplateConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsightsWorkbookTemplate: missing required arguments. Must call: galleries, location, name, resource_group_name, template_data.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsWorkbookTemplateState<_, _, _, _, _>) : azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplate =
            Unchecked.defaultof<azurerm.ApplicationInsightsWorkbookTemplate.ApplicationInsightsWorkbookTemplate>
