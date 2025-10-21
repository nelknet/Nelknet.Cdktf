using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    [JsiiInterface(nativeType: typeof(IBcmdataexportsExportExportDestinationConfigurationsS3Destination), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3Destination")]
    public interface IBcmdataexportsExportExportDestinationConfigurationsS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_bucket BcmdataexportsExport#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        string S3Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_prefix BcmdataexportsExport#s3_prefix}.</summary>
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        string S3Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_region BcmdataexportsExport#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        string S3Region
        {
            get;
        }

        /// <summary>s3_output_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_output_configurations BcmdataexportsExport#s3_output_configurations}
        /// </remarks>
        [JsiiProperty(name: "s3OutputConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3OutputConfigurations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBcmdataexportsExportExportDestinationConfigurationsS3Destination), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3Destination")]
        internal sealed class _Proxy : DeputyBase, aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3Destination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_bucket BcmdataexportsExport#s3_bucket}.</summary>
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_prefix BcmdataexportsExport#s3_prefix}.</summary>
            [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_region BcmdataexportsExport#s3_region}.</summary>
            [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_output_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_output_configurations BcmdataexportsExport#s3_output_configurations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3OutputConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3OutputConfigurations
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
