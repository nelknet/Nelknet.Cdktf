using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterEncryptionInfoOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterEncryptionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterEncryptionInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterEncryptionInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterEncryptionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterEncryptionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionInTransit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit\"}}]")]
        public virtual void PutEncryptionInTransit(aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionAtRestKmsKeyArn")]
        public virtual void ResetEncryptionAtRestKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionInTransit")]
        public virtual void ResetEncryptionInTransit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransitOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterEncryptionInfoEncryptionInTransitOutputReference EncryptionInTransit
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterEncryptionInfoEncryptionInTransitOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionAtRestKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransitInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransitInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit?>();
        }

        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionAtRestKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfo\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterEncryptionInfo? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterEncryptionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
