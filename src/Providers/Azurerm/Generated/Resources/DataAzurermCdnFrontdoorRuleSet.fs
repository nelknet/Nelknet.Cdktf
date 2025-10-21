namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set">azurerm_cdn_frontdoor_rule_set</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorRuleSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorRuleSetState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorRuleSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorRuleSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set#name-1">DataAzurermCdnFrontdoorRuleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorRuleSetState<Missing, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorRuleSetState<Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorRuleSetState<Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set#profile_name-1">DataAzurermCdnFrontdoorRuleSet#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: DataAzurermCdnFrontdoorRuleSetState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorRuleSetState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorRuleSetState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set#resource_group_name-1">DataAzurermCdnFrontdoorRuleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, Missing>, value: string) : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set#id-1">DataAzurermCdnFrontdoorRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_rule_set#timeouts-1">DataAzurermCdnFrontdoorRuleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSetTimeouts) : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorRuleSetState<'Name, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorRuleSetState<Present, Present, Present>) : azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSet =
            let config = azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorRuleSet: missing required arguments. Must call: name, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorRuleSetState<_, _, _>) : azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSet =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorRuleSet.DataAzurermCdnFrontdoorRuleSet>
