using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraper
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperRoleConfiguration), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperRoleConfiguration")]
    public interface IPrometheusScraperRoleConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#source_role_arn PrometheusScraper#source_role_arn}.</summary>
        [JsiiProperty(name: "sourceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#target_role_arn PrometheusScraper#target_role_arn}.</summary>
        [JsiiProperty(name: "targetRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperRoleConfiguration), fullyQualifiedName: "aws.prometheusScraper.PrometheusScraperRoleConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraper.IPrometheusScraperRoleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#source_role_arn PrometheusScraper#source_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_scraper#target_role_arn PrometheusScraper#target_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
