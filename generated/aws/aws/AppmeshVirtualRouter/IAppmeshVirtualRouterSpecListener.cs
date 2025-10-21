using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualRouter
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener")]
    public interface IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
        /// </remarks>
        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
        aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#port_mapping AppmeshVirtualRouter#port_mapping}
            /// </remarks>
            [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualRouter.AppmeshVirtualRouterSpecListenerPortMapping\"}")]
            public aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping PortMapping
            {
                get => GetInstanceProperty<aws.AppmeshVirtualRouter.IAppmeshVirtualRouterSpecListenerPortMapping>()!;
            }
        }
    }
}
