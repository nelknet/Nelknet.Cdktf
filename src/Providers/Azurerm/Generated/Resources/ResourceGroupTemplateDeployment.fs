namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment">azurerm_resource_group_template_deployment</a>.
    /// </summary>
    type ResourceGroupTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupTemplateDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupTemplateDeploymentState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupTemplateDeploymentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupTemplateDeploymentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#deployment_mode-1">ResourceGroupTemplateDeployment#deployment_mode</a>.
        /// </summary>
        [<CustomOperation "deployment_mode">]
        member _.DeploymentMode(state: ResourceGroupTemplateDeploymentState<Missing, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeploymentMode <- value)
            ({ assignments = state.assignments } : ResourceGroupTemplateDeploymentState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#name-1">ResourceGroupTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, Missing, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupTemplateDeploymentState<'DeploymentMode, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#resource_group_name-1">ResourceGroupTemplateDeployment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, Missing>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#debug_level-1">ResourceGroupTemplateDeployment#debug_level</a>.
        /// </summary>
        [<CustomOperation "debug_level">]
        member _.DebugLevel(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DebugLevel <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#id-1">ResourceGroupTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#parameters_content-1">ResourceGroupTemplateDeployment#parameters_content</a>.
        /// </summary>
        [<CustomOperation "parameters_content">]
        member _.ParametersContent(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ParametersContent <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#tags-1">ResourceGroupTemplateDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#template_content-1">ResourceGroupTemplateDeployment#template_content</a>.
        /// </summary>
        [<CustomOperation "template_content">]
        member _.TemplateContent(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TemplateContent <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#template_spec_version_id-1">ResourceGroupTemplateDeployment#template_spec_version_id</a>.
        /// </summary>
        [<CustomOperation "template_spec_version_id">]
        member _.TemplateSpecVersionId(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: string) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TemplateSpecVersionId <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_template_deployment#timeouts-1">ResourceGroupTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>, value: azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeploymentTimeouts) : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupTemplateDeploymentState<'DeploymentMode, 'Name, 'ResourceGroupName>

        member _.Run(state: ResourceGroupTemplateDeploymentState<Present, Present, Present>) : azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeployment =
            let config = azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupTemplateDeployment: missing required arguments. Must call: deployment_mode, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupTemplateDeploymentState<_, _, _>) : azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeployment =
            Unchecked.defaultof<azurerm.ResourceGroupTemplateDeployment.ResourceGroupTemplateDeployment>
