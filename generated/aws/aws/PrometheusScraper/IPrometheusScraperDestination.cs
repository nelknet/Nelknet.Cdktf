using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperDestination), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestination")]
    public interface IPrometheusScraperDestination
    {
        /// <summary>amp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#amp PrometheusScraper#amp}
        /// </remarks>
        [JsiiProperty(name: "amp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperDestinationAmp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Amp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperDestination), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestination")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#amp PrometheusScraper#amp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperDestinationAmp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Amp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
