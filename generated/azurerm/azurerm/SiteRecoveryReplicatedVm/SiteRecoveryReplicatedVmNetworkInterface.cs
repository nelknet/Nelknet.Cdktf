using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterface")]
    public class SiteRecoveryReplicatedVmNetworkInterface : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#failover_test_public_ip_address_id SiteRecoveryReplicatedVm#failover_test_public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestPublicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestPublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#failover_test_static_ip SiteRecoveryReplicatedVm#failover_test_static_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestStaticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestStaticIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#failover_test_subnet_name SiteRecoveryReplicatedVm#failover_test_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverTestSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverTestSubnetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#recovery_public_ip_address_id SiteRecoveryReplicatedVm#recovery_public_ip_address_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryPublicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryPublicIpAddressId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#source_network_interface_id SiteRecoveryReplicatedVm#source_network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceNetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_static_ip SiteRecoveryReplicatedVm#target_static_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetStaticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetStaticIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_subnet_name SiteRecoveryReplicatedVm#target_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetSubnetName
        {
            get;
            set;
        }
    }
}
