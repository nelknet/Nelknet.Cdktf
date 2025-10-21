using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinition), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinition")]
    public interface IMacie2ClassificationJobS3JobDefinition
    {
        /// <summary>bucket_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_criteria Macie2ClassificationJob#bucket_criteria}
        /// </remarks>
        [JsiiProperty(name: "bucketCriteria", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria? BucketCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>bucket_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
        /// </remarks>
        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BucketDefinitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>scoping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
        /// </remarks>
        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinition), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bucket_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_criteria Macie2ClassificationJob#bucket_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketCriteria", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria? BucketCriteria
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria?>();
            }

            /// <summary>bucket_definitions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BucketDefinitions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scoping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping?>();
            }
        }
    }
}
