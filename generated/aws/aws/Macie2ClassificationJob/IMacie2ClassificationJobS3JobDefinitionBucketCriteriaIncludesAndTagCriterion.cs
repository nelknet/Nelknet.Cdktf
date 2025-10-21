using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion")]
    public interface IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#comparator Macie2ClassificationJob#comparator}.</summary>
        [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comparator
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_values Macie2ClassificationJob#tag_values}
        /// </remarks>
        [JsiiProperty(name: "tagValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#comparator Macie2ClassificationJob#comparator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comparator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tag_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_values Macie2ClassificationJob#tag_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterionTagValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TagValues
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
