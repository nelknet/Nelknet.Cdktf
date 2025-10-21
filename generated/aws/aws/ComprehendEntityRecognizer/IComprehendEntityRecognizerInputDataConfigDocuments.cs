using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    [JsiiInterface(nativeType: typeof(IComprehendEntityRecognizerInputDataConfigDocuments), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments")]
    public interface IComprehendEntityRecognizerInputDataConfigDocuments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#input_format ComprehendEntityRecognizer#input_format}.</summary>
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputFormat
        {
            get
            {
                return null;
            }
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

        [JsiiTypeProxy(nativeType: typeof(IComprehendEntityRecognizerInputDataConfigDocuments), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments")]
        internal sealed class _Proxy : DeputyBase, aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#input_format ComprehendEntityRecognizer#input_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputFormat
            {
                get => GetInstanceProperty<string?>();
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
