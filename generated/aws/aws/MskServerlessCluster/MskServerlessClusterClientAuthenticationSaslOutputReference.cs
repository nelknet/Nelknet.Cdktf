using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    [JsiiClass(nativeType: typeof(aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationSaslOutputReference), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskServerlessClusterClientAuthenticationSaslOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskServerlessClusterClientAuthenticationSaslOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskServerlessClusterClientAuthenticationSaslOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskServerlessClusterClientAuthenticationSaslOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIam", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam\"}}]")]
        public virtual void PutIam(aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam)}, new object[]{@value});
        }

        [JsiiProperty(name: "iam", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIamOutputReference\"}")]
        public virtual aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIamOutputReference Iam
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIamOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInput", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslIam\"}", isOptional: true)]
        public virtual aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam? IamInput
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSaslIam?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}", isOptional: true)]
        public virtual aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl? InternalValue
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl?>();
            set => SetInstanceProperty(value);
        }
    }
}
