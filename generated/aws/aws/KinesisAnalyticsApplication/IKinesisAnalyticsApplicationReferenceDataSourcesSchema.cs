using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchema
    {
        /// <summary>record_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
        /// </remarks>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
        object RecordColumns
        {
            get;
        }

        /// <summary>record_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
        /// </remarks>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}")]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordEncoding
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>record_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
            /// </remarks>
            [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
            public object RecordColumns
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>record_format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
            /// </remarks>
            [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}")]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordEncoding
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
