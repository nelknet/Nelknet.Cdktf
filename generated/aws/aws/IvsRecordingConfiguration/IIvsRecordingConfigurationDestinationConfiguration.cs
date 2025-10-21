using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvsRecordingConfigurationDestinationConfiguration), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration")]
    public interface IIvsRecordingConfigurationDestinationConfiguration
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#s3 IvsRecordingConfiguration#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3\"}")]
        aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3 S3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIvsRecordingConfigurationDestinationConfiguration), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#s3 IvsRecordingConfiguration#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3\"}")]
            public aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3 S3
            {
                get => GetInstanceProperty<aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3>()!;
            }
        }
    }
}
