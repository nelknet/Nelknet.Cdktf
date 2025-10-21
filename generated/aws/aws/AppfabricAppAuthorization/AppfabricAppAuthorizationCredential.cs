using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiByValue(fqn: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredential")]
    public class AppfabricAppAuthorizationCredential : aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredential
    {
        private object? _apiKeyCredential;

        /// <summary>api_key_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key_credential AppfabricAppAuthorization#api_key_credential}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeyCredential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiKeyCredential
        {
            get => _apiKeyCredential;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiKeyCredential = value;
            }
        }

        private object? _oauth2Credential;

        /// <summary>oauth2_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#oauth2_credential AppfabricAppAuthorization#oauth2_credential}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2Credential", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Oauth2Credential
        {
            get => _oauth2Credential;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _oauth2Credential = value;
            }
        }
    }
}
