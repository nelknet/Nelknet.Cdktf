using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogFile : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#path AppmeshVirtualNode#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#format AppmeshVirtualNode#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileFormat\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormat? Format
        {
            get;
            set;
        }
    }
}
