using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeSourceParametersSelfManagedKafkaParametersCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBasicAuth")]
        public virtual void ResetBasicAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateTlsAuth")]
        public virtual void ResetClientCertificateTlsAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaslScram256Auth")]
        public virtual void ResetSaslScram256Auth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaslScram512Auth")]
        public virtual void ResetSaslScram512Auth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BasicAuthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateTlsAuthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateTlsAuthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslScram256AuthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SaslScram256AuthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslScram512AuthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SaslScram512AuthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasicAuth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificateTlsAuth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateTlsAuth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saslScram256Auth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslScram256Auth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saslScram512Auth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslScram512Auth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
