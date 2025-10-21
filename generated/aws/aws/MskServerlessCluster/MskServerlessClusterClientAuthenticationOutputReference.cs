using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskServerlessCluster
{
    [JsiiClass(nativeType: typeof(aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationOutputReference), fullyQualifiedName: "aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskServerlessClusterClientAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskServerlessClusterClientAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskServerlessClusterClientAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskServerlessClusterClientAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSasl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}}]")]
        public virtual void PutSasl(aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl)}, new object[]{@value});
        }

        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSaslOutputReference\"}")]
        public virtual aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationSaslOutputReference Sasl
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.MskServerlessClusterClientAuthenticationSaslOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslInput", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthenticationSasl\"}", isOptional: true)]
        public virtual aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl? SaslInput
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthenticationSasl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskServerlessCluster.MskServerlessClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.MskServerlessCluster.IMskServerlessClusterClientAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.MskServerlessCluster.IMskServerlessClusterClientAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
