using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationOutputReference), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightHbaseClusterPrivateLinkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightHbaseClusterPrivateLinkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightHbaseClusterPrivateLinkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightHbaseClusterPrivateLinkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration\"}}]")]
        public virtual void PutIpConfiguration(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration)}, new object[]{@value});
        }

        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationIpConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationIpConfigurationOutputReference IpConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationIpConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration? IpConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfigurationIpConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterPrivateLinkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
