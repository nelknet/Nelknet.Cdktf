using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiByValue(fqn: "aws.appmeshMesh.AppmeshMeshSpec")]
    public class AppmeshMeshSpec : aws.AppmeshMesh.IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        public aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter? EgressFilter
        {
            get;
            set;
        }

        /// <summary>service_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#service_discovery AppmeshMesh#service_discovery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery\"}", isOptional: true)]
        public aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery? ServiceDiscovery
        {
            get;
            set;
        }
    }
}
