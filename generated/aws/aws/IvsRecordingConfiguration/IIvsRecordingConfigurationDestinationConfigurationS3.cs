using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvsRecordingConfigurationDestinationConfigurationS3), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3")]
    public interface IIvsRecordingConfigurationDestinationConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#bucket_name IvsRecordingConfiguration#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIvsRecordingConfigurationDestinationConfigurationS3), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3")]
        internal sealed class _Proxy : DeputyBase, aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#bucket_name IvsRecordingConfiguration#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
