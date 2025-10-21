using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterWindowsProfileOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWindowsProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterWindowsProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterWindowsProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterWindowsProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterWindowsProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGmsa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa\"}}]")]
        public virtual void PutGmsa(azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGmsa")]
        public virtual void ResetGmsa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicense")]
        public virtual void ResetLicense()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "gmsa", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsaOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterWindowsProfileGmsaOutputReference Gmsa
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterWindowsProfileGmsaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gmsaInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa? GmsaInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string License
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
