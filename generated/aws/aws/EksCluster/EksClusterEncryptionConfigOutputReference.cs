using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterEncryptionConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterEncryptionConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterEncryptionConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterEncryptionConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterEncryptionConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterEncryptionConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigProvider\"}}]")]
        public virtual void PutProvider(aws.EksCluster.IEksClusterEncryptionConfigProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterEncryptionConfigProvider)}, new object[]{@value});
        }

        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigProviderOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterEncryptionConfigProviderOutputReference Provider
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterEncryptionConfigProviderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigProvider\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterEncryptionConfigProvider? ProviderInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterEncryptionConfigProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterEncryptionConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterEncryptionConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
