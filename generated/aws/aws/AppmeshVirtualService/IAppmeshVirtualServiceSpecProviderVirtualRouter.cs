using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualRouter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualRouterName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualRouter")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualRouter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_router_name AppmeshVirtualService#virtual_router_name}.</summary>
            [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualRouterName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
