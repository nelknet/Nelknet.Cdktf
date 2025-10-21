using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperDestinationAmp")]
    public class PrometheusScraperDestinationAmp : aws.PrometheusScraper.IPrometheusScraperDestinationAmp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#workspace_arn PrometheusScraper#workspace_arn}.</summary>
        [JsiiProperty(name: "workspaceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkspaceArn
        {
            get;
            set;
        }
    }
}
