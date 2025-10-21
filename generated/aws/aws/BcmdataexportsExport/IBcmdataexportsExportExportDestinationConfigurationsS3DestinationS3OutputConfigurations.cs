using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    [JsiiInterface(nativeType: typeof(IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations")]
    public interface IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#compression BcmdataexportsExport#compression}.</summary>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        string Compression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#format BcmdataexportsExport#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#output_type BcmdataexportsExport#output_type}.</summary>
        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}")]
        string OutputType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#overwrite BcmdataexportsExport#overwrite}.</summary>
        [JsiiProperty(name: "overwrite", typeJson: "{\"primitive\":\"string\"}")]
        string Overwrite
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations), fullyQualifiedName: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#compression BcmdataexportsExport#compression}.</summary>
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
            public string Compression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#format BcmdataexportsExport#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#output_type BcmdataexportsExport#output_type}.</summary>
            [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}")]
            public string OutputType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#overwrite BcmdataexportsExport#overwrite}.</summary>
            [JsiiProperty(name: "overwrite", typeJson: "{\"primitive\":\"string\"}")]
            public string Overwrite
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
