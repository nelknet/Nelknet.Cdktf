namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> = { assignments: ResizeArray<azurerm.NetappVolume.NetappVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume">azurerm_netapp_volume</a>.
    /// </summary>
    type NetappVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappVolumeState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappVolumeState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappVolumeState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#account_name-1">NetappVolume#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: NetappVolumeState<Missing, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<Present, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : NetappVolumeState<Present, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#location-1">NetappVolume#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappVolumeState<'AccountName, Missing, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, Present, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, Present, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#name-1">NetappVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappVolumeState<'AccountName, 'Location, Missing, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, Present, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, Present, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#pool_name-1">NetappVolume#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: NetappVolumeState<'AccountName, 'Location, 'Name, Missing, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#resource_group_name-1">NetappVolume#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, Missing, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, Present, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, Present, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#service_level-1">NetappVolume#service_level</a>.
        /// </summary>
        [<CustomOperation "service_level">]
        member _.ServiceLevel(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Missing, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Present, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.ServiceLevel <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Present, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#storage_quota_in_gb-1">NetappVolume#storage_quota_in_gb</a>.
        /// </summary>
        [<CustomOperation "storage_quota_in_gb">]
        member _.StorageQuotaInGb(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, Missing, 'SubnetId, 'VolumePath>, value: double) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, Present, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.StorageQuotaInGb <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, Present, 'SubnetId, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#subnet_id-1">NetappVolume#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, Missing, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, Present, 'VolumePath> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, Present, 'VolumePath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#volume_path-1">NetappVolume#volume_path</a>.
        /// </summary>
        [<CustomOperation "volume_path">]
        member _.VolumePath(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, Missing>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, Present> =
            state.assignments.Add(fun config -> config.VolumePath <- value)
            ({ assignments = state.assignments } : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#azure_vmware_data_store_enabled-1">NetappVolume#azure_vmware_data_store_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_vmware_data_store_enabled">]
        member _.AzureVmwareDataStoreEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.AzureVmwareDataStoreEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#azure_vmware_data_store_enabled-1">NetappVolume#azure_vmware_data_store_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_vmware_data_store_enabled">]
        member _.AzureVmwareDataStoreEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.AzureVmwareDataStoreEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#create_from_snapshot_resource_id-1">NetappVolume#create_from_snapshot_resource_id</a>.
        /// </summary>
        [<CustomOperation "create_from_snapshot_resource_id">]
        member _.CreateFromSnapshotResourceId(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.CreateFromSnapshotResourceId <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// data_protection_replication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#data_protection_replication-1">NetappVolume#data_protection_replication</a>
        /// </summary>
        [<CustomOperation "data_protection_replication">]
        member _.DataProtectionReplication(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: azurerm.NetappVolume.NetappVolumeDataProtectionReplication) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.DataProtectionReplication <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// data_protection_snapshot_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#data_protection_snapshot_policy-1">NetappVolume#data_protection_snapshot_policy</a>
        /// </summary>
        [<CustomOperation "data_protection_snapshot_policy">]
        member _.DataProtectionSnapshotPolicy(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: azurerm.NetappVolume.NetappVolumeDataProtectionSnapshotPolicy) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.DataProtectionSnapshotPolicy <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#encryption_key_source-1">NetappVolume#encryption_key_source</a>.
        /// </summary>
        [<CustomOperation "encryption_key_source">]
        member _.EncryptionKeySource(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.EncryptionKeySource <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// export_policy_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#export_policy_rule-1">NetappVolume#export_policy_rule</a> Accepts: azurerm.IResolvable | azurerm.NetappVolume.NetappVolumeExportPolicyRule[]
        /// </summary>
        [<CustomOperation "export_policy_rule">]
        member _.ExportPolicyRule(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.ExportPolicyRule <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#id-1">NetappVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#kerberos_enabled-1">NetappVolume#kerberos_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "kerberos_enabled">]
        member _.KerberosEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.KerberosEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#kerberos_enabled-1">NetappVolume#kerberos_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "kerberos_enabled">]
        member _.KerberosEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.KerberosEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#key_vault_private_endpoint_id-1">NetappVolume#key_vault_private_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_private_endpoint_id">]
        member _.KeyVaultPrivateEndpointId(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.KeyVaultPrivateEndpointId <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#network_features-1">NetappVolume#network_features</a>.
        /// </summary>
        [<CustomOperation "network_features">]
        member _.NetworkFeatures(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.NetworkFeatures <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#protocols-1">NetappVolume#protocols</a>.
        /// </summary>
        [<CustomOperation "protocols">]
        member _.Protocols(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: seq<string>) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Protocols <- (value |> Seq.toArray))
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#security_style-1">NetappVolume#security_style</a>.
        /// </summary>
        [<CustomOperation "security_style">]
        member _.SecurityStyle(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SecurityStyle <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb3_protocol_encryption_enabled-1">NetappVolume#smb3_protocol_encryption_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb3_protocol_encryption_enabled">]
        member _.Smb3ProtocolEncryptionEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Smb3ProtocolEncryptionEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb3_protocol_encryption_enabled-1">NetappVolume#smb3_protocol_encryption_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb3_protocol_encryption_enabled">]
        member _.Smb3ProtocolEncryptionEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Smb3ProtocolEncryptionEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_access_based_enumeration_enabled-1">NetappVolume#smb_access_based_enumeration_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_access_based_enumeration_enabled">]
        member _.SmbAccessBasedEnumerationEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbAccessBasedEnumerationEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_access_based_enumeration_enabled-1">NetappVolume#smb_access_based_enumeration_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_access_based_enumeration_enabled">]
        member _.SmbAccessBasedEnumerationEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbAccessBasedEnumerationEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_continuous_availability_enabled-1">NetappVolume#smb_continuous_availability_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_continuous_availability_enabled">]
        member _.SmbContinuousAvailabilityEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbContinuousAvailabilityEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_continuous_availability_enabled-1">NetappVolume#smb_continuous_availability_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_continuous_availability_enabled">]
        member _.SmbContinuousAvailabilityEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbContinuousAvailabilityEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_non_browsable_enabled-1">NetappVolume#smb_non_browsable_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_non_browsable_enabled">]
        member _.SmbNonBrowsableEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbNonBrowsableEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#smb_non_browsable_enabled-1">NetappVolume#smb_non_browsable_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "smb_non_browsable_enabled">]
        member _.SmbNonBrowsableEnabled(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SmbNonBrowsableEnabled <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#snapshot_directory_visible-1">NetappVolume#snapshot_directory_visible</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "snapshot_directory_visible">]
        member _.SnapshotDirectoryVisible(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: bool) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SnapshotDirectoryVisible <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#snapshot_directory_visible-1">NetappVolume#snapshot_directory_visible</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "snapshot_directory_visible">]
        member _.SnapshotDirectoryVisible(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: HashiCorp.Cdktf.IResolvable) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.SnapshotDirectoryVisible <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#tags-1">NetappVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: seq<string * string>) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#throughput_in_mibps-1">NetappVolume#throughput_in_mibps</a>.
        /// </summary>
        [<CustomOperation "throughput_in_mibps">]
        member _.ThroughputInMibps(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: double) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.ThroughputInMibps <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#timeouts-1">NetappVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: azurerm.NetappVolume.NetappVolumeTimeouts) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#zone-1">NetappVolume#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>, value: string) : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : NetappVolumeState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'ServiceLevel, 'StorageQuotaInGb, 'SubnetId, 'VolumePath>

        member _.Run(state: NetappVolumeState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.NetappVolume.NetappVolume =
            let config = azurerm.NetappVolume.NetappVolumeConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappVolume.NetappVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappVolume: missing required arguments. Must call: account_name, location, name, pool_name, resource_group_name, service_level, storage_quota_in_gb, subnet_id, volume_path.", 9999, IsError = true)>]
        member _.Run(_: NetappVolumeState<_, _, _, _, _, _, _, _, _>) : azurerm.NetappVolume.NetappVolume =
            Unchecked.defaultof<azurerm.NetappVolume.NetappVolume>
