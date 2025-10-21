using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QldbStream
{
    [JsiiInterface(nativeType: typeof(IQldbStreamKinesisConfiguration), fullyQualifiedName: "aws.qldbStream.QldbStreamKinesisConfiguration")]
    public interface IQldbStreamKinesisConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#stream_arn QldbStream#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        string StreamArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#aggregation_enabled QldbStream#aggregation_enabled}.</summary>
        [JsiiProperty(name: "aggregationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AggregationEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQldbStreamKinesisConfiguration), fullyQualifiedName: "aws.qldbStream.QldbStreamKinesisConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.QldbStream.IQldbStreamKinesisConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#stream_arn QldbStream#stream_arn}.</summary>
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#aggregation_enabled QldbStream#aggregation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aggregationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AggregationEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
