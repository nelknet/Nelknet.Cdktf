using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
        /// </remarks>
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv
        {
            get
            {
                return null;
            }
        }

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
        /// </remarks>
        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>csv block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv?>();
            }

            /// <summary>json block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson?>();
            }
        }
    }
}
