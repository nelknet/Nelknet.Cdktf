using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNodeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpecProviderVirtualNode")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProviderVirtualNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#virtual_node_name AppmeshVirtualService#virtual_node_name}.</summary>
            [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNodeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
