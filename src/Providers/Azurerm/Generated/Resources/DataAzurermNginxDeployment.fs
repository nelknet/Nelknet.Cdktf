namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment">azurerm_nginx_deployment</a>.
    /// </summary>
    type DataAzurermNginxDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNginxDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxDeploymentState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNginxDeploymentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNginxDeploymentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#name-1">DataAzurermNginxDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNginxDeploymentState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNginxDeploymentState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNginxDeploymentState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#resource_group_name-1">DataAzurermNginxDeployment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNginxDeploymentState<'Name, Missing>, value: string) : DataAzurermNginxDeploymentState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNginxDeploymentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#id-1">DataAzurermNginxDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#timeouts-1">DataAzurermNginxDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeouts) : DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNginxDeploymentState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNginxDeploymentState<Present, Present>) : azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment =
            let config = azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNginxDeployment: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNginxDeploymentState<_, _>) : azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment =
            Unchecked.defaultof<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeployment>
