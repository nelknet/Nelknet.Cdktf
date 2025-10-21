using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations")]
    public class BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations : aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#compression BcmdataexportsExport#compression}.</summary>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public string Compression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#format BcmdataexportsExport#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#output_type BcmdataexportsExport#output_type}.</summary>
        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#overwrite BcmdataexportsExport#overwrite}.</summary>
        [JsiiProperty(name: "overwrite", typeJson: "{\"primitive\":\"string\"}")]
        public string Overwrite
        {
            get;
            set;
        }
    }
}
