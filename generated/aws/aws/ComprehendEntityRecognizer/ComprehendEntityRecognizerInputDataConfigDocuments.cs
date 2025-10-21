using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments")]
    public class ComprehendEntityRecognizerInputDataConfigDocuments : aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#input_format ComprehendEntityRecognizer#input_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#test_s3_uri ComprehendEntityRecognizer#test_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestS3Uri
        {
            get;
            set;
        }
    }
}
