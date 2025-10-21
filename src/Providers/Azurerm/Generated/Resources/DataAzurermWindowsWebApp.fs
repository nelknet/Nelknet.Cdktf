namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app">azurerm_windows_web_app</a>.
    /// </summary>
    type DataAzurermWindowsWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermWindowsWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWindowsWebAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermWindowsWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWindowsWebAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#name-1">DataAzurermWindowsWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermWindowsWebAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermWindowsWebAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermWindowsWebAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#resource_group_name-1">DataAzurermWindowsWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermWindowsWebAppState<'Name, Missing>, value: string) : DataAzurermWindowsWebAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermWindowsWebAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#id-1">DataAzurermWindowsWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#timeouts-1">DataAzurermWindowsWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeouts) : DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermWindowsWebAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermWindowsWebAppState<Present, Present>) : azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp =
            let config = azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermWindowsWebApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermWindowsWebAppState<_, _>) : azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp =
            Unchecked.defaultof<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp>
