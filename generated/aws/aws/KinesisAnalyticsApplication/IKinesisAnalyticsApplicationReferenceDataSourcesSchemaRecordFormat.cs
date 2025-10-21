using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
        /// </remarks>
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mapping_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters?>();
            }
        }
    }
}
