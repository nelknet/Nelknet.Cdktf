using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceNetworkConfiguration")]
    public class ApprunnerServiceNetworkConfiguration : aws.ApprunnerService.IApprunnerServiceNetworkConfiguration
    {
        /// <summary>egress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_configuration ApprunnerService#egress_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "egressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration? EgressConfiguration
        {
            get;
            set;
        }

        /// <summary>ingress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ingress_configuration ApprunnerService#ingress_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ingressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration? IngressConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ip_address_type ApprunnerService#ip_address_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddressType
        {
            get;
            set;
        }
    }
}
