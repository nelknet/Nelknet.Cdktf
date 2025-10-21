namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermTenantTemplateDeploymentState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment">azurerm_tenant_template_deployment</a>.
    /// </summary>
    type DataAzurermTenantTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermTenantTemplateDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTenantTemplateDeploymentState<Missing>)

        member _.Zero(()) : DataAzurermTenantTemplateDeploymentState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTenantTemplateDeploymentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment#name-1">DataAzurermTenantTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermTenantTemplateDeploymentState<Missing>, value: string) : DataAzurermTenantTemplateDeploymentState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermTenantTemplateDeploymentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment#id-1">DataAzurermTenantTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermTenantTemplateDeploymentState<'Name>, value: string) : DataAzurermTenantTemplateDeploymentState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermTenantTemplateDeploymentState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/tenant_template_deployment#timeouts-1">DataAzurermTenantTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermTenantTemplateDeploymentState<'Name>, value: azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeploymentTimeouts) : DataAzurermTenantTemplateDeploymentState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermTenantTemplateDeploymentState<'Name>

        member _.Run(state: DataAzurermTenantTemplateDeploymentState<Present>) : azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeployment =
            let config = azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermTenantTemplateDeployment: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermTenantTemplateDeploymentState<_>) : azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeployment =
            Unchecked.defaultof<azurerm.DataAzurermTenantTemplateDeployment.DataAzurermTenantTemplateDeployment>
