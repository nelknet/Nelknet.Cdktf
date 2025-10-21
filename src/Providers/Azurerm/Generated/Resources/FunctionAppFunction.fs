namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> = { assignments: ResizeArray<azurerm.FunctionAppFunction.FunctionAppFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function">azurerm_function_app_function</a>.
    /// </summary>
    type FunctionAppFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppFunctionState<Missing, Missing, Missing>)

        member _.Zero(()) : FunctionAppFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppFunctionState<Missing, Missing, Missing>)

        /// <summary>
        /// The config for this Function in JSON format. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#config_json-1">FunctionAppFunction#config_json</a>
        /// </summary>
        [<CustomOperation "config_json">]
        member _.ConfigJson(state: FunctionAppFunctionState<Missing, 'FunctionAppId, 'Name>, value: string) : FunctionAppFunctionState<Present, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.ConfigJson <- value)
            ({ assignments = state.assignments } : FunctionAppFunctionState<Present, 'FunctionAppId, 'Name>)

        /// <summary>
        /// The ID of the Function App in which this function should reside. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#function_app_id-1">FunctionAppFunction#function_app_id</a>
        /// </summary>
        [<CustomOperation "function_app_id">]
        member _.FunctionAppId(state: FunctionAppFunctionState<'ConfigJson, Missing, 'Name>, value: string) : FunctionAppFunctionState<'ConfigJson, Present, 'Name> =
            state.assignments.Add(fun config -> config.FunctionAppId <- value)
            ({ assignments = state.assignments } : FunctionAppFunctionState<'ConfigJson, Present, 'Name>)

        /// <summary>
        /// The name of the function. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#name-1">FunctionAppFunction#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, Missing>, value: string) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, Present>)

        /// <summary>
        /// Should this function be enabled. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#enabled-1">FunctionAppFunction#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: bool) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// Should this function be enabled. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#enabled-1">FunctionAppFunction#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// file block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#file-1">FunctionAppFunction#file</a> Accepts: azurerm.IResolvable | azurerm.FunctionAppFunction.FunctionAppFunctionFile[]
        /// </summary>
        [<CustomOperation "file">]
        member _.File(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.File <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#id-1">FunctionAppFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: string) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// The language the Function is written in. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#language-1">FunctionAppFunction#language</a>
        /// </summary>
        [<CustomOperation "language">]
        member _.Language(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: string) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.Language <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// The test data for the function. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#test_data-1">FunctionAppFunction#test_data</a>
        /// </summary>
        [<CustomOperation "test_data">]
        member _.TestData(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: string) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.TestData <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#timeouts-1">FunctionAppFunction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>, value: azurerm.FunctionAppFunction.FunctionAppFunctionTimeouts) : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppFunctionState<'ConfigJson, 'FunctionAppId, 'Name>

        member _.Run(state: FunctionAppFunctionState<Present, Present, Present>) : azurerm.FunctionAppFunction.FunctionAppFunction =
            let config = azurerm.FunctionAppFunction.FunctionAppFunctionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionAppFunction.FunctionAppFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionAppFunction: missing required arguments. Must call: config_json, function_app_id, name.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppFunctionState<_, _, _>) : azurerm.FunctionAppFunction.FunctionAppFunction =
            Unchecked.defaultof<azurerm.FunctionAppFunction.FunctionAppFunction>
