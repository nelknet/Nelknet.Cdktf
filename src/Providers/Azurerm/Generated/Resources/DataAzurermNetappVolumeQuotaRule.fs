namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId> = { assignments: ResizeArray<azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule">azurerm_netapp_volume_quota_rule</a>.
    /// </summary>
    type DataAzurermNetappVolumeQuotaRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappVolumeQuotaRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeQuotaRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappVolumeQuotaRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeQuotaRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule#name-1">DataAzurermNetappVolumeQuotaRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappVolumeQuotaRuleState<Missing, 'VolumeId>, value: string) : DataAzurermNetappVolumeQuotaRuleState<Present, 'VolumeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeQuotaRuleState<Present, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule#volume_id-1">DataAzurermNetappVolumeQuotaRule#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: DataAzurermNetappVolumeQuotaRuleState<'Name, Missing>, value: string) : DataAzurermNetappVolumeQuotaRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeQuotaRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule#id-1">DataAzurermNetappVolumeQuotaRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId>, value: string) : DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_quota_rule#timeouts-1">DataAzurermNetappVolumeQuotaRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId>, value: azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRuleTimeouts) : DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappVolumeQuotaRuleState<'Name, 'VolumeId>

        member _.Run(state: DataAzurermNetappVolumeQuotaRuleState<Present, Present>) : azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRule =
            let config = azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappVolumeQuotaRule: missing required arguments. Must call: name, volume_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappVolumeQuotaRuleState<_, _>) : azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRule =
            Unchecked.defaultof<azurerm.DataAzurermNetappVolumeQuotaRule.DataAzurermNetappVolumeQuotaRule>
