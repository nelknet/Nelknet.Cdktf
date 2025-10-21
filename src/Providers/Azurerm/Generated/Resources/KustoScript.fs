namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoScriptState<'DatabaseId, 'Name> = { assignments: ResizeArray<azurerm.KustoScript.KustoScriptConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script">azurerm_kusto_script</a>.
    /// </summary>
    type KustoScriptBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoScriptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoScriptState<Missing, Missing>)

        member _.Zero(()) : KustoScriptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoScriptState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#database_id-1">KustoScript#database_id</a>.
        /// </summary>
        [<CustomOperation "database_id">]
        member _.DatabaseId(state: KustoScriptState<Missing, 'Name>, value: string) : KustoScriptState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseId <- value)
            ({ assignments = state.assignments } : KustoScriptState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#name-1">KustoScript#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoScriptState<'DatabaseId, Missing>, value: string) : KustoScriptState<'DatabaseId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoScriptState<'DatabaseId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#continue_on_errors_enabled-1">KustoScript#continue_on_errors_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continue_on_errors_enabled">]
        member _.ContinueOnErrorsEnabled(state: KustoScriptState<'DatabaseId, 'Name>, value: bool) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.ContinueOnErrorsEnabled <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#continue_on_errors_enabled-1">KustoScript#continue_on_errors_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continue_on_errors_enabled">]
        member _.ContinueOnErrorsEnabled(state: KustoScriptState<'DatabaseId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.ContinueOnErrorsEnabled <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#force_an_update_when_value_changed-1">KustoScript#force_an_update_when_value_changed</a>.
        /// </summary>
        [<CustomOperation "force_an_update_when_value_changed">]
        member _.ForceAnUpdateWhenValueChanged(state: KustoScriptState<'DatabaseId, 'Name>, value: string) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.ForceAnUpdateWhenValueChanged <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#id-1">KustoScript#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoScriptState<'DatabaseId, 'Name>, value: string) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#sas_token-1">KustoScript#sas_token</a>.
        /// </summary>
        [<CustomOperation "sas_token">]
        member _.SasToken(state: KustoScriptState<'DatabaseId, 'Name>, value: string) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.SasToken <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#script_content-1">KustoScript#script_content</a>.
        /// </summary>
        [<CustomOperation "script_content">]
        member _.ScriptContent(state: KustoScriptState<'DatabaseId, 'Name>, value: string) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.ScriptContent <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#timeouts-1">KustoScript#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoScriptState<'DatabaseId, 'Name>, value: azurerm.KustoScript.KustoScriptTimeouts) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_script#url-1">KustoScript#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: KustoScriptState<'DatabaseId, 'Name>, value: string) : KustoScriptState<'DatabaseId, 'Name> =
            state.assignments.Add(fun config -> config.Url <- value)
            state : KustoScriptState<'DatabaseId, 'Name>

        member _.Run(state: KustoScriptState<Present, Present>) : azurerm.KustoScript.KustoScript =
            let config = azurerm.KustoScript.KustoScriptConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoScript.KustoScript(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoScript: missing required arguments. Must call: database_id, name.", 9999, IsError = true)>]
        member _.Run(_: KustoScriptState<_, _>) : azurerm.KustoScript.KustoScript =
            Unchecked.defaultof<azurerm.KustoScript.KustoScript>
