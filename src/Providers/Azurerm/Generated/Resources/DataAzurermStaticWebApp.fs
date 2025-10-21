namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStaticWebAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app">azurerm_static_web_app</a>.
    /// </summary>
    type DataAzurermStaticWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStaticWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStaticWebAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStaticWebAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStaticWebAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#name-1">DataAzurermStaticWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStaticWebAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermStaticWebAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStaticWebAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#resource_group_name-1">DataAzurermStaticWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermStaticWebAppState<'Name, Missing>, value: string) : DataAzurermStaticWebAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermStaticWebAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#id-1">DataAzurermStaticWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStaticWebAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStaticWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStaticWebAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#timeouts-1">DataAzurermStaticWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStaticWebAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebAppTimeouts) : DataAzurermStaticWebAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStaticWebAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermStaticWebAppState<Present, Present>) : azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebApp =
            let config = azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStaticWebApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStaticWebAppState<_, _>) : azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebApp =
            Unchecked.defaultof<azurerm.DataAzurermStaticWebApp.DataAzurermStaticWebApp>
