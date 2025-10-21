using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LoadTest
{
    [JsiiClass(nativeType: typeof(azurerm.LoadTest.LoadTestEncryptionOutputReference), fullyQualifiedName: "azurerm.loadTest.LoadTestEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadTestEncryptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadTestEncryptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LoadTestEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadTestEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.LoadTest.ILoadTestEncryptionIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LoadTest.ILoadTestEncryptionIdentity)}, new object[]{@value});
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentityOutputReference\"}")]
        public virtual azurerm.LoadTest.LoadTestEncryptionIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.LoadTest.LoadTestEncryptionIdentityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentity\"}", isOptional: true)]
        public virtual azurerm.LoadTest.ILoadTestEncryptionIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.LoadTest.ILoadTestEncryptionIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryption\"}", isOptional: true)]
        public virtual azurerm.LoadTest.ILoadTestEncryption? InternalValue
        {
            get => GetInstanceProperty<azurerm.LoadTest.ILoadTestEncryption?>();
            set => SetInstanceProperty(value);
        }
    }
}
