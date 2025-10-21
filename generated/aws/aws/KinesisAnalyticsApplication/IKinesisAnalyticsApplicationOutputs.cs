using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputs")]
    public interface IKinesisAnalyticsApplicationOutputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsSchema\"}")]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsSchema Schema
        {
            get;
        }

        /// <summary>kinesis_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
        /// </remarks>
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsKinesisFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisFirehose? KinesisFirehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
        /// </remarks>
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsKinesisStream\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisStream? KinesisStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsLambda\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsLambda? Lambda
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputs")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputs
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

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
            /// </remarks>
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsSchema\"}")]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsSchema Schema
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsSchema>()!;
            }

            /// <summary>kinesis_firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsKinesisFirehose\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisFirehose? KinesisFirehose
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisFirehose?>();
            }

            /// <summary>kinesis_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsKinesisStream\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisStream? KinesisStream
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsKinesisStream?>();
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationOutputsLambda\"}", isOptional: true)]
            public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsLambda? Lambda
            {
                get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationOutputsLambda?>();
            }
        }
    }
}
