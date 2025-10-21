using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationCredential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredential")]
    public interface IAppfabricAppAuthorizationCredential
    {
        /// <summary>api_key_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key_credential AppfabricAppAuthorization#api_key_credential}
        /// </remarks>
        [JsiiProperty(name: "apiKeyCredential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiKeyCredential
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth2_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#oauth2_credential AppfabricAppAuthorization#oauth2_credential}
        /// </remarks>
        [JsiiProperty(name: "oauth2Credential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Oauth2Credential
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationCredential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredential")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_key_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key_credential AppfabricAppAuthorization#api_key_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeyCredential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKeyCredential
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>oauth2_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#oauth2_credential AppfabricAppAuthorization#oauth2_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2Credential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Oauth2Credential
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
