using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_token AppflowConnectorProfile#api_token}.</summary>
        [JsiiProperty(name: "apiToken", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiToken
        {
            get;
            set;
        }
    }
}
