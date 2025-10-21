using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterUpgradePolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy")]
    public interface IServiceFabricClusterUpgradePolicy
    {
        /// <summary>delta_health_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#delta_health_policy ServiceFabricCluster#delta_health_policy}
        /// </remarks>
        [JsiiProperty(name: "deltaHealthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#force_restart_enabled ServiceFabricCluster#force_restart_enabled}.</summary>
        [JsiiProperty(name: "forceRestartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceRestartEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_retry_timeout ServiceFabricCluster#health_check_retry_timeout}.</summary>
        [JsiiProperty(name: "healthCheckRetryTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckRetryTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_stable_duration ServiceFabricCluster#health_check_stable_duration}.</summary>
        [JsiiProperty(name: "healthCheckStableDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckStableDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_wait_duration ServiceFabricCluster#health_check_wait_duration}.</summary>
        [JsiiProperty(name: "healthCheckWaitDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckWaitDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_policy ServiceFabricCluster#health_policy}
        /// </remarks>
        [JsiiProperty(name: "healthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy? HealthPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_domain_timeout ServiceFabricCluster#upgrade_domain_timeout}.</summary>
        [JsiiProperty(name: "upgradeDomainTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeDomainTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_replica_set_check_timeout ServiceFabricCluster#upgrade_replica_set_check_timeout}.</summary>
        [JsiiProperty(name: "upgradeReplicaSetCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeReplicaSetCheckTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_timeout ServiceFabricCluster#upgrade_timeout}.</summary>
        [JsiiProperty(name: "upgradeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpgradeTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterUpgradePolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>delta_health_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#delta_health_policy ServiceFabricCluster#delta_health_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deltaHealthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}", isOptional: true)]
            public azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicy
            {
                get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#force_restart_enabled ServiceFabricCluster#force_restart_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceRestartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceRestartEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_retry_timeout ServiceFabricCluster#health_check_retry_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckRetryTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckRetryTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_stable_duration ServiceFabricCluster#health_check_stable_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckStableDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckStableDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_check_wait_duration ServiceFabricCluster#health_check_wait_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckWaitDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckWaitDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>health_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#health_policy ServiceFabricCluster#health_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy\"}", isOptional: true)]
            public azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy? HealthPolicy
            {
                get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_domain_timeout ServiceFabricCluster#upgrade_domain_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeDomainTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeDomainTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_replica_set_check_timeout ServiceFabricCluster#upgrade_replica_set_check_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeReplicaSetCheckTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeReplicaSetCheckTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_timeout ServiceFabricCluster#upgrade_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpgradeTimeout
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
