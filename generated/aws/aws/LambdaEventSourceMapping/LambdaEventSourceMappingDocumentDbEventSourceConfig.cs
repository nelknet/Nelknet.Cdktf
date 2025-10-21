using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingDocumentDbEventSourceConfig")]
    public class LambdaEventSourceMappingDocumentDbEventSourceConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDocumentDbEventSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#database_name LambdaEventSourceMapping#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#collection_name LambdaEventSourceMapping#collection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#full_document LambdaEventSourceMapping#full_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fullDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FullDocument
        {
            get;
            set;
        }
    }
}
