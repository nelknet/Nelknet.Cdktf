using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiByValue(fqn: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinition")]
    public class Macie2ClassificationJobS3JobDefinition : aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinition
    {
        /// <summary>bucket_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_criteria Macie2ClassificationJob#bucket_criteria}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketCriteria", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria? BucketCriteria
        {
            get;
            set;
        }

        private object? _bucketDefinitions;

        /// <summary>bucket_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BucketDefinitions
        {
            get => _bucketDefinitions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bucketDefinitions = value;
            }
        }

        /// <summary>scoping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
        {
            get;
            set;
        }
    }
}
