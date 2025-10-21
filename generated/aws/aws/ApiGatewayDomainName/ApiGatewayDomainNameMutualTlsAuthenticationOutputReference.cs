using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayDomainName
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthenticationOutputReference), fullyQualifiedName: "aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiGatewayDomainNameMutualTlsAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiGatewayDomainNameMutualTlsAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiGatewayDomainNameMutualTlsAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDomainNameMutualTlsAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTruststoreVersion")]
        public virtual void ResetTruststoreVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "truststoreUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TruststoreUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "truststoreVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TruststoreVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TruststoreUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TruststoreVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthentication\"}", isOptional: true)]
        public virtual aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
