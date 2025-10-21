using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolume")]
    public class NetappVolumeGroupSapHanaVolume : azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#capacity_pool_id NetappVolumeGroupSapHana#capacity_pool_id}.</summary>
        [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityPoolId
        {
            get;
            set;
        }

        private object _exportPolicyRule;

        /// <summary>export_policy_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#export_policy_rule NetappVolumeGroupSapHana#export_policy_rule}
        /// </remarks>
        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}")]
        public object ExportPolicyRule
        {
            get => _exportPolicyRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeExportPolicyRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeExportPolicyRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeExportPolicyRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exportPolicyRule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#name NetappVolumeGroupSapHana#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#protocols NetappVolumeGroupSapHana#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Protocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#security_style NetappVolumeGroupSapHana#security_style}.</summary>
        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public string SecurityStyle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#service_level NetappVolumeGroupSapHana#service_level}.</summary>
        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceLevel
        {
            get;
            set;
        }

        private object _snapshotDirectoryVisible;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#snapshot_directory_visible NetappVolumeGroupSapHana#snapshot_directory_visible}.</summary>
        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object SnapshotDirectoryVisible
        {
            get => _snapshotDirectoryVisible;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _snapshotDirectoryVisible = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#storage_quota_in_gb NetappVolumeGroupSapHana#storage_quota_in_gb}.</summary>
        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double StorageQuotaInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#subnet_id NetappVolumeGroupSapHana#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#throughput_in_mibps NetappVolumeGroupSapHana#throughput_in_mibps}.</summary>
        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public double ThroughputInMibps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#volume_path NetappVolumeGroupSapHana#volume_path}.</summary>
        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#volume_spec_name NetappVolumeGroupSapHana#volume_spec_name}.</summary>
        [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeSpecName
        {
            get;
            set;
        }

        /// <summary>data_protection_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#data_protection_replication NetappVolumeGroupSapHana#data_protection_replication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionReplication\"}", isOptional: true)]
        public azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionReplication? DataProtectionReplication
        {
            get;
            set;
        }

        /// <summary>data_protection_snapshot_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#data_protection_snapshot_policy NetappVolumeGroupSapHana#data_protection_snapshot_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
        public azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#proximity_placement_group_id NetappVolumeGroupSapHana#proximity_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProximityPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#tags NetappVolumeGroupSapHana#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
