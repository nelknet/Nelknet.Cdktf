using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpecEgressFilter), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpecEgressFilter")]
    public interface IAppmeshMeshSpecEgressFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#type AppmeshMesh#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpecEgressFilter), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpecEgressFilter")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#type AppmeshMesh#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
