using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileOutputReference), fullyQualifiedName: "azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermKubernetesClusterAgentPoolProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermKubernetesClusterAgentPoolProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesClusterAgentPoolProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesClusterAgentPoolProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoScalingEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Count
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxPods", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPods
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeLabels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap NodeLabels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable NodePublicIpEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "nodePublicIpPrefixId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodePublicIpPrefixId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeTaints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NodeTaints
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "orchestratorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrchestratorVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osDiskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OsDiskSizeGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeSettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileUpgradeSettingsList\"}")]
        public virtual azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileUpgradeSettingsList UpgradeSettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfileUpgradeSettingsList>()!;
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnetSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnetSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterAgentPoolProfile\"}", isOptional: true)]
        public virtual azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterAgentPoolProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterAgentPoolProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
