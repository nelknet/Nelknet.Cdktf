using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public interface IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#format AppmeshVirtualNode#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormat? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#format AppmeshVirtualNode#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileFormat\"}", isOptional: true)]
            public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormat? Format
            {
                get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormat?>();
            }
        }
    }
}
