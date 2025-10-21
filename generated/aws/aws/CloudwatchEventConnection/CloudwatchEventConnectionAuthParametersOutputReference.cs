using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOutputReference), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventConnectionAuthParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventConnectionAuthParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventConnectionAuthParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApiKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKey\"}}]")]
        public virtual void PutApiKey(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasic\"}}]")]
        public virtual void PutBasic(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvocationHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}}]")]
        public virtual void PutInvocationHttpParameters(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}}]")]
        public virtual void PutOauth(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKey")]
        public virtual void ResetApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBasic")]
        public virtual void ResetBasic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvocationHttpParameters")]
        public virtual void ResetInvocationHttpParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth")]
        public virtual void ResetOauth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "apiKey", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKeyOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKeyOutputReference ApiKey
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKeyOutputReference>()!;
        }

        [JsiiProperty(name: "basic", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasicOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasicOutputReference Basic
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasicOutputReference>()!;
        }

        [JsiiProperty(name: "invocationHttpParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference InvocationHttpParameters
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParametersOutputReference>()!;
        }

        [JsiiProperty(name: "oauth", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOutputReference Oauth
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersApiKey\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey? ApiKeyInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersApiKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersBasic\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic? BasicInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invocationHttpParametersInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersInvocationHttpParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters? InvocationHttpParametersInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersInvocationHttpParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersOauth\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth? OauthInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersOauth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParameters? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
