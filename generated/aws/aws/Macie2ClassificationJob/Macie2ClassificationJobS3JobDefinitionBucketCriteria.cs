using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiByValue(fqn: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria")]
    public class Macie2ClassificationJobS3JobDefinitionBucketCriteria : aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria
    {
        /// <summary>excludes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#excludes Macie2ClassificationJob#excludes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludes", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes? Excludes
        {
            get;
            set;
        }

        /// <summary>includes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#includes Macie2ClassificationJob#includes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includes", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes? Includes
        {
            get;
            set;
        }
    }
}
