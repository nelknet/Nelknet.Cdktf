namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app">azurerm_windows_function_app</a>.
    /// </summary>
    type DataAzurermWindowsFunctionAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermWindowsFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWindowsFunctionAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermWindowsFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWindowsFunctionAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#name-1">DataAzurermWindowsFunctionApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermWindowsFunctionAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermWindowsFunctionAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermWindowsFunctionAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#resource_group_name-1">DataAzurermWindowsFunctionApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermWindowsFunctionAppState<'Name, Missing>, value: string) : DataAzurermWindowsFunctionAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermWindowsFunctionAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#id-1">DataAzurermWindowsFunctionApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#timeouts-1">DataAzurermWindowsFunctionApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppTimeouts) : DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermWindowsFunctionAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermWindowsFunctionAppState<Present, Present>) : azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionApp =
            let config = azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermWindowsFunctionApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermWindowsFunctionAppState<_, _>) : azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionApp =
            Unchecked.defaultof<azurerm.DataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionApp>
