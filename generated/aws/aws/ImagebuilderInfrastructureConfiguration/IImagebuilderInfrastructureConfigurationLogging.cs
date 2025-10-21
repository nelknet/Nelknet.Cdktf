using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderInfrastructureConfiguration
{
    [JsiiInterface(nativeType: typeof(IImagebuilderInfrastructureConfigurationLogging), fullyQualifiedName: "aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLogging")]
    public interface IImagebuilderInfrastructureConfigurationLogging
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#s3_logs ImagebuilderInfrastructureConfiguration#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}")]
        aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs S3Logs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderInfrastructureConfigurationLogging), fullyQualifiedName: "aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLogging")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_infrastructure_configuration#s3_logs ImagebuilderInfrastructureConfiguration#s3_logs}
            /// </remarks>
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}")]
            public aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs S3Logs
            {
                get => GetInstanceProperty<aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs>()!;
            }
        }
    }
}
