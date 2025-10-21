namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppActionCustomState<'Body, 'LogicAppId, 'Name> = { assignments: ResizeArray<azurerm.LogicAppActionCustom.LogicAppActionCustomConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom">azurerm_logic_app_action_custom</a>.
    /// </summary>
    type LogicAppActionCustomBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppActionCustomState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppActionCustomState<Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppActionCustomState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppActionCustomState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom#body-1">LogicAppActionCustom#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: LogicAppActionCustomState<Missing, 'LogicAppId, 'Name>, value: string) : LogicAppActionCustomState<Present, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : LogicAppActionCustomState<Present, 'LogicAppId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom#logic_app_id-1">LogicAppActionCustom#logic_app_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_id">]
        member _.LogicAppId(state: LogicAppActionCustomState<'Body, Missing, 'Name>, value: string) : LogicAppActionCustomState<'Body, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogicAppId <- value)
            ({ assignments = state.assignments } : LogicAppActionCustomState<'Body, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom#name-1">LogicAppActionCustom#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppActionCustomState<'Body, 'LogicAppId, Missing>, value: string) : LogicAppActionCustomState<'Body, 'LogicAppId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppActionCustomState<'Body, 'LogicAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom#id-1">LogicAppActionCustom#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppActionCustomState<'Body, 'LogicAppId, 'Name>, value: string) : LogicAppActionCustomState<'Body, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppActionCustomState<'Body, 'LogicAppId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_custom#timeouts-1">LogicAppActionCustom#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppActionCustomState<'Body, 'LogicAppId, 'Name>, value: azurerm.LogicAppActionCustom.LogicAppActionCustomTimeouts) : LogicAppActionCustomState<'Body, 'LogicAppId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppActionCustomState<'Body, 'LogicAppId, 'Name>

        member _.Run(state: LogicAppActionCustomState<Present, Present, Present>) : azurerm.LogicAppActionCustom.LogicAppActionCustom =
            let config = azurerm.LogicAppActionCustom.LogicAppActionCustomConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppActionCustom.LogicAppActionCustom(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppActionCustom: missing required arguments. Must call: body, logic_app_id, name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppActionCustomState<_, _, _>) : azurerm.LogicAppActionCustom.LogicAppActionCustom =
            Unchecked.defaultof<azurerm.LogicAppActionCustom.LogicAppActionCustom>
