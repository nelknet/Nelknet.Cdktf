using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperDestinationAmp), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestinationAmp")]
    public interface IPrometheusScraperDestinationAmp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#workspace_arn PrometheusScraper#workspace_arn}.</summary>
        [JsiiProperty(name: "workspaceArn", typeJson: "{\"primitive\":\"string\"}")]
        string WorkspaceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperDestinationAmp), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperDestinationAmp")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperDestinationAmp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#workspace_arn PrometheusScraper#workspace_arn}.</summary>
            [JsiiProperty(name: "workspaceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkspaceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
