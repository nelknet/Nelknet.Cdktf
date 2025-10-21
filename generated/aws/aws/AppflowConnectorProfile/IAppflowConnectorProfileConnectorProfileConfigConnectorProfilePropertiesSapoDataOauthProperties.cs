using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code_url AppflowConnectorProfile#auth_code_url}.</summary>
        [JsiiProperty(name: "authCodeUrl", typeJson: "{\"primitive\":\"string\"}")]
        string AuthCodeUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth_scopes AppflowConnectorProfile#oauth_scopes}.</summary>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OauthScopes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#token_url AppflowConnectorProfile#token_url}.</summary>
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        string TokenUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code_url AppflowConnectorProfile#auth_code_url}.</summary>
            [JsiiProperty(name: "authCodeUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthCodeUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth_scopes AppflowConnectorProfile#oauth_scopes}.</summary>
            [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OauthScopes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#token_url AppflowConnectorProfile#token_url}.</summary>
            [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string TokenUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
