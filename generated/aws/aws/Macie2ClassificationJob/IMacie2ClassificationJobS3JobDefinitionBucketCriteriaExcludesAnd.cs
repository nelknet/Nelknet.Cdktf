using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd")]
    public interface IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd
    {
        /// <summary>simple_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#simple_criterion Macie2ClassificationJob#simple_criterion}
        /// </remarks>
        [JsiiProperty(name: "simpleCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion? SimpleCriterion
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_criterion Macie2ClassificationJob#tag_criterion}
        /// </remarks>
        [JsiiProperty(name: "tagCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndTagCriterion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndTagCriterion? TagCriterion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>simple_criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#simple_criterion Macie2ClassificationJob#simple_criterion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "simpleCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion? SimpleCriterion
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndSimpleCriterion?>();
            }

            /// <summary>tag_criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_criterion Macie2ClassificationJob#tag_criterion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndTagCriterion\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndTagCriterion? TagCriterion
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesAndTagCriterion?>();
            }
        }
    }
}
