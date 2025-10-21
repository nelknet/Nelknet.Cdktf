using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    [JsiiInterface(nativeType: typeof(IComprehendEntityRecognizerInputDataConfigAnnotations), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations")]
    public interface IComprehendEntityRecognizerInputDataConfigAnnotations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#test_s3_uri ComprehendEntityRecognizer#test_s3_uri}.</summary>
        [JsiiProperty(name: "testS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TestS3Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComprehendEntityRecognizerInputDataConfigAnnotations), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations")]
        internal sealed class _Proxy : DeputyBase, aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#test_s3_uri ComprehendEntityRecognizer#test_s3_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "testS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TestS3Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
