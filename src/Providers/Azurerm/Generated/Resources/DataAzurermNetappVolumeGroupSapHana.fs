namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana">azurerm_netapp_volume_group_sap_hana</a>.
    /// </summary>
    type DataAzurermNetappVolumeGroupSapHanaBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappVolumeGroupSapHanaState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeGroupSapHanaState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappVolumeGroupSapHanaState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeGroupSapHanaState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#account_name-1">DataAzurermNetappVolumeGroupSapHana#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermNetappVolumeGroupSapHanaState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeGroupSapHanaState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeGroupSapHanaState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#name-1">DataAzurermNetappVolumeGroupSapHana#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappVolumeGroupSapHanaState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#resource_group_name-1">DataAzurermNetappVolumeGroupSapHana#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, Missing>, value: string) : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#id-1">DataAzurermNetappVolumeGroupSapHana#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#timeouts-1">DataAzurermNetappVolumeGroupSapHana#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaTimeouts) : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappVolumeGroupSapHanaState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetappVolumeGroupSapHanaState<Present, Present, Present>) : azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHana =
            let config = azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHana(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappVolumeGroupSapHana: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappVolumeGroupSapHanaState<_, _, _>) : azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHana =
            Unchecked.defaultof<azurerm.DataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHana>
