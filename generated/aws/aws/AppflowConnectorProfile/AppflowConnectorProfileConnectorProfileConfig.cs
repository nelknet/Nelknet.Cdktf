using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfig")]
    public class AppflowConnectorProfileConnectorProfileConfig : aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfig
    {
        /// <summary>connector_profile_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connector_profile_credentials AppflowConnectorProfile#connector_profile_credentials}
        /// </remarks>
        [JsiiProperty(name: "connectorProfileCredentials", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentials\"}")]
        public aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentials ConnectorProfileCredentials
        {
            get;
            set;
        }

        /// <summary>connector_profile_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connector_profile_properties AppflowConnectorProfile#connector_profile_properties}
        /// </remarks>
        [JsiiProperty(name: "connectorProfileProperties", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileProperties\"}")]
        public aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileProperties ConnectorProfileProperties
        {
            get;
            set;
        }
    }
}
