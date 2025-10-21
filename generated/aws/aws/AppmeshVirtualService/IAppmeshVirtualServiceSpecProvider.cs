using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider")]
    public interface IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
        /// </remarks>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_router block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
        /// </remarks>
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node AppmeshVirtualService#virtual_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
            public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNode
            {
                get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode?>();
            }

            /// <summary>virtual_router block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router AppmeshVirtualService#virtual_router}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
            public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouter
            {
                get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter?>();
            }
        }
    }
}
