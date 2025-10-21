using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfig")]
    public class AppflowFlowDestinationFlowConfig : aws.AppflowFlow.IAppflowFlowDestinationFlowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_type AppflowFlow#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectorType
        {
            get;
            set;
        }

        /// <summary>destination_connector_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#destination_connector_properties AppflowFlow#destination_connector_properties}
        /// </remarks>
        [JsiiProperty(name: "destinationConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorProperties\"}")]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorProperties DestinationConnectorProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#api_version AppflowFlow#api_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_profile_name AppflowFlow#connector_profile_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectorProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectorProfileName
        {
            get;
            set;
        }
    }
}
