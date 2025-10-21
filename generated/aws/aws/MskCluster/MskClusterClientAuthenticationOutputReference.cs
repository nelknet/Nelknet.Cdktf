using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiClass(nativeType: typeof(aws.MskCluster.MskClusterClientAuthenticationOutputReference), fullyQualifiedName: "aws.mskCluster.MskClusterClientAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterClientAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterClientAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskClusterClientAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterClientAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSasl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSasl\"}}]")]
        public virtual void PutSasl(aws.MskCluster.IMskClusterClientAuthenticationSasl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterClientAuthenticationSasl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTls\"}}]")]
        public virtual void PutTls(aws.MskCluster.IMskClusterClientAuthenticationTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskCluster.IMskClusterClientAuthenticationTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSasl")]
        public virtual void ResetSasl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnauthenticated")]
        public virtual void ResetUnauthenticated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSaslOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterClientAuthenticationSaslOutputReference Sasl
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterClientAuthenticationSaslOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTlsOutputReference\"}")]
        public virtual aws.MskCluster.MskClusterClientAuthenticationTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.MskCluster.MskClusterClientAuthenticationTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterClientAuthenticationSasl? SaslInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthenticationSasl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterClientAuthenticationTls? TlsInput
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthenticationTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UnauthenticatedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "unauthenticated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Unauthenticated
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.MskCluster.IMskClusterClientAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.MskCluster.IMskClusterClientAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
