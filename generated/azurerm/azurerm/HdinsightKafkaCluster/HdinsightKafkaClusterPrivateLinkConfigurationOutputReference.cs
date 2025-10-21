using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationOutputReference), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HdinsightKafkaClusterPrivateLinkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HdinsightKafkaClusterPrivateLinkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HdinsightKafkaClusterPrivateLinkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HdinsightKafkaClusterPrivateLinkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIpConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration\"}}]")]
        public virtual void PutIpConfiguration(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration)}, new object[]{@value});
        }

        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfigurationOutputReference\"}")]
        public virtual azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfigurationOutputReference IpConfiguration
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipConfigurationInput", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration? IpConfigurationInput
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public virtual azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
