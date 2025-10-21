using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerArchiveRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.accessanalyzerArchiveRule.AccessanalyzerArchiveRuleFilter")]
    public class AccessanalyzerArchiveRuleFilter : aws.AccessanalyzerArchiveRule.IAccessanalyzerArchiveRuleFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#criteria AccessanalyzerArchiveRule#criteria}.</summary>
        [JsiiProperty(name: "criteria", typeJson: "{\"primitive\":\"string\"}")]
        public string Criteria
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#contains AccessanalyzerArchiveRule#contains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Contains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#eq AccessanalyzerArchiveRule#eq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Eq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#exists AccessanalyzerArchiveRule#exists}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exists
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#neq AccessanalyzerArchiveRule#neq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Neq
        {
            get;
            set;
        }
    }
}
