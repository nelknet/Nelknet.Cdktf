using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests")]
    public class ComprehendEntityRecognizerInputDataConfigAugmentedManifests : aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#attribute_names ComprehendEntityRecognizer#attribute_names}.</summary>
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AttributeNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#s3_uri ComprehendEntityRecognizer#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#annotation_data_s3_uri ComprehendEntityRecognizer#annotation_data_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "annotationDataS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnnotationDataS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#document_type ComprehendEntityRecognizer#document_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#source_documents_s3_uri ComprehendEntityRecognizer#source_documents_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDocumentsS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDocumentsS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#split ComprehendEntityRecognizer#split}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "split", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Split
        {
            get;
            set;
        }
    }
}
