using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiByValue(fqn: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAnd")]
    public class Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAnd : aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAnd
    {
        /// <summary>simple_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#simple_criterion Macie2ClassificationJob#simple_criterion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "simpleCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndSimpleCriterion? SimpleCriterion
        {
            get;
            set;
        }

        /// <summary>tag_criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_criterion Macie2ClassificationJob#tag_criterion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagCriterion", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesAndTagCriterion? TagCriterion
        {
            get;
            set;
        }
    }
}
