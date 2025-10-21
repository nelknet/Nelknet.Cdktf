using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLogging")]
    public class AppmeshVirtualNodeSpecLogging : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLogging
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#access_log AppmeshVirtualNode#access_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        public aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLog? AccessLog
        {
            get;
            set;
        }
    }
}
