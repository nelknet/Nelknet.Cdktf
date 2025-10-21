namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine">azurerm_frontdoor_rules_engine</a>.
    /// </summary>
    type FrontdoorRulesEngineBuilder(logicalId: string) =
        member _.Yield(_: unit) : FrontdoorRulesEngineState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorRulesEngineState<Missing, Missing, Missing>)

        member _.Zero(()) : FrontdoorRulesEngineState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorRulesEngineState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#frontdoor_name-1">FrontdoorRulesEngine#frontdoor_name</a>.
        /// </summary>
        [<CustomOperation "frontdoor_name">]
        member _.FrontdoorName(state: FrontdoorRulesEngineState<Missing, 'Name, 'ResourceGroupName>, value: string) : FrontdoorRulesEngineState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontdoorName <- value)
            ({ assignments = state.assignments } : FrontdoorRulesEngineState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#name-1">FrontdoorRulesEngine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FrontdoorRulesEngineState<'FrontdoorName, Missing, 'ResourceGroupName>, value: string) : FrontdoorRulesEngineState<'FrontdoorName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FrontdoorRulesEngineState<'FrontdoorName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#resource_group_name-1">FrontdoorRulesEngine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, Missing>, value: string) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FrontdoorRulesEngineState<'FrontdoorName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#enabled-1">FrontdoorRulesEngine#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>, value: bool) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#enabled-1">FrontdoorRulesEngine#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#id-1">FrontdoorRulesEngine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>, value: string) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#rule-1">FrontdoorRulesEngine#rule</a> Accepts: azurerm.IResolvable | azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_rules_engine#timeouts-1">FrontdoorRulesEngine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>, value: azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineTimeouts) : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FrontdoorRulesEngineState<'FrontdoorName, 'Name, 'ResourceGroupName>

        member _.Run(state: FrontdoorRulesEngineState<Present, Present, Present>) : azurerm.FrontdoorRulesEngine.FrontdoorRulesEngine =
            let config = azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineConfig()
            for setter in state.assignments do
                setter config
            azurerm.FrontdoorRulesEngine.FrontdoorRulesEngine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.frontdoorRulesEngine: missing required arguments. Must call: frontdoor_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: FrontdoorRulesEngineState<_, _, _>) : azurerm.FrontdoorRulesEngine.FrontdoorRulesEngine =
            Unchecked.defaultof<azurerm.FrontdoorRulesEngine.FrontdoorRulesEngine>
