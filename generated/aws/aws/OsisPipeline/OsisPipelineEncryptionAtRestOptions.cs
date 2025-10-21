using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.osisPipeline.OsisPipelineEncryptionAtRestOptions")]
    public class OsisPipelineEncryptionAtRestOptions : aws.OsisPipeline.IOsisPipelineEncryptionAtRestOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#kms_key_arn OsisPipeline#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyArn
        {
            get;
            set;
        }
    }
}
