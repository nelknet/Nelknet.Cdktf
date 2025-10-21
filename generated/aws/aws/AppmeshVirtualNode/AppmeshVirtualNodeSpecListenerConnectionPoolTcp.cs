using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolTcp")]
    public class AppmeshVirtualNodeSpecListenerConnectionPoolTcp : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxConnections
        {
            get;
            set;
        }
    }
}
