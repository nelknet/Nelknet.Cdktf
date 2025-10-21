using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualGatewaySpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFile")]
    public interface IAppmeshVirtualGatewaySpecLoggingAccessLogFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#path AppmeshVirtualGateway#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#format AppmeshVirtualGateway#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormat? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualGatewaySpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFile")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#path AppmeshVirtualGateway#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#format AppmeshVirtualGateway#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingAccessLogFileFormat\"}", isOptional: true)]
            public aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormat? Format
            {
                get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLoggingAccessLogFileFormat?>();
            }
        }
    }
}
