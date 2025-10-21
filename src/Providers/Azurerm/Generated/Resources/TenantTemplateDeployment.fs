namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TenantTemplateDeploymentState<'Location, 'Name> = { assignments: ResizeArray<azurerm.TenantTemplateDeployment.TenantTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment">azurerm_tenant_template_deployment</a>.
    /// </summary>
    type TenantTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : TenantTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TenantTemplateDeploymentState<Missing, Missing>)

        member _.Zero(()) : TenantTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TenantTemplateDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#location-1">TenantTemplateDeployment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: TenantTemplateDeploymentState<Missing, 'Name>, value: string) : TenantTemplateDeploymentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : TenantTemplateDeploymentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#name-1">TenantTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TenantTemplateDeploymentState<'Location, Missing>, value: string) : TenantTemplateDeploymentState<'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TenantTemplateDeploymentState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#debug_level-1">TenantTemplateDeployment#debug_level</a>.
        /// </summary>
        [<CustomOperation "debug_level">]
        member _.DebugLevel(state: TenantTemplateDeploymentState<'Location, 'Name>, value: string) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.DebugLevel <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#id-1">TenantTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TenantTemplateDeploymentState<'Location, 'Name>, value: string) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#parameters_content-1">TenantTemplateDeployment#parameters_content</a>.
        /// </summary>
        [<CustomOperation "parameters_content">]
        member _.ParametersContent(state: TenantTemplateDeploymentState<'Location, 'Name>, value: string) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.ParametersContent <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#tags-1">TenantTemplateDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TenantTemplateDeploymentState<'Location, 'Name>, value: seq<string * string>) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#template_content-1">TenantTemplateDeployment#template_content</a>.
        /// </summary>
        [<CustomOperation "template_content">]
        member _.TemplateContent(state: TenantTemplateDeploymentState<'Location, 'Name>, value: string) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.TemplateContent <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#template_spec_version_id-1">TenantTemplateDeployment#template_spec_version_id</a>.
        /// </summary>
        [<CustomOperation "template_spec_version_id">]
        member _.TemplateSpecVersionId(state: TenantTemplateDeploymentState<'Location, 'Name>, value: string) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.TemplateSpecVersionId <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/tenant_template_deployment#timeouts-1">TenantTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TenantTemplateDeploymentState<'Location, 'Name>, value: azurerm.TenantTemplateDeployment.TenantTemplateDeploymentTimeouts) : TenantTemplateDeploymentState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TenantTemplateDeploymentState<'Location, 'Name>

        member _.Run(state: TenantTemplateDeploymentState<Present, Present>) : azurerm.TenantTemplateDeployment.TenantTemplateDeployment =
            let config = azurerm.TenantTemplateDeployment.TenantTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.TenantTemplateDeployment.TenantTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.tenantTemplateDeployment: missing required arguments. Must call: location, name.", 9999, IsError = true)>]
        member _.Run(_: TenantTemplateDeploymentState<_, _>) : azurerm.TenantTemplateDeployment.TenantTemplateDeployment =
            Unchecked.defaultof<azurerm.TenantTemplateDeployment.TenantTemplateDeployment>
