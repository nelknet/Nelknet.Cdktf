using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaults), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaults")]
    public interface IAppmeshVirtualGatewaySpecBackendDefaults
    {
        /// <summary>client_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#client_policy AppmeshVirtualGateway#client_policy}
        /// </remarks>
        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecBackendDefaults), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaults")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#client_policy AppmeshVirtualGateway#client_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicy
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy?>();
            }
        }
    }
}
