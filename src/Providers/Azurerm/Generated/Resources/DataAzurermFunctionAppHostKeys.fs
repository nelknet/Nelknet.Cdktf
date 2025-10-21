namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys">azurerm_function_app_host_keys</a>.
    /// </summary>
    type DataAzurermFunctionAppHostKeysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermFunctionAppHostKeysState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFunctionAppHostKeysState<Missing, Missing>)

        member _.Zero(()) : DataAzurermFunctionAppHostKeysState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFunctionAppHostKeysState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys#name-1">DataAzurermFunctionAppHostKeys#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermFunctionAppHostKeysState<Missing, 'ResourceGroupName>, value: string) : DataAzurermFunctionAppHostKeysState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermFunctionAppHostKeysState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys#resource_group_name-1">DataAzurermFunctionAppHostKeys#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermFunctionAppHostKeysState<'Name, Missing>, value: string) : DataAzurermFunctionAppHostKeysState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermFunctionAppHostKeysState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys#id-1">DataAzurermFunctionAppHostKeys#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName>, value: string) : DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app_host_keys#timeouts-1">DataAzurermFunctionAppHostKeys#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeysTimeouts) : DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermFunctionAppHostKeysState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermFunctionAppHostKeysState<Present, Present>) : azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeys =
            let config = azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeysConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeys(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermFunctionAppHostKeys: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermFunctionAppHostKeysState<_, _>) : azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeys =
            Unchecked.defaultof<azurerm.DataAzurermFunctionAppHostKeys.DataAzurermFunctionAppHostKeys>
