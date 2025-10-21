using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxEnvironmentTransitGatewayConfiguration), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfiguration")]
    public interface IFinspaceKxEnvironmentTransitGatewayConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#routable_cidr_space FinspaceKxEnvironment#routable_cidr_space}.</summary>
        [JsiiProperty(name: "routableCidrSpace", typeJson: "{\"primitive\":\"string\"}")]
        string RoutableCidrSpace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#transit_gateway_id FinspaceKxEnvironment#transit_gateway_id}.</summary>
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        string TransitGatewayId
        {
            get;
        }

        /// <summary>attachment_network_acl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#attachment_network_acl_configuration FinspaceKxEnvironment#attachment_network_acl_configuration}
        /// </remarks>
        [JsiiProperty(name: "attachmentNetworkAclConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AttachmentNetworkAclConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxEnvironmentTransitGatewayConfiguration), fullyQualifiedName: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#routable_cidr_space FinspaceKxEnvironment#routable_cidr_space}.</summary>
            [JsiiProperty(name: "routableCidrSpace", typeJson: "{\"primitive\":\"string\"}")]
            public string RoutableCidrSpace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#transit_gateway_id FinspaceKxEnvironment#transit_gateway_id}.</summary>
            [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitGatewayId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>attachment_network_acl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#attachment_network_acl_configuration FinspaceKxEnvironment#attachment_network_acl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attachmentNetworkAclConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AttachmentNetworkAclConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
