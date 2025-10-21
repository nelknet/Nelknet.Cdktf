namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> = { assignments: ResizeArray<azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app">azurerm_spring_cloud_app</a>.
    /// </summary>
    type DataAzurermSpringCloudAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSpringCloudAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpringCloudAppState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSpringCloudAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpringCloudAppState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#name-1">DataAzurermSpringCloudApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSpringCloudAppState<Missing, 'ResourceGroupName, 'ServiceName>, value: string) : DataAzurermSpringCloudAppState<Present, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSpringCloudAppState<Present, 'ResourceGroupName, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#resource_group_name-1">DataAzurermSpringCloudApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSpringCloudAppState<'Name, Missing, 'ServiceName>, value: string) : DataAzurermSpringCloudAppState<'Name, Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSpringCloudAppState<'Name, Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#service_name-1">DataAzurermSpringCloudApp#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#id-1">DataAzurermSpringCloudApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#timeouts-1">DataAzurermSpringCloudApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudAppTimeouts) : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        member _.Run(state: DataAzurermSpringCloudAppState<Present, Present, Present>) : azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudApp =
            let config = azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSpringCloudApp: missing required arguments. Must call: name, resource_group_name, service_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSpringCloudAppState<_, _, _>) : azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudApp =
            Unchecked.defaultof<azurerm.DataAzurermSpringCloudApp.DataAzurermSpringCloudApp>
