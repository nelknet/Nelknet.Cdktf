using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutTcp), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcp")]
    public interface IAppmeshVirtualNodeSpecListenerTimeoutTcp
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? Idle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerTimeoutTcp), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcp")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#idle AppmeshVirtualNode#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true)]
            public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? Idle
            {
                get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle?>();
            }
        }
    }
}
