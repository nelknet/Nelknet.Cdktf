using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfiguration")]
    public class FinspaceKxEnvironmentTransitGatewayConfiguration : aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#routable_cidr_space FinspaceKxEnvironment#routable_cidr_space}.</summary>
        [JsiiProperty(name: "routableCidrSpace", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutableCidrSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#transit_gateway_id FinspaceKxEnvironment#transit_gateway_id}.</summary>
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public string TransitGatewayId
        {
            get;
            set;
        }

        private object? _attachmentNetworkAclConfiguration;

        /// <summary>attachment_network_acl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#attachment_network_acl_configuration FinspaceKxEnvironment#attachment_network_acl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachmentNetworkAclConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AttachmentNetworkAclConfiguration
        {
            get => _attachmentNetworkAclConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentTransitGatewayConfigurationAttachmentNetworkAclConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _attachmentNetworkAclConfiguration = value;
            }
        }
    }
}
