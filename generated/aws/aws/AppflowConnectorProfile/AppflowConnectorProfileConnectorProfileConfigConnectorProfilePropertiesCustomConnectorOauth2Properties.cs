using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOauth2Properties")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOauth2Properties : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesCustomConnectorOauth2Properties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth2_grant_type AppflowConnectorProfile#oauth2_grant_type}.</summary>
        [JsiiProperty(name: "oauth2GrantType", typeJson: "{\"primitive\":\"string\"}")]
        public string Oauth2GrantType
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#token_url_custom_properties AppflowConnectorProfile#token_url_custom_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tokenUrlCustomProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TokenUrlCustomProperties
        {
            get;
            set;
        }
    }
}
