using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsSalesforceOauthRequest")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsSalesforceOauthRequest : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsSalesforceOauthRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code AppflowConnectorProfile#auth_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#redirect_uri AppflowConnectorProfile#redirect_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectUri
        {
            get;
            set;
        }
    }
}
