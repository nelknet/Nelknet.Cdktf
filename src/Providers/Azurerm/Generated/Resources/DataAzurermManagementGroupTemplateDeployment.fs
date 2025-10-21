namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment">azurerm_management_group_template_deployment</a>.
    /// </summary>
    type DataAzurermManagementGroupTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermManagementGroupTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagementGroupTemplateDeploymentState<Missing, Missing>)

        member _.Zero(()) : DataAzurermManagementGroupTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagementGroupTemplateDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#management_group_id-1">DataAzurermManagementGroupTemplateDeployment#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: DataAzurermManagementGroupTemplateDeploymentState<Missing, 'Name>, value: string) : DataAzurermManagementGroupTemplateDeploymentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : DataAzurermManagementGroupTemplateDeploymentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#name-1">DataAzurermManagementGroupTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, Missing>, value: string) : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#id-1">DataAzurermManagementGroupTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name>, value: string) : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/management_group_template_deployment#timeouts-1">DataAzurermManagementGroupTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name>, value: azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeploymentTimeouts) : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermManagementGroupTemplateDeploymentState<'ManagementGroupId, 'Name>

        member _.Run(state: DataAzurermManagementGroupTemplateDeploymentState<Present, Present>) : azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeployment =
            let config = azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermManagementGroupTemplateDeployment: missing required arguments. Must call: management_group_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermManagementGroupTemplateDeploymentState<_, _>) : azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeployment =
            Unchecked.defaultof<azurerm.DataAzurermManagementGroupTemplateDeployment.DataAzurermManagementGroupTemplateDeployment>
