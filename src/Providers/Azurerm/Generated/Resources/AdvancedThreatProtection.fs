namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AdvancedThreatProtectionState<'Enabled, 'TargetResourceId> = { assignments: ResizeArray<azurerm.AdvancedThreatProtection.AdvancedThreatProtectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection">azurerm_advanced_threat_protection</a>.
    /// </summary>
    type AdvancedThreatProtectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AdvancedThreatProtectionState<Missing, Missing>)

        member _.Zero(()) : AdvancedThreatProtectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AdvancedThreatProtectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection#enabled-1">AdvancedThreatProtection#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AdvancedThreatProtectionState<Missing, 'TargetResourceId>, value: bool) : AdvancedThreatProtectionState<Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : AdvancedThreatProtectionState<Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection#enabled-1">AdvancedThreatProtection#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AdvancedThreatProtectionState<Missing, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : AdvancedThreatProtectionState<Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : AdvancedThreatProtectionState<Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection#target_resource_id-1">AdvancedThreatProtection#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: AdvancedThreatProtectionState<'Enabled, Missing>, value: string) : AdvancedThreatProtectionState<'Enabled, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : AdvancedThreatProtectionState<'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection#id-1">AdvancedThreatProtection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AdvancedThreatProtectionState<'Enabled, 'TargetResourceId>, value: string) : AdvancedThreatProtectionState<'Enabled, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AdvancedThreatProtectionState<'Enabled, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/advanced_threat_protection#timeouts-1">AdvancedThreatProtection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AdvancedThreatProtectionState<'Enabled, 'TargetResourceId>, value: azurerm.AdvancedThreatProtection.AdvancedThreatProtectionTimeouts) : AdvancedThreatProtectionState<'Enabled, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AdvancedThreatProtectionState<'Enabled, 'TargetResourceId>

        member _.Run(state: AdvancedThreatProtectionState<Present, Present>) : azurerm.AdvancedThreatProtection.AdvancedThreatProtection =
            let config = azurerm.AdvancedThreatProtection.AdvancedThreatProtectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AdvancedThreatProtection.AdvancedThreatProtection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.advancedThreatProtection: missing required arguments. Must call: enabled, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: AdvancedThreatProtectionState<_, _>) : azurerm.AdvancedThreatProtection.AdvancedThreatProtection =
            Unchecked.defaultof<azurerm.AdvancedThreatProtection.AdvancedThreatProtection>
