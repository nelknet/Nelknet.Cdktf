namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack">azurerm_palo_alto_local_rulestack</a>.
    /// </summary>
    type DataAzurermPaloAltoLocalRulestackBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPaloAltoLocalRulestackState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPaloAltoLocalRulestackState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPaloAltoLocalRulestackState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPaloAltoLocalRulestackState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#name-1">DataAzurermPaloAltoLocalRulestack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPaloAltoLocalRulestackState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPaloAltoLocalRulestackState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPaloAltoLocalRulestackState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#resource_group_name-1">DataAzurermPaloAltoLocalRulestack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPaloAltoLocalRulestackState<'Name, Missing>, value: string) : DataAzurermPaloAltoLocalRulestackState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPaloAltoLocalRulestackState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#id-1">DataAzurermPaloAltoLocalRulestack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/palo_alto_local_rulestack#timeouts-1">DataAzurermPaloAltoLocalRulestack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestackTimeouts) : DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPaloAltoLocalRulestackState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPaloAltoLocalRulestackState<Present, Present>) : azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestack =
            let config = azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestackConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPaloAltoLocalRulestack: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPaloAltoLocalRulestackState<_, _>) : azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestack =
            Unchecked.defaultof<azurerm.DataAzurermPaloAltoLocalRulestack.DataAzurermPaloAltoLocalRulestack>
