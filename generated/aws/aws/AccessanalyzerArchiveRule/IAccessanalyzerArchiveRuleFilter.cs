using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerArchiveRule
{
    [JsiiInterface(nativeType: typeof(IAccessanalyzerArchiveRuleFilter), fullyQualifiedName: "aws.accessanalyzerArchiveRule.AccessanalyzerArchiveRuleFilter")]
    public interface IAccessanalyzerArchiveRuleFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#criteria AccessanalyzerArchiveRule#criteria}.</summary>
        [JsiiProperty(name: "criteria", typeJson: "{\"primitive\":\"string\"}")]
        string Criteria
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#contains AccessanalyzerArchiveRule#contains}.</summary>
        [JsiiProperty(name: "contains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Contains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#eq AccessanalyzerArchiveRule#eq}.</summary>
        [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Eq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#exists AccessanalyzerArchiveRule#exists}.</summary>
        [JsiiProperty(name: "exists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exists
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#neq AccessanalyzerArchiveRule#neq}.</summary>
        [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Neq
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessanalyzerArchiveRuleFilter), fullyQualifiedName: "aws.accessanalyzerArchiveRule.AccessanalyzerArchiveRuleFilter")]
        internal sealed class _Proxy : DeputyBase, aws.AccessanalyzerArchiveRule.IAccessanalyzerArchiveRuleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#criteria AccessanalyzerArchiveRule#criteria}.</summary>
            [JsiiProperty(name: "criteria", typeJson: "{\"primitive\":\"string\"}")]
            public string Criteria
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#contains AccessanalyzerArchiveRule#contains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Contains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#eq AccessanalyzerArchiveRule#eq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Eq
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#exists AccessanalyzerArchiveRule#exists}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exists", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exists
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#neq AccessanalyzerArchiveRule#neq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Neq
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
