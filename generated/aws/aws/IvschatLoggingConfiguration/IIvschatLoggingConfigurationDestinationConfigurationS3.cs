using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationS3), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3")]
    public interface IIvschatLoggingConfigurationDestinationConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#bucket_name IvschatLoggingConfiguration#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIvschatLoggingConfigurationDestinationConfigurationS3), fullyQualifiedName: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3")]
        internal sealed class _Proxy : DeputyBase, aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#bucket_name IvschatLoggingConfiguration#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
