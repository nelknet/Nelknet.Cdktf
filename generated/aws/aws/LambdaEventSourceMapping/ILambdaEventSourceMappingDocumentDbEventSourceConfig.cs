using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingDocumentDbEventSourceConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingDocumentDbEventSourceConfig")]
    public interface ILambdaEventSourceMappingDocumentDbEventSourceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#database_name LambdaEventSourceMapping#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#collection_name LambdaEventSourceMapping#collection_name}.</summary>
        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#full_document LambdaEventSourceMapping#full_document}.</summary>
        [JsiiProperty(name: "fullDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FullDocument
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingDocumentDbEventSourceConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingDocumentDbEventSourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingDocumentDbEventSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#database_name LambdaEventSourceMapping#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#collection_name LambdaEventSourceMapping#collection_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#full_document LambdaEventSourceMapping#full_document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fullDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FullDocument
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
