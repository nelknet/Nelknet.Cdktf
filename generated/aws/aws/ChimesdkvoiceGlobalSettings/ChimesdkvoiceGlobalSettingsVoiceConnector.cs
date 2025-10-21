using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceGlobalSettings
{
    [JsiiByValue(fqn: "aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector")]
    public class ChimesdkvoiceGlobalSettingsVoiceConnector : aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#cdr_bucket ChimesdkvoiceGlobalSettings#cdr_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cdrBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CdrBucket
        {
            get;
            set;
        }
    }
}
