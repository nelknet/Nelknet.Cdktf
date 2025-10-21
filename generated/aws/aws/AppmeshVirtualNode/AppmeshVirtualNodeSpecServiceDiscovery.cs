using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscovery")]
    public class AppmeshVirtualNodeSpecServiceDiscovery : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
        {
            get;
            set;
        }

        /// <summary>dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
        {
            get;
            set;
        }
    }
}
