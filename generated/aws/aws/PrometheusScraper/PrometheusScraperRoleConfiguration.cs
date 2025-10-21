using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiByValue(fqn: "aws.prometheusScraper.PrometheusScraperRoleConfiguration")]
    public class PrometheusScraperRoleConfiguration : aws.PrometheusScraper.IPrometheusScraperRoleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#source_role_arn PrometheusScraper#source_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#target_role_arn PrometheusScraper#target_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetRoleArn
        {
            get;
            set;
        }
    }
}
