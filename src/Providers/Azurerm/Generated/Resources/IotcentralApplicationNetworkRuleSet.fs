namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> = { assignments: ResizeArray<azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set">azurerm_iotcentral_application_network_rule_set</a>.
    /// </summary>
    type IotcentralApplicationNetworkRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotcentralApplicationNetworkRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : IotcentralApplicationNetworkRuleSetState<Missing>)

        member _.Zero(()) : IotcentralApplicationNetworkRuleSetState<Missing> =
            ({ assignments = ResizeArray() } : IotcentralApplicationNetworkRuleSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#iotcentral_application_id-1">IotcentralApplicationNetworkRuleSet#iotcentral_application_id</a>.
        /// </summary>
        [<CustomOperation "iotcentral_application_id">]
        member _.IotcentralApplicationId(state: IotcentralApplicationNetworkRuleSetState<Missing>, value: string) : IotcentralApplicationNetworkRuleSetState<Present> =
            state.assignments.Add(fun config -> config.IotcentralApplicationId <- value)
            ({ assignments = state.assignments } : IotcentralApplicationNetworkRuleSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#apply_to_device-1">IotcentralApplicationNetworkRuleSet#apply_to_device</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "apply_to_device">]
        member _.ApplyToDevice(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: bool) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.ApplyToDevice <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#apply_to_device-1">IotcentralApplicationNetworkRuleSet#apply_to_device</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "apply_to_device">]
        member _.ApplyToDevice(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: HashiCorp.Cdktf.IResolvable) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.ApplyToDevice <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#default_action-1">IotcentralApplicationNetworkRuleSet#default_action</a>.
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: string) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#id-1">IotcentralApplicationNetworkRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: string) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        /// <summary>
        /// ip_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#ip_rule-1">IotcentralApplicationNetworkRuleSet#ip_rule</a> Accepts: azurerm.IResolvable | azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSetIpRule[]
        /// </summary>
        [<CustomOperation "ip_rule">]
        member _.IpRule(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: HashiCorp.Cdktf.IResolvable) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.IpRule <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application_network_rule_set#timeouts-1">IotcentralApplicationNetworkRuleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>, value: azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSetTimeouts) : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotcentralApplicationNetworkRuleSetState<'IotcentralApplicationId>

        member _.Run(state: IotcentralApplicationNetworkRuleSetState<Present>) : azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSet =
            let config = azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iotcentralApplicationNetworkRuleSet: missing required arguments. Must call: iotcentral_application_id.", 9999, IsError = true)>]
        member _.Run(_: IotcentralApplicationNetworkRuleSetState<_>) : azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSet =
            Unchecked.defaultof<azurerm.IotcentralApplicationNetworkRuleSet.IotcentralApplicationNetworkRuleSet>
