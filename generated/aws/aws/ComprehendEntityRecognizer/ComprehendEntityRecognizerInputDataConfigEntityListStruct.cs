using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct")]
    public class ComprehendEntityRecognizerInputDataConfigEntityListStruct : aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }
    }
}
