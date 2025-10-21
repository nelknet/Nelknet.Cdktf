using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration")]
    public interface IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#lambda_arn KendraDataSource#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_bucket KendraDataSource#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        string S3Bucket
        {
            get;
        }

        /// <summary>invocation_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#invocation_condition KendraDataSource#invocation_condition}
        /// </remarks>
        [JsiiProperty(name: "invocationCondition", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition? InvocationCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#lambda_arn KendraDataSource#lambda_arn}.</summary>
            [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_bucket KendraDataSource#s3_bucket}.</summary>
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>invocation_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#invocation_condition KendraDataSource#invocation_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invocationCondition", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition? InvocationCondition
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationInvocationCondition?>();
            }
        }
    }
}
