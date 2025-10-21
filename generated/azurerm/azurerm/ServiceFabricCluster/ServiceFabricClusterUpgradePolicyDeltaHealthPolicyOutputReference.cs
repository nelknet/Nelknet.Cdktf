using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterUpgradePolicyDeltaHealthPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxDeltaUnhealthyApplicationsPercent")]
        public virtual void ResetMaxDeltaUnhealthyApplicationsPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxDeltaUnhealthyNodesPercent")]
        public virtual void ResetMaxDeltaUnhealthyNodesPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUpgradeDomainDeltaUnhealthyNodesPercent")]
        public virtual void ResetMaxUpgradeDomainDeltaUnhealthyNodesPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDeltaUnhealthyApplicationsPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDeltaUnhealthyApplicationsPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDeltaUnhealthyNodesPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDeltaUnhealthyNodesPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUpgradeDomainDeltaUnhealthyNodesPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUpgradeDomainDeltaUnhealthyNodesPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxDeltaUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDeltaUnhealthyApplicationsPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDeltaUnhealthyNodesPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUpgradeDomainDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUpgradeDomainDeltaUnhealthyNodesPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
