using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RamResourceShareAccepter
{
    [JsiiByValue(fqn: "aws.ramResourceShareAccepter.RamResourceShareAccepterTimeouts")]
    public class RamResourceShareAccepterTimeouts : aws.RamResourceShareAccepter.IRamResourceShareAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter#create RamResourceShareAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter#delete RamResourceShareAccepter#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
