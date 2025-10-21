using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiInterface(nativeType: typeof(IMacie2FindingsFilterFindingCriteriaCriterion), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion")]
    public interface IMacie2FindingsFilterFindingCriteriaCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#field Macie2FindingsFilter#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#eq Macie2FindingsFilter#eq}.</summary>
        [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Eq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#eq_exact_match Macie2FindingsFilter#eq_exact_match}.</summary>
        [JsiiProperty(name: "eqExactMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EqExactMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#gt Macie2FindingsFilter#gt}.</summary>
        [JsiiProperty(name: "gt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#gte Macie2FindingsFilter#gte}.</summary>
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gte
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#lt Macie2FindingsFilter#lt}.</summary>
        [JsiiProperty(name: "lt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#lte Macie2FindingsFilter#lte}.</summary>
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lte
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#neq Macie2FindingsFilter#neq}.</summary>
        [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Neq
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2FindingsFilterFindingCriteriaCriterion), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#field Macie2FindingsFilter#field}.</summary>
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#eq Macie2FindingsFilter#eq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Eq
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#eq_exact_match Macie2FindingsFilter#eq_exact_match}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eqExactMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EqExactMatch
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#gt Macie2FindingsFilter#gt}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#gte Macie2FindingsFilter#gte}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gte
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#lt Macie2FindingsFilter#lt}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#lte Macie2FindingsFilter#lte}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lte
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#neq Macie2FindingsFilter#neq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Neq
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
