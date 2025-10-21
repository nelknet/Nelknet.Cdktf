using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceGlobalSettings
{
    [JsiiInterface(nativeType: typeof(IChimesdkvoiceGlobalSettingsVoiceConnector), fullyQualifiedName: "aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector")]
    public interface IChimesdkvoiceGlobalSettingsVoiceConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#cdr_bucket ChimesdkvoiceGlobalSettings#cdr_bucket}.</summary>
        [JsiiProperty(name: "cdrBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CdrBucket
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChimesdkvoiceGlobalSettingsVoiceConnector), fullyQualifiedName: "aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector")]
        internal sealed class _Proxy : DeputyBase, aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#cdr_bucket ChimesdkvoiceGlobalSettings#cdr_bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cdrBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CdrBucket
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
