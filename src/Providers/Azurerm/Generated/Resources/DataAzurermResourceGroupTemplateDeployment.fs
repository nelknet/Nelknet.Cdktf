namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment">azurerm_resource_group_template_deployment</a>.
    /// </summary>
    type DataAzurermResourceGroupTemplateDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermResourceGroupTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermResourceGroupTemplateDeploymentState<Missing, Missing>)

        member _.Zero(()) : DataAzurermResourceGroupTemplateDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermResourceGroupTemplateDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#name-1">DataAzurermResourceGroupTemplateDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermResourceGroupTemplateDeploymentState<Missing, 'ResourceGroupName>, value: string) : DataAzurermResourceGroupTemplateDeploymentState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermResourceGroupTemplateDeploymentState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#resource_group_name-1">DataAzurermResourceGroupTemplateDeployment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermResourceGroupTemplateDeploymentState<'Name, Missing>, value: string) : DataAzurermResourceGroupTemplateDeploymentState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermResourceGroupTemplateDeploymentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#id-1">DataAzurermResourceGroupTemplateDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName>, value: string) : DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#timeouts-1">DataAzurermResourceGroupTemplateDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentTimeouts) : DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermResourceGroupTemplateDeploymentState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermResourceGroupTemplateDeploymentState<Present, Present>) : azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeployment =
            let config = azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermResourceGroupTemplateDeployment: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermResourceGroupTemplateDeploymentState<_, _>) : azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeployment =
            Unchecked.defaultof<azurerm.DataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeployment>
