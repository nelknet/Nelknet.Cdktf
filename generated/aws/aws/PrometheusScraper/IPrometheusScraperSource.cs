using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperSource), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperSource")]
    public interface IPrometheusScraperSource
    {
        /// <summary>eks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#eks PrometheusScraper#eks}
        /// </remarks>
        [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperSourceEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Eks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperSource), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperSource")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>eks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#eks PrometheusScraper#eks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperSourceEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Eks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
