using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexDocumentMetadataConfigurationUpdatesRelevance), fullyQualifiedName: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance")]
    public interface IKendraIndexDocumentMetadataConfigurationUpdatesRelevance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#duration KendraIndex#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#freshness KendraIndex#freshness}.</summary>
        [JsiiProperty(name: "freshness", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Freshness
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#importance KendraIndex#importance}.</summary>
        [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Importance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#rank_order KendraIndex#rank_order}.</summary>
        [JsiiProperty(name: "rankOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RankOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#values_importance_map KendraIndex#values_importance_map}.</summary>
        [JsiiProperty(name: "valuesImportanceMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, double>? ValuesImportanceMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexDocumentMetadataConfigurationUpdatesRelevance), fullyQualifiedName: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#duration KendraIndex#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#freshness KendraIndex#freshness}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freshness", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Freshness
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#importance KendraIndex#importance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Importance
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#rank_order KendraIndex#rank_order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rankOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RankOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#values_importance_map KendraIndex#values_importance_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "valuesImportanceMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, double>? ValuesImportanceMap
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
            }
        }
    }
}
