using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiByValue(fqn: "aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery")]
    public class AppmeshMeshSpecServiceDiscovery : aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#ip_preference AppmeshMesh#ip_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpPreference
        {
            get;
            set;
        }
    }
}
