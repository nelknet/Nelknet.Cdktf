using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DxHostedPublicVirtualInterface
{
    [JsiiByValue(fqn: "aws.dxHostedPublicVirtualInterface.DxHostedPublicVirtualInterfaceTimeouts")]
    public class DxHostedPublicVirtualInterfaceTimeouts : aws.DxHostedPublicVirtualInterface.IDxHostedPublicVirtualInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#create DxHostedPublicVirtualInterface#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_public_virtual_interface#delete DxHostedPublicVirtualInterface#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
