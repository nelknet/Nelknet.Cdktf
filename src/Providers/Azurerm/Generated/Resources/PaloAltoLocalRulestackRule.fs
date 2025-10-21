namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule">azurerm_palo_alto_local_rulestack_rule</a>.
    /// </summary>
    type PaloAltoLocalRulestackRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#action-1">PaloAltoLocalRulestackRule#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: PaloAltoLocalRulestackRuleState<Missing, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<Present, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<Present, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#applications-1">PaloAltoLocalRulestackRule#applications</a>.
        /// </summary>
        [<CustomOperation "applications">]
        member _.Applications(state: PaloAltoLocalRulestackRuleState<'Action, Missing, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: seq<string>) : PaloAltoLocalRulestackRuleState<'Action, Present, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Applications <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, Present, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>)

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#destination-1">PaloAltoLocalRulestackRule#destination</a>
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, Missing, 'Name, 'Priority, 'RulestackId, 'Source>, value: azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleDestination) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, Present, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, 'Applications, Present, 'Name, 'Priority, 'RulestackId, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#name-1">PaloAltoLocalRulestackRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, Missing, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, Present, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, Present, 'Priority, 'RulestackId, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#priority-1">PaloAltoLocalRulestackRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, Missing, 'RulestackId, 'Source>, value: double) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, Present, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, Present, 'RulestackId, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#rulestack_id-1">PaloAltoLocalRulestackRule#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, Missing, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, Present, 'Source> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#source-1">PaloAltoLocalRulestackRule#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, Missing>, value: azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleSource) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#audit_comment-1">PaloAltoLocalRulestackRule#audit_comment</a>.
        /// </summary>
        [<CustomOperation "audit_comment">]
        member _.AuditComment(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.AuditComment <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// category block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#category-1">PaloAltoLocalRulestackRule#category</a>
        /// </summary>
        [<CustomOperation "category">]
        member _.Category(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleCategory) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Category <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#decryption_rule_type-1">PaloAltoLocalRulestackRule#decryption_rule_type</a>.
        /// </summary>
        [<CustomOperation "decryption_rule_type">]
        member _.DecryptionRuleType(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.DecryptionRuleType <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#description-1">PaloAltoLocalRulestackRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#enabled-1">PaloAltoLocalRulestackRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: bool) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#enabled-1">PaloAltoLocalRulestackRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#id-1">PaloAltoLocalRulestackRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#inspection_certificate_id-1">PaloAltoLocalRulestackRule#inspection_certificate_id</a>.
        /// </summary>
        [<CustomOperation "inspection_certificate_id">]
        member _.InspectionCertificateId(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.InspectionCertificateId <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#logging_enabled-1">PaloAltoLocalRulestackRule#logging_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "logging_enabled">]
        member _.LoggingEnabled(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: bool) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.LoggingEnabled <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#logging_enabled-1">PaloAltoLocalRulestackRule#logging_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "logging_enabled">]
        member _.LoggingEnabled(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.LoggingEnabled <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#negate_destination-1">PaloAltoLocalRulestackRule#negate_destination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "negate_destination">]
        member _.NegateDestination(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: bool) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.NegateDestination <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#negate_destination-1">PaloAltoLocalRulestackRule#negate_destination</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "negate_destination">]
        member _.NegateDestination(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.NegateDestination <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#negate_source-1">PaloAltoLocalRulestackRule#negate_source</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "negate_source">]
        member _.NegateSource(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: bool) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.NegateSource <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#negate_source-1">PaloAltoLocalRulestackRule#negate_source</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "negate_source">]
        member _.NegateSource(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.NegateSource <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#protocol-1">PaloAltoLocalRulestackRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: string) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#protocol_ports-1">PaloAltoLocalRulestackRule#protocol_ports</a>.
        /// </summary>
        [<CustomOperation "protocol_ports">]
        member _.ProtocolPorts(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: seq<string>) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.ProtocolPorts <- (value |> Seq.toArray))
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#tags-1">PaloAltoLocalRulestackRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: seq<string * string>) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_rule#timeouts-1">PaloAltoLocalRulestackRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>, value: azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleTimeouts) : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackRuleState<'Action, 'Applications, 'Destination, 'Name, 'Priority, 'RulestackId, 'Source>

        member _.Run(state: PaloAltoLocalRulestackRuleState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRule =
            let config = azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackRule: missing required arguments. Must call: action, applications, destination, name, priority, rulestack_id, source.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackRuleState<_, _, _, _, _, _, _>) : azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRule =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackRule.PaloAltoLocalRulestackRule>
