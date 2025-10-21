using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionReplication")]
    public class NetappVolumeGroupSapHanaVolumeDataProtectionReplication : azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#remote_volume_location NetappVolumeGroupSapHana#remote_volume_location}.</summary>
        [JsiiProperty(name: "remoteVolumeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteVolumeLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#remote_volume_resource_id NetappVolumeGroupSapHana#remote_volume_resource_id}.</summary>
        [JsiiProperty(name: "remoteVolumeResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteVolumeResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#replication_frequency NetappVolumeGroupSapHana#replication_frequency}.</summary>
        [JsiiProperty(name: "replicationFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicationFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#endpoint_type NetappVolumeGroupSapHana#endpoint_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointType
        {
            get;
            set;
        }
    }
}
