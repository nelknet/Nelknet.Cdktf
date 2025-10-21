using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions")]
    public class Macie2ClassificationJobS3JobDefinitionBucketDefinitions : aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#account_id Macie2ClassificationJob#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#buckets Macie2ClassificationJob#buckets}.</summary>
        [JsiiProperty(name: "buckets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Buckets
        {
            get;
            set;
        }
    }
}
