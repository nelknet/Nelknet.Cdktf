namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> = { assignments: ResizeArray<azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator">azurerm_sentinel_threat_intelligence_indicator</a>.
    /// </summary>
    type SentinelThreatIntelligenceIndicatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelThreatIntelligenceIndicatorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelThreatIntelligenceIndicatorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelThreatIntelligenceIndicatorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelThreatIntelligenceIndicatorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#display_name-1">SentinelThreatIntelligenceIndicator#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelThreatIntelligenceIndicatorState<Missing, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<Present, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<Present, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#pattern-1">SentinelThreatIntelligenceIndicator#pattern</a>.
        /// </summary>
        [<CustomOperation "pattern">]
        member _.Pattern(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, Missing, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, Present, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Pattern <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<'DisplayName, Present, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_type-1">SentinelThreatIntelligenceIndicator#pattern_type</a>.
        /// </summary>
        [<CustomOperation "pattern_type">]
        member _.PatternType(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, Missing, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, Present, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PatternType <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, Present, 'Source, 'ValidateFromUtc, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#source-1">SentinelThreatIntelligenceIndicator#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, Missing, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, Present, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, Present, 'ValidateFromUtc, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#validate_from_utc-1">SentinelThreatIntelligenceIndicator#validate_from_utc</a>.
        /// </summary>
        [<CustomOperation "validate_from_utc">]
        member _.ValidateFromUtc(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, Missing, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ValidateFromUtc <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#workspace_id-1">SentinelThreatIntelligenceIndicator#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, Missing>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#confidence-1">SentinelThreatIntelligenceIndicator#confidence</a>.
        /// </summary>
        [<CustomOperation "confidence">]
        member _.Confidence(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: double) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Confidence <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#created_by-1">SentinelThreatIntelligenceIndicator#created_by</a>.
        /// </summary>
        [<CustomOperation "created_by">]
        member _.CreatedBy(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.CreatedBy <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#description-1">SentinelThreatIntelligenceIndicator#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#extension-1">SentinelThreatIntelligenceIndicator#extension</a>.
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// external_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#external_reference-1">SentinelThreatIntelligenceIndicator#external_reference</a> Accepts: azurerm.IResolvable | azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorExternalReference[]
        /// </summary>
        [<CustomOperation "external_reference">]
        member _.ExternalReference(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ExternalReference <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// granular_marking block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#granular_marking-1">SentinelThreatIntelligenceIndicator#granular_marking</a> Accepts: azurerm.IResolvable | azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorGranularMarking[]
        /// </summary>
        [<CustomOperation "granular_marking">]
        member _.GranularMarking(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.GranularMarking <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#id-1">SentinelThreatIntelligenceIndicator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// kill_chain_phase block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#kill_chain_phase-1">SentinelThreatIntelligenceIndicator#kill_chain_phase</a> Accepts: azurerm.IResolvable | azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorKillChainPhase[]
        /// </summary>
        [<CustomOperation "kill_chain_phase">]
        member _.KillChainPhase(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KillChainPhase <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#language-1">SentinelThreatIntelligenceIndicator#language</a>.
        /// </summary>
        [<CustomOperation "language">]
        member _.Language(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Language <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#object_marking_refs-1">SentinelThreatIntelligenceIndicator#object_marking_refs</a>.
        /// </summary>
        [<CustomOperation "object_marking_refs">]
        member _.ObjectMarkingRefs(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: seq<string>) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ObjectMarkingRefs <- (value |> Seq.toArray))
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_version-1">SentinelThreatIntelligenceIndicator#pattern_version</a>.
        /// </summary>
        [<CustomOperation "pattern_version">]
        member _.PatternVersion(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PatternVersion <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#revoked-1">SentinelThreatIntelligenceIndicator#revoked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "revoked">]
        member _.Revoked(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: bool) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Revoked <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#revoked-1">SentinelThreatIntelligenceIndicator#revoked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "revoked">]
        member _.Revoked(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Revoked <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#tags-1">SentinelThreatIntelligenceIndicator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: seq<string>) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- (value |> Seq.toArray))
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#threat_types-1">SentinelThreatIntelligenceIndicator#threat_types</a>.
        /// </summary>
        [<CustomOperation "threat_types">]
        member _.ThreatTypes(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: seq<string>) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ThreatTypes <- (value |> Seq.toArray))
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#timeouts-1">SentinelThreatIntelligenceIndicator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorTimeouts) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_threat_intelligence_indicator#validate_until_utc-1">SentinelThreatIntelligenceIndicator#validate_until_utc</a>.
        /// </summary>
        [<CustomOperation "validate_until_utc">]
        member _.ValidateUntilUtc(state: SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>, value: string) : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ValidateUntilUtc <- value)
            state : SentinelThreatIntelligenceIndicatorState<'DisplayName, 'Pattern, 'PatternType, 'Source, 'ValidateFromUtc, 'WorkspaceId>

        member _.Run(state: SentinelThreatIntelligenceIndicatorState<Present, Present, Present, Present, Present, Present>) : azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicator =
            let config = azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelThreatIntelligenceIndicator: missing required arguments. Must call: display_name, pattern, pattern_type, source, validate_from_utc, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SentinelThreatIntelligenceIndicatorState<_, _, _, _, _, _>) : azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicator =
            Unchecked.defaultof<azurerm.SentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicator>
