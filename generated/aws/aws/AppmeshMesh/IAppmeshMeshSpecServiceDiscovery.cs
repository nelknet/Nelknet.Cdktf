using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpecServiceDiscovery), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery")]
    public interface IAppmeshMeshSpecServiceDiscovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#ip_preference AppmeshMesh#ip_preference}.</summary>
        [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpecServiceDiscovery), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#ip_preference AppmeshMesh#ip_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
