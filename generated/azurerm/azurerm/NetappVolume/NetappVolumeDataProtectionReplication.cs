using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolume.NetappVolumeDataProtectionReplication")]
    public class NetappVolumeDataProtectionReplication : azurerm.NetappVolume.INetappVolumeDataProtectionReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#remote_volume_location NetappVolume#remote_volume_location}.</summary>
        [JsiiProperty(name: "remoteVolumeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteVolumeLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#remote_volume_resource_id NetappVolume#remote_volume_resource_id}.</summary>
        [JsiiProperty(name: "remoteVolumeResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string RemoteVolumeResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#replication_frequency NetappVolume#replication_frequency}.</summary>
        [JsiiProperty(name: "replicationFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string ReplicationFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#endpoint_type NetappVolume#endpoint_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointType
        {
            get;
            set;
        }
    }
}
