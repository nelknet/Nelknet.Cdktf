using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExportRefreshCadence")]
    public class BcmdataexportsExportExportRefreshCadence : aws.BcmdataexportsExport.IBcmdataexportsExportExportRefreshCadence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#frequency BcmdataexportsExport#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        public string Frequency
        {
            get;
            set;
        }
    }
}
