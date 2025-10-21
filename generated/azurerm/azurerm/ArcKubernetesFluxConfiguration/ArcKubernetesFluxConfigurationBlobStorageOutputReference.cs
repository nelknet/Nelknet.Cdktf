using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesFluxConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageOutputReference), fullyQualifiedName: "azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ArcKubernetesFluxConfigurationBlobStorageOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ArcKubernetesFluxConfigurationBlobStorageOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ArcKubernetesFluxConfigurationBlobStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcKubernetesFluxConfigurationBlobStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putServicePrincipal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageServicePrincipal\"}}]")]
        public virtual void PutServicePrincipal(azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorageServicePrincipal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorageServicePrincipal)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountKey")]
        public virtual void ResetAccountKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalAuthReference")]
        public virtual void ResetLocalAuthReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSasToken")]
        public virtual void ResetSasToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServicePrincipal")]
        public virtual void ResetServicePrincipal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyncIntervalInSeconds")]
        public virtual void ResetSyncIntervalInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInSeconds")]
        public virtual void ResetTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageServicePrincipalOutputReference\"}")]
        public virtual azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageServicePrincipalOutputReference ServicePrincipal
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageServicePrincipalOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localAuthReferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalAuthReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sasTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SasTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalInput", typeJson: "{\"fqn\":\"azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorageServicePrincipal\"}", isOptional: true)]
        public virtual azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorageServicePrincipal? ServicePrincipalInput
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorageServicePrincipal?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syncIntervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SyncIntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localAuthReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalAuthReference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sasToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SasToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "syncIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SyncIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.arcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorage\"}", isOptional: true)]
        public virtual azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorage? InternalValue
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesFluxConfiguration.IArcKubernetesFluxConfigurationBlobStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
