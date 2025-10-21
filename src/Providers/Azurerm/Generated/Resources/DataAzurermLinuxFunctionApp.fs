namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app">azurerm_linux_function_app</a>.
    /// </summary>
    type DataAzurermLinuxFunctionAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLinuxFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLinuxFunctionAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLinuxFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLinuxFunctionAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#name-1">DataAzurermLinuxFunctionApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLinuxFunctionAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLinuxFunctionAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLinuxFunctionAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#resource_group_name-1">DataAzurermLinuxFunctionApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLinuxFunctionAppState<'Name, Missing>, value: string) : DataAzurermLinuxFunctionAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLinuxFunctionAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#id-1">DataAzurermLinuxFunctionApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#timeouts-1">DataAzurermLinuxFunctionApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts) : DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLinuxFunctionAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLinuxFunctionAppState<Present, Present>) : azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp =
            let config = azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLinuxFunctionApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLinuxFunctionAppState<_, _>) : azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp =
            Unchecked.defaultof<azurerm.DataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionApp>
