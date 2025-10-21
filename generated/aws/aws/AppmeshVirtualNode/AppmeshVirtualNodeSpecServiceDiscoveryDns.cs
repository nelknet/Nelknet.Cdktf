using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryDns : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#ip_preference AppmeshVirtualNode#ip_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#response_type AppmeshVirtualNode#response_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseType
        {
            get;
            set;
        }
    }
}
