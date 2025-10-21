using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpec")]
    public interface IAppmeshVirtualRouterSpec
    {
        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Listener
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpec")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#listener AppmeshVirtualRouter#listener}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Listener
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
