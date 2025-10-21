using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendDocumentClassifier
{
    [JsiiByValue(fqn: "aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfig")]
    public class ComprehendDocumentClassifierInputDataConfig : aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfig
    {
        private object? _augmentedManifests;

        /// <summary>augmented_manifests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#augmented_manifests ComprehendDocumentClassifier#augmented_manifests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "augmentedManifests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AugmentedManifests
        {
            get => _augmentedManifests;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfigAugmentedManifests[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfigAugmentedManifests).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _augmentedManifests = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#data_format ComprehendDocumentClassifier#data_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#label_delimiter ComprehendDocumentClassifier#label_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labelDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#s3_uri ComprehendDocumentClassifier#s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#test_s3_uri ComprehendDocumentClassifier#test_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestS3Uri
        {
            get;
            set;
        }
    }
}
