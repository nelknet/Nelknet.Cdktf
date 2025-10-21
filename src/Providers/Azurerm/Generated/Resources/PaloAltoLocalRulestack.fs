namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack">azurerm_palo_alto_local_rulestack</a>.
    /// </summary>
    type PaloAltoLocalRulestackBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackState<Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#location-1">PaloAltoLocalRulestack#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PaloAltoLocalRulestackState<Missing, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#name-1">PaloAltoLocalRulestack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoLocalRulestackState<'Location, Missing, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#resource_group_name-1">PaloAltoLocalRulestack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PaloAltoLocalRulestackState<'Location, 'Name, Missing>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#anti_spyware_profile-1">PaloAltoLocalRulestack#anti_spyware_profile</a>.
        /// </summary>
        [<CustomOperation "anti_spyware_profile">]
        member _.AntiSpywareProfile(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AntiSpywareProfile <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#anti_virus_profile-1">PaloAltoLocalRulestack#anti_virus_profile</a>.
        /// </summary>
        [<CustomOperation "anti_virus_profile">]
        member _.AntiVirusProfile(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AntiVirusProfile <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#description-1">PaloAltoLocalRulestack#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#dns_subscription-1">PaloAltoLocalRulestack#dns_subscription</a>.
        /// </summary>
        [<CustomOperation "dns_subscription">]
        member _.DnsSubscription(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsSubscription <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#file_blocking_profile-1">PaloAltoLocalRulestack#file_blocking_profile</a>.
        /// </summary>
        [<CustomOperation "file_blocking_profile">]
        member _.FileBlockingProfile(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FileBlockingProfile <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#id-1">PaloAltoLocalRulestack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#timeouts-1">PaloAltoLocalRulestack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestackTimeouts) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#url_filtering_profile-1">PaloAltoLocalRulestack#url_filtering_profile</a>.
        /// </summary>
        [<CustomOperation "url_filtering_profile">]
        member _.UrlFilteringProfile(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UrlFilteringProfile <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack#vulnerability_profile-1">PaloAltoLocalRulestack#vulnerability_profile</a>.
        /// </summary>
        [<CustomOperation "vulnerability_profile">]
        member _.VulnerabilityProfile(state: PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>, value: string) : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VulnerabilityProfile <- value)
            state : PaloAltoLocalRulestackState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PaloAltoLocalRulestackState<Present, Present, Present>) : azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestack =
            let config = azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestackConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestack: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackState<_, _, _>) : azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestack =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestack.PaloAltoLocalRulestack>
