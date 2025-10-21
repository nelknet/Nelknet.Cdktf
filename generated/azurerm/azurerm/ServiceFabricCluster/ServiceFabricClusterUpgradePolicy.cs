using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy")]
    public class ServiceFabricClusterUpgradePolicy : azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy
    {
        /// <summary>delta_health_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#delta_health_policy ServiceFabricCluster#delta_health_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deltaHealthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy
        {
            get;
            set;
        }

        private object? _forceRestartEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#force_restart_enabled ServiceFabricCluster#force_restart_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceRestartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceRestartEnabled
        {
            get => _forceRestartEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forceRestartEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_retry_timeout ServiceFabricCluster#health_check_retry_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckRetryTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckRetryTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_stable_duration ServiceFabricCluster#health_check_stable_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckStableDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckStableDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_wait_duration ServiceFabricCluster#health_check_wait_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckWaitDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckWaitDuration
        {
            get;
            set;
        }

        /// <summary>health_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_policy ServiceFabricCluster#health_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy? HealthPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_domain_timeout ServiceFabricCluster#upgrade_domain_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeDomainTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeDomainTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_replica_set_check_timeout ServiceFabricCluster#upgrade_replica_set_check_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeReplicaSetCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeReplicaSetCheckTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_timeout ServiceFabricCluster#upgrade_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeTimeout
        {
            get;
            set;
        }
    }
}
