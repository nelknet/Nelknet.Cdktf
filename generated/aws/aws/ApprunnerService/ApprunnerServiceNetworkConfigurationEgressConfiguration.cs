using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration")]
    public class ApprunnerServiceNetworkConfigurationEgressConfiguration : aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_type ApprunnerService#egress_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EgressType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#vpc_connector_arn ApprunnerService#vpc_connector_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConnectorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcConnectorArn
        {
            get;
            set;
        }
    }
}
