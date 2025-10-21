using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceNetworkConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfiguration")]
    public interface IApprunnerServiceNetworkConfiguration
    {
        /// <summary>egress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_configuration ApprunnerService#egress_configuration}
        /// </remarks>
        [JsiiProperty(name: "egressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration? EgressConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ingress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ingress_configuration ApprunnerService#ingress_configuration}
        /// </remarks>
        [JsiiProperty(name: "ingressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration? IngressConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ip_address_type ApprunnerService#ip_address_type}.</summary>
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddressType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceNetworkConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>egress_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#egress_configuration ApprunnerService#egress_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationEgressConfiguration\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration? EgressConfiguration
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfigurationEgressConfiguration?>();
            }

            /// <summary>ingress_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ingress_configuration ApprunnerService#ingress_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ingressConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration\"}", isOptional: true)]
            public aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration? IngressConfiguration
            {
                get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#ip_address_type ApprunnerService#ip_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddressType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
