using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialSourceOutputReference), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerRegistryTaskRegistryCredentialSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerRegistryTaskRegistryCredentialSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerRegistryTaskRegistryCredentialSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTaskRegistryCredentialSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoginModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "loginMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
