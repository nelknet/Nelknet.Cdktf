using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStreamAnalyticsJob
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStreamAnalyticsJobTimeouts), fullyQualifiedName: "azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts")]
    public interface IDataAzurermStreamAnalyticsJobTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#read DataAzurermStreamAnalyticsJob#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStreamAnalyticsJobTimeouts), fullyQualifiedName: "azurerm.dataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStreamAnalyticsJob.IDataAzurermStreamAnalyticsJobTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#read DataAzurermStreamAnalyticsJob#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
