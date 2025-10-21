using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiClass(nativeType: typeof(aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOauthRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest\"}}]")]
        public virtual void PutOauthRequest(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessToken")]
        public virtual void ResetAccessToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauthRequest")]
        public virtual void ResetOauthRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "oauthRequest", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequestOutputReference\"}")]
        public virtual aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequestOutputReference OauthRequest
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthRequestInput", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest? OauthRequestInput
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendeskOauthRequest?>();
        }

        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendesk\"}", isOptional: true)]
        public virtual aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendesk? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsZendesk?>();
            set => SetInstanceProperty(value);
        }
    }
}
