namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name> = { assignments: ResizeArray<azurerm.LogicAppTriggerCustom.LogicAppTriggerCustomConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom">azurerm_logic_app_trigger_custom</a>.
    /// </summary>
    type LogicAppTriggerCustomBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppTriggerCustomState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerCustomState<Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppTriggerCustomState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerCustomState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom#body-1">LogicAppTriggerCustom#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: LogicAppTriggerCustomState<Missing, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerCustomState<Present, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : LogicAppTriggerCustomState<Present, 'LogicAppId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom#logic_app_id-1">LogicAppTriggerCustom#logic_app_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_id">]
        member _.LogicAppId(state: LogicAppTriggerCustomState<'Body, Missing, 'Name>, value: string) : LogicAppTriggerCustomState<'Body, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogicAppId <- value)
            ({ assignments = state.assignments } : LogicAppTriggerCustomState<'Body, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom#name-1">LogicAppTriggerCustom#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppTriggerCustomState<'Body, 'LogicAppId, Missing>, value: string) : LogicAppTriggerCustomState<'Body, 'LogicAppId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppTriggerCustomState<'Body, 'LogicAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom#id-1">LogicAppTriggerCustom#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name>, value: string) : LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_custom#timeouts-1">LogicAppTriggerCustom#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name>, value: azurerm.LogicAppTriggerCustom.LogicAppTriggerCustomTimeouts) : LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppTriggerCustomState<'Body, 'LogicAppId, 'Name>

        member _.Run(state: LogicAppTriggerCustomState<Present, Present, Present>) : azurerm.LogicAppTriggerCustom.LogicAppTriggerCustom =
            let config = azurerm.LogicAppTriggerCustom.LogicAppTriggerCustomConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppTriggerCustom.LogicAppTriggerCustom(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppTriggerCustom: missing required arguments. Must call: body, logic_app_id, name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppTriggerCustomState<_, _, _>) : azurerm.LogicAppTriggerCustom.LogicAppTriggerCustom =
            Unchecked.defaultof<azurerm.LogicAppTriggerCustom.LogicAppTriggerCustom>
