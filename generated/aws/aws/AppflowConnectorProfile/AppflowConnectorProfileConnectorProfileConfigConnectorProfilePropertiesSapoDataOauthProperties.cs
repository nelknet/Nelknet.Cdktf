using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code_url AppflowConnectorProfile#auth_code_url}.</summary>
        [JsiiProperty(name: "authCodeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthCodeUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth_scopes AppflowConnectorProfile#oauth_scopes}.</summary>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] OauthScopes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#token_url AppflowConnectorProfile#token_url}.</summary>
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string TokenUrl
        {
            get;
            set;
        }
    }
}
