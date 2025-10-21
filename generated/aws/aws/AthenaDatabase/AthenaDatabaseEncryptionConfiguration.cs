using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.athenaDatabase.AthenaDatabaseEncryptionConfiguration")]
    public class AthenaDatabaseEncryptionConfiguration : aws.AthenaDatabase.IAthenaDatabaseEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#encryption_option AthenaDatabase#encryption_option}.</summary>
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#kms_key AthenaDatabase#kms_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKey
        {
            get;
            set;
        }
    }
}
