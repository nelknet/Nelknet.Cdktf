using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendDocumentClassifier
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfigAugmentedManifests")]
    public class ComprehendDocumentClassifierInputDataConfigAugmentedManifests : aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfigAugmentedManifests
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#attribute_names ComprehendDocumentClassifier#attribute_names}.</summary>
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AttributeNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#s3_uri ComprehendDocumentClassifier#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#annotation_data_s3_uri ComprehendDocumentClassifier#annotation_data_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "annotationDataS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnnotationDataS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#document_type ComprehendDocumentClassifier#document_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#source_documents_s3_uri ComprehendDocumentClassifier#source_documents_s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDocumentsS3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDocumentsS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#split ComprehendDocumentClassifier#split}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "split", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Split
        {
            get;
            set;
        }
    }
}
