namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app">azurerm_linux_web_app</a>.
    /// </summary>
    type DataAzurermLinuxWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLinuxWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLinuxWebAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLinuxWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLinuxWebAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#name-1">DataAzurermLinuxWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLinuxWebAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLinuxWebAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLinuxWebAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#resource_group_name-1">DataAzurermLinuxWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLinuxWebAppState<'Name, Missing>, value: string) : DataAzurermLinuxWebAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLinuxWebAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#id-1">DataAzurermLinuxWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#timeouts-1">DataAzurermLinuxWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppTimeouts) : DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLinuxWebAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLinuxWebAppState<Present, Present>) : azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebApp =
            let config = azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLinuxWebApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLinuxWebAppState<_, _>) : azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebApp =
            Unchecked.defaultof<azurerm.DataAzurermLinuxWebApp.DataAzurermLinuxWebApp>
