namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> = { assignments: ResizeArray<azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule">azurerm_netapp_volume_quota_rule</a>.
    /// </summary>
    type NetappVolumeQuotaRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappVolumeQuotaRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeQuotaRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappVolumeQuotaRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeQuotaRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#location-1">NetappVolumeQuotaRule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappVolumeQuotaRuleState<Missing, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>, value: string) : NetappVolumeQuotaRuleState<Present, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappVolumeQuotaRuleState<Present, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#name-1">NetappVolumeQuotaRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappVolumeQuotaRuleState<'Location, Missing, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>, value: string) : NetappVolumeQuotaRuleState<'Location, Present, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappVolumeQuotaRuleState<'Location, Present, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#quota_size_in_kib-1">NetappVolumeQuotaRule#quota_size_in_kib</a>.
        /// </summary>
        [<CustomOperation "quota_size_in_kib">]
        member _.QuotaSizeInKib(state: NetappVolumeQuotaRuleState<'Location, 'Name, Missing, 'QuotaType, 'VolumeId>, value: double) : NetappVolumeQuotaRuleState<'Location, 'Name, Present, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.QuotaSizeInKib <- value)
            ({ assignments = state.assignments } : NetappVolumeQuotaRuleState<'Location, 'Name, Present, 'QuotaType, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#quota_type-1">NetappVolumeQuotaRule#quota_type</a>.
        /// </summary>
        [<CustomOperation "quota_type">]
        member _.QuotaType(state: NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, Missing, 'VolumeId>, value: string) : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, Present, 'VolumeId> =
            state.assignments.Add(fun config -> config.QuotaType <- value)
            ({ assignments = state.assignments } : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, Present, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#volume_id-1">NetappVolumeQuotaRule#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, Missing>, value: string) : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#id-1">NetappVolumeQuotaRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>, value: string) : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#quota_target-1">NetappVolumeQuotaRule#quota_target</a>.
        /// </summary>
        [<CustomOperation "quota_target">]
        member _.QuotaTarget(state: NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>, value: string) : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.QuotaTarget <- value)
            state : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_quota_rule#timeouts-1">NetappVolumeQuotaRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>, value: azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRuleTimeouts) : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappVolumeQuotaRuleState<'Location, 'Name, 'QuotaSizeInKib, 'QuotaType, 'VolumeId>

        member _.Run(state: NetappVolumeQuotaRuleState<Present, Present, Present, Present, Present>) : azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRule =
            let config = azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappVolumeQuotaRule: missing required arguments. Must call: location, name, quota_size_in_kib, quota_type, volume_id.", 9999, IsError = true)>]
        member _.Run(_: NetappVolumeQuotaRuleState<_, _, _, _, _>) : azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRule =
            Unchecked.defaultof<azurerm.NetappVolumeQuotaRule.NetappVolumeQuotaRule>
