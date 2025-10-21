using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualService
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpec")]
    public interface IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#provider AppmeshVirtualService#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider? Provider
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.appmeshVirtualService.AppmeshVirtualServiceSpec")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualService.IAppmeshVirtualServiceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#provider AppmeshVirtualService#provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmeshVirtualService.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
            public aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider? Provider
            {
                get => GetInstanceProperty<aws.AppmeshVirtualService.IAppmeshVirtualServiceSpecProvider?>();
            }
        }
    }
}
