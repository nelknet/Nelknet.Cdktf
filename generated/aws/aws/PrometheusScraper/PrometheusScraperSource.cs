using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperSource")]
    public class PrometheusScraperSource : aws.PrometheusScraper.IPrometheusScraperSource
    {
        private object? _eks;

        /// <summary>eks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#eks PrometheusScraper#eks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraper.PrometheusScraperSourceEks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Eks
        {
            get => _eks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraper.IPrometheusScraperSourceEks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PrometheusScraper.IPrometheusScraperSourceEks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eks = value;
            }
        }
    }
}
