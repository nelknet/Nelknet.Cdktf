using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiByValue(fqn: "aws.appmeshMesh.AppmeshMeshSpecEgressFilter")]
    public class AppmeshMeshSpecEgressFilter : aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#type AppmeshMesh#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
