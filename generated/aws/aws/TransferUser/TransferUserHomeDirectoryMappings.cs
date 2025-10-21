using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferUser.TransferUserHomeDirectoryMappings")]
    public class TransferUserHomeDirectoryMappings : aws.TransferUser.ITransferUserHomeDirectoryMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#entry TransferUser#entry}.</summary>
        [JsiiProperty(name: "entry", typeJson: "{\"primitive\":\"string\"}")]
        public string Entry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#target TransferUser#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public string Target
        {
            get;
            set;
        }
    }
}
