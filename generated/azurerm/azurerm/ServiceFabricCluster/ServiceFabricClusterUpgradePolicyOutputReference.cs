using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyOutputReference), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricClusterUpgradePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricClusterUpgradePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterUpgradePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterUpgradePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeltaHealthPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}}]")]
        public virtual void PutDeltaHealthPolicy(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy\"}}]")]
        public virtual void PutHealthPolicy(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeltaHealthPolicy")]
        public virtual void ResetDeltaHealthPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceRestartEnabled")]
        public virtual void ResetForceRestartEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckRetryTimeout")]
        public virtual void ResetHealthCheckRetryTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckStableDuration")]
        public virtual void ResetHealthCheckStableDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckWaitDuration")]
        public virtual void ResetHealthCheckWaitDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthPolicy")]
        public virtual void ResetHealthPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeDomainTimeout")]
        public virtual void ResetUpgradeDomainTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeReplicaSetCheckTimeout")]
        public virtual void ResetUpgradeReplicaSetCheckTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeTimeout")]
        public virtual void ResetUpgradeTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "deltaHealthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference DeltaHealthPolicy
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "healthPolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicyOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicyOutputReference HealthPolicy
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deltaHealthPolicyInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy? DeltaHealthPolicyInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceRestartEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceRestartEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckRetryTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckRetryTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckStableDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckStableDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckWaitDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckWaitDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthPolicyInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy? HealthPolicyInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeDomainTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeDomainTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeReplicaSetCheckTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeReplicaSetCheckTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "forceRestartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceRestartEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "healthCheckRetryTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckRetryTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckStableDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckStableDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckWaitDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckWaitDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradeDomainTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeDomainTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradeReplicaSetCheckTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeReplicaSetCheckTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradeTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
