namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service">azurerm_spring_cloud_service</a>.
    /// </summary>
    type DataAzurermSpringCloudServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSpringCloudServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpringCloudServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSpringCloudServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpringCloudServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#name-1">DataAzurermSpringCloudService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSpringCloudServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSpringCloudServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSpringCloudServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#resource_group_name-1">DataAzurermSpringCloudService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSpringCloudServiceState<'Name, Missing>, value: string) : DataAzurermSpringCloudServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSpringCloudServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#id-1">DataAzurermSpringCloudService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#timeouts-1">DataAzurermSpringCloudService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceTimeouts) : DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSpringCloudServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSpringCloudServiceState<Present, Present>) : azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudService =
            let config = azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSpringCloudService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSpringCloudServiceState<_, _>) : azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudService =
            Unchecked.defaultof<azurerm.DataAzurermSpringCloudService.DataAzurermSpringCloudService>
