namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> = { assignments: ResizeArray<azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment">azurerm_management_group_template_deployment</a>.
    /// </summary>
    type ManagementGroupTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupTemplateDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupTemplateDeploymentState<Missing, Missing, Missing>)

        member _.Zero(()) : ManagementGroupTemplateDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupTemplateDeploymentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#location-1">ManagementGroupTemplateDeployment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagementGroupTemplateDeploymentState<Missing, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<Present, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ManagementGroupTemplateDeploymentState<Present, 'ManagementGroupId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#management_group_id-1">ManagementGroupTemplateDeployment#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ManagementGroupTemplateDeploymentState<'Location, Missing, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ManagementGroupTemplateDeploymentState<'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#name-1">ManagementGroupTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, Missing>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#debug_level-1">ManagementGroupTemplateDeployment#debug_level</a>.
        /// </summary>
        [<CustomOperation "debug_level">]
        member _.DebugLevel(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.DebugLevel <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#id-1">ManagementGroupTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#parameters_content-1">ManagementGroupTemplateDeployment#parameters_content</a>.
        /// </summary>
        [<CustomOperation "parameters_content">]
        member _.ParametersContent(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.ParametersContent <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#tags-1">ManagementGroupTemplateDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: seq<string * string>) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#template_content-1">ManagementGroupTemplateDeployment#template_content</a>.
        /// </summary>
        [<CustomOperation "template_content">]
        member _.TemplateContent(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.TemplateContent <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#template_spec_version_id-1">ManagementGroupTemplateDeployment#template_spec_version_id</a>.
        /// </summary>
        [<CustomOperation "template_spec_version_id">]
        member _.TemplateSpecVersionId(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: string) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.TemplateSpecVersionId <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_template_deployment#timeouts-1">ManagementGroupTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>, value: azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeploymentTimeouts) : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupTemplateDeploymentState<'Location, 'ManagementGroupId, 'Name>

        member _.Run(state: ManagementGroupTemplateDeploymentState<Present, Present, Present>) : azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeployment =
            let config = azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementGroupTemplateDeployment: missing required arguments. Must call: location, management_group_id, name.", 9999, IsError = true)>]
        member _.Run(_: ManagementGroupTemplateDeploymentState<_, _, _>) : azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeployment =
            Unchecked.defaultof<azurerm.ManagementGroupTemplateDeployment.ManagementGroupTemplateDeployment>
