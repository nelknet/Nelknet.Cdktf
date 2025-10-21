using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTokenPassword
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2OutputReference), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerRegistryTokenPasswordPassword2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerRegistryTokenPasswordPassword2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerRegistryTokenPasswordPassword2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTokenPasswordPassword2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExpiry")]
        public virtual void ResetExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpiryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expiry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2?>();
            set => SetInstanceProperty(value);
        }
    }
}
