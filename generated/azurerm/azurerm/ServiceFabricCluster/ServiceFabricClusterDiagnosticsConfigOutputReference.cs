using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricClusterDiagnosticsConfigOutputReference), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricClusterDiagnosticsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricClusterDiagnosticsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceFabricClusterDiagnosticsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterDiagnosticsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlobEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectedAccountKeyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectedAccountKeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueueEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "blobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlobEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectedAccountKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectedAccountKeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
