using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsTrendmicro")]
    public class AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsTrendmicro : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsTrendmicro
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_secret_key AppflowConnectorProfile#api_secret_key}.</summary>
        [JsiiProperty(name: "apiSecretKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiSecretKey
        {
            get;
            set;
        }
    }
}
