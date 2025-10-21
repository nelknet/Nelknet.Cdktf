namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermFunctionAppState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermFunctionApp.DataAzurermFunctionAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app">azurerm_function_app</a>.
    /// </summary>
    type DataAzurermFunctionAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFunctionAppState<Missing, Missing>)

        member _.Zero(()) : DataAzurermFunctionAppState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFunctionAppState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#name-1">DataAzurermFunctionApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermFunctionAppState<Missing, 'ResourceGroupName>, value: string) : DataAzurermFunctionAppState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermFunctionAppState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#resource_group_name-1">DataAzurermFunctionApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermFunctionAppState<'Name, Missing>, value: string) : DataAzurermFunctionAppState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermFunctionAppState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#id-1">DataAzurermFunctionApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermFunctionAppState<'Name, 'ResourceGroupName>, value: string) : DataAzurermFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermFunctionAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#tags-1">DataAzurermFunctionApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermFunctionAppState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermFunctionAppState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#timeouts-1">DataAzurermFunctionApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermFunctionAppState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermFunctionApp.DataAzurermFunctionAppTimeouts) : DataAzurermFunctionAppState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermFunctionAppState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermFunctionAppState<Present, Present>) : azurerm.DataAzurermFunctionApp.DataAzurermFunctionApp =
            let config = azurerm.DataAzurermFunctionApp.DataAzurermFunctionAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermFunctionApp.DataAzurermFunctionApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermFunctionApp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermFunctionAppState<_, _>) : azurerm.DataAzurermFunctionApp.DataAzurermFunctionApp =
            Unchecked.defaultof<azurerm.DataAzurermFunctionApp.DataAzurermFunctionApp>
