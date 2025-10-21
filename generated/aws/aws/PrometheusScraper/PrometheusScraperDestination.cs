using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperDestination")]
    public class PrometheusScraperDestination : aws.PrometheusScraper.IPrometheusScraperDestination
    {
        private object? _amp;

        /// <summary>amp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#amp PrometheusScraper#amp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperDestinationAmp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Amp
        {
            get => _amp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraper.IPrometheusScraperDestinationAmp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PrometheusScraper.IPrometheusScraperDestinationAmp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _amp = value;
            }
        }
    }
}
