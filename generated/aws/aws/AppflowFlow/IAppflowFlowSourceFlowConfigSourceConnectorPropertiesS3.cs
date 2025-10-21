using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3")]
    public interface IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#bucket_name AppflowFlow#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#bucket_prefix AppflowFlow#bucket_prefix}.</summary>
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string BucketPrefix
        {
            get;
        }

        /// <summary>s3_input_format_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#s3_input_format_config AppflowFlow#s3_input_format_config}
        /// </remarks>
        [JsiiProperty(name: "s3InputFormatConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#bucket_name AppflowFlow#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#bucket_prefix AppflowFlow#bucket_prefix}.</summary>
            [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_input_format_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#s3_input_format_config AppflowFlow#s3_input_format_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3InputFormatConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig\"}", isOptional: true)]
            public aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfig
            {
                get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig?>();
            }
        }
    }
}
