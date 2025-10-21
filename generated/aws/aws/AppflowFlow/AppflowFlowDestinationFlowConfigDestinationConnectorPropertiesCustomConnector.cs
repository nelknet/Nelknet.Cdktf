using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnector")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnector : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#entity_name AppflowFlow#entity_name}.</summary>
        [JsiiProperty(name: "entityName", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#custom_properties AppflowFlow#custom_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CustomProperties
        {
            get;
            set;
        }

        /// <summary>error_handling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomConnectorErrorHandlingConfig? ErrorHandlingConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#id_field_names AppflowFlow#id_field_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idFieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdFieldNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#write_operation_type AppflowFlow#write_operation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeOperationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WriteOperationType
        {
            get;
            set;
        }
    }
}
