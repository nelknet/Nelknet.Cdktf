using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOutputReference), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventConnectionAuthParametersOauthOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventConnectionAuthParametersOauthOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventConnectionAuthParametersOauthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOauthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}}]")]
        public virtual void PutClientParameters(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauthHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}}]")]
        public virtual void PutOauthHttpParameters(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientParameters")]
        public virtual void ResetClientParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference ClientParameters
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParametersOutputReference>()!;
        }

        [JsiiProperty(name: "oauthHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference OauthHttpParameters
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientParametersInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthClientParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters? ClientParametersInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthClientParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthHttpParametersInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOauthHttpParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters? OauthHttpParametersInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauthOauthHttpParameters?>();
        }

        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth?>();
            set => SetInstanceProperty(value);
        }
    }
}
