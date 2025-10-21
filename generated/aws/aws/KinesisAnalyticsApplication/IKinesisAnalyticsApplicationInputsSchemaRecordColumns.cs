using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordColumns), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsSchemaRecordColumns")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#sql_type KinesisAnalyticsApplication#sql_type}.</summary>
        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
        string SqlType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#mapping KinesisAnalyticsApplication#mapping}.</summary>
        [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordColumns), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsSchemaRecordColumns")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsSchemaRecordColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#sql_type KinesisAnalyticsApplication#sql_type}.</summary>
            [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#mapping KinesisAnalyticsApplication#mapping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mapping
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
