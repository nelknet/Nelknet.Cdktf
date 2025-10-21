using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference), fullyQualifiedName: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeGroupSapHanaVolumeDataProtectionReplicationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEndpointType")]
        public virtual void ResetEndpointType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteVolumeLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteVolumeLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteVolumeResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteVolumeResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remoteVolumeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteVolumeLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remoteVolumeResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteVolumeResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionReplication\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionReplication? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionReplication?>();
            set => SetInstanceProperty(value);
        }
    }
}
