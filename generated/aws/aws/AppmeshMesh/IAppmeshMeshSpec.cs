using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshMesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpec")]
    public interface IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
        /// </remarks>
        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter? EgressFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_discovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#service_discovery AppmeshMesh#service_discovery}
        /// </remarks>
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery? ServiceDiscovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.appmeshMesh.AppmeshMeshSpec")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshMesh.IAppmeshMeshSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>egress_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#egress_filter AppmeshMesh#egress_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
            public aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter? EgressFilter
            {
                get => GetInstanceProperty<aws.AppmeshMesh.IAppmeshMeshSpecEgressFilter?>();
            }

            /// <summary>service_discovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#service_discovery AppmeshMesh#service_discovery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmeshMesh.AppmeshMeshSpecServiceDiscovery\"}", isOptional: true)]
            public aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery? ServiceDiscovery
            {
                get => GetInstanceProperty<aws.AppmeshMesh.IAppmeshMeshSpecServiceDiscovery?>();
            }
        }
    }
}
