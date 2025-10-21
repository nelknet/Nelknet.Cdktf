namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume> = { assignments: ResizeArray<azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHanaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana">azurerm_netapp_volume_group_sap_hana</a>.
    /// </summary>
    type NetappVolumeGroupSapHanaBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappVolumeGroupSapHanaState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeGroupSapHanaState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappVolumeGroupSapHanaState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeGroupSapHanaState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#account_name-1">NetappVolumeGroupSapHana#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: NetappVolumeGroupSapHanaState<Missing, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<Present, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<Present, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#application_identifier-1">NetappVolumeGroupSapHana#application_identifier</a>.
        /// </summary>
        [<CustomOperation "application_identifier">]
        member _.ApplicationIdentifier(state: NetappVolumeGroupSapHanaState<'AccountName, Missing, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, Present, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.ApplicationIdentifier <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, Present, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#group_description-1">NetappVolumeGroupSapHana#group_description</a>.
        /// </summary>
        [<CustomOperation "group_description">]
        member _.GroupDescription(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, Missing, 'Location, 'Name, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, Present, 'Location, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.GroupDescription <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, Present, 'Location, 'Name, 'ResourceGroupName, 'Volume>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#location-1">NetappVolumeGroupSapHana#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, Missing, 'Name, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, Present, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, Present, 'Name, 'ResourceGroupName, 'Volume>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#name-1">NetappVolumeGroupSapHana#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, Missing, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, Present, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, Present, 'ResourceGroupName, 'Volume>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#resource_group_name-1">NetappVolumeGroupSapHana#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, Missing, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, Present, 'Volume> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, Present, 'Volume>)

        /// <summary>
        /// volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#volume-1">NetappVolumeGroupSapHana#volume</a> Accepts: azurerm.IResolvable | azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolume[]
        /// </summary>
        [<CustomOperation "volume">]
        member _.Volume(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Volume <- value)
            ({ assignments = state.assignments } : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#id-1">NetappVolumeGroupSapHana#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>, value: string) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#timeouts-1">NetappVolumeGroupSapHana#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>, value: azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHanaTimeouts) : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappVolumeGroupSapHanaState<'AccountName, 'ApplicationIdentifier, 'GroupDescription, 'Location, 'Name, 'ResourceGroupName, 'Volume>

        member _.Run(state: NetappVolumeGroupSapHanaState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHana =
            let config = azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHanaConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHana(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappVolumeGroupSapHana: missing required arguments. Must call: account_name, application_identifier, group_description, location, name, resource_group_name, volume.", 9999, IsError = true)>]
        member _.Run(_: NetappVolumeGroupSapHanaState<_, _, _, _, _, _, _>) : azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHana =
            Unchecked.defaultof<azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHana>
