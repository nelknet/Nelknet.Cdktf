using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsEncryptionByDefault
{
    [JsiiByValue(fqn: "aws.dataAwsEbsEncryptionByDefault.DataAwsEbsEncryptionByDefaultTimeouts")]
    public class DataAwsEbsEncryptionByDefaultTimeouts : aws.DataAwsEbsEncryptionByDefault.IDataAwsEbsEncryptionByDefaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_encryption_by_default#read DataAwsEbsEncryptionByDefault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
