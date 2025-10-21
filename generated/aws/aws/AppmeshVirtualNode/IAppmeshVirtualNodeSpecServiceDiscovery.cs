using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscovery")]
    public interface IAppmeshVirtualNodeSpecServiceDiscovery
    {
        /// <summary>aws_cloud_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
        /// </remarks>
        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
        /// </remarks>
        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscovery), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscovery")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_cloud_map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#aws_cloud_map AppmeshVirtualNode#aws_cloud_map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
            public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMap
            {
                get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap?>();
            }

            /// <summary>dns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#dns AppmeshVirtualNode#dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
            public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns? Dns
            {
                get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns?>();
            }
        }
    }
}
