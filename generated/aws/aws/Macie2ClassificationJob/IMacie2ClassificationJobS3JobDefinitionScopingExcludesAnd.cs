using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd")]
    public interface IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd
    {
        /// <summary>simple_scope_term block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#simple_scope_term Macie2ClassificationJob#simple_scope_term}
        /// </remarks>
        [JsiiProperty(name: "simpleScopeTerm", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm? SimpleScopeTerm
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_scope_term block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_scope_term Macie2ClassificationJob#tag_scope_term}
        /// </remarks>
        [JsiiProperty(name: "tagScopeTerm", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm? TagScopeTerm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>simple_scope_term block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#simple_scope_term Macie2ClassificationJob#simple_scope_term}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "simpleScopeTerm", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm? SimpleScopeTerm
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm?>();
            }

            /// <summary>tag_scope_term block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tag_scope_term Macie2ClassificationJob#tag_scope_term}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagScopeTerm", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm\"}", isOptional: true)]
            public aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm? TagScopeTerm
            {
                get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm?>();
            }
        }
    }
}
