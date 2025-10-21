using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector : aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesCustomConnector
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
    }
}
