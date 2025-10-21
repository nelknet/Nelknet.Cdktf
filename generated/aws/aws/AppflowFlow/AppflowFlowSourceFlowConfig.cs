using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfig")]
    public class AppflowFlowSourceFlowConfig : aws.AppflowFlow.IAppflowFlowSourceFlowConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#connector_type AppflowFlow#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectorType
        {
            get;
            set;
        }

        /// <summary>source_connector_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#source_connector_properties AppflowFlow#source_connector_properties}
        /// </remarks>
        [JsiiProperty(name: "sourceConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}")]
        public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties SourceConnectorProperties
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

        /// <summary>incremental_pull_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#incremental_pull_config AppflowFlow#incremental_pull_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "incrementalPullConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig? IncrementalPullConfig
        {
            get;
            set;
        }
    }
}
