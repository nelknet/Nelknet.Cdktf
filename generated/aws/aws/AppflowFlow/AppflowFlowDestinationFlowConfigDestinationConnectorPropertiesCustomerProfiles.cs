using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesCustomerProfiles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#domain_name AppflowFlow#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object_type_name AppflowFlow#object_type_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectTypeName
        {
            get;
            set;
        }
    }
}
