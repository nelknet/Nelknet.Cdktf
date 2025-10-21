namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerApp.DataAzurermContainerAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app">azurerm_container_app</a>.
    /// </summary>
    type DataAzurermContainerAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#name-1">DataAzurermContainerApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#resource_group_name-1">DataAzurermContainerApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerAppState<'Name, Missing>, value: string) : DataAzurermContainerAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#id-1">DataAzurermContainerApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#timeouts-1">DataAzurermContainerApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerApp.DataAzurermContainerAppTimeouts) : DataAzurermContainerAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerAppState<Present, Present>) : azurerm.DataAzurermContainerApp.DataAzurermContainerApp =
            let config = azurerm.DataAzurermContainerApp.DataAzurermContainerAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerApp.DataAzurermContainerApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerAppState<_, _>) : azurerm.DataAzurermContainerApp.DataAzurermContainerApp =
            Unchecked.defaultof<azurerm.DataAzurermContainerApp.DataAzurermContainerApp>
