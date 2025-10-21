namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName> = { assignments: ResizeArray<azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template">azurerm_api_management_email_template</a>.
    /// </summary>
    type ApiManagementEmailTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementEmailTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementEmailTemplateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementEmailTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementEmailTemplateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#api_management_name-1">ApiManagementEmailTemplate#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementEmailTemplateState<Missing, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>, value: string) : ApiManagementEmailTemplateState<Present, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementEmailTemplateState<Present, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#body-1">ApiManagementEmailTemplate#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: ApiManagementEmailTemplateState<'ApiManagementName, Missing, 'ResourceGroupName, 'Subject, 'TemplateName>, value: string) : ApiManagementEmailTemplateState<'ApiManagementName, Present, 'ResourceGroupName, 'Subject, 'TemplateName> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : ApiManagementEmailTemplateState<'ApiManagementName, Present, 'ResourceGroupName, 'Subject, 'TemplateName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#resource_group_name-1">ApiManagementEmailTemplate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementEmailTemplateState<'ApiManagementName, 'Body, Missing, 'Subject, 'TemplateName>, value: string) : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, Present, 'Subject, 'TemplateName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, Present, 'Subject, 'TemplateName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#subject-1">ApiManagementEmailTemplate#subject</a>.
        /// </summary>
        [<CustomOperation "subject">]
        member _.Subject(state: ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, Missing, 'TemplateName>, value: string) : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, Present, 'TemplateName> =
            state.assignments.Add(fun config -> config.Subject <- value)
            ({ assignments = state.assignments } : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, Present, 'TemplateName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#template_name-1">ApiManagementEmailTemplate#template_name</a>.
        /// </summary>
        [<CustomOperation "template_name">]
        member _.TemplateName(state: ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, Missing>, value: string) : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, Present> =
            state.assignments.Add(fun config -> config.TemplateName <- value)
            ({ assignments = state.assignments } : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#id-1">ApiManagementEmailTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>, value: string) : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_email_template#timeouts-1">ApiManagementEmailTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>, value: azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplateTimeouts) : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementEmailTemplateState<'ApiManagementName, 'Body, 'ResourceGroupName, 'Subject, 'TemplateName>

        member _.Run(state: ApiManagementEmailTemplateState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplate =
            let config = azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplateConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementEmailTemplate: missing required arguments. Must call: api_management_name, body, resource_group_name, subject, template_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementEmailTemplateState<_, _, _, _, _>) : azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplate =
            Unchecked.defaultof<azurerm.ApiManagementEmailTemplate.ApiManagementEmailTemplate>
