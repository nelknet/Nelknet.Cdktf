using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecLogging), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLogging")]
    public interface IAppmeshVirtualGatewaySpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#access_log AppmeshVirtualGateway#access_log}
        /// </remarks>
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecLogging), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLogging")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#access_log AppmeshVirtualGateway#access_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLog
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLog?>();
            }
        }
    }
}
