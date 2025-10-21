using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceNetworkConfigurationEgressConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration")]
    public interface IApprunnerServiceNetworkConfigurationEgressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_type ApprunnerService#egress_type}.</summary>
        [JsiiProperty(name: "egressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EgressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#vpc_connector_arn ApprunnerService#vpc_connector_arn}.</summary>
        [JsiiProperty(name: "vpcConnectorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcConnectorArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceNetworkConfigurationEgressConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_type ApprunnerService#egress_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EgressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#vpc_connector_arn ApprunnerService#vpc_connector_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConnectorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcConnectorArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
