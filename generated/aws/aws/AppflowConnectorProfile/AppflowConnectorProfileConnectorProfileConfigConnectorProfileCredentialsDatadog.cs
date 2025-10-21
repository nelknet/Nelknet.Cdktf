using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_key AppflowConnectorProfile#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_key AppflowConnectorProfile#application_key}.</summary>
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplicationKey
        {
            get;
            set;
        }
    }
}
