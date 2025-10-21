using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiClass(nativeType: typeof(aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExcludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes\"}}]")]
        public virtual void PutExcludes(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIncludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes\"}}]")]
        public virtual void PutIncludes(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludes")]
        public virtual void ResetExcludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludes")]
        public virtual void ResetIncludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "excludes", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesOutputReference\"}")]
        public virtual aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesOutputReference Excludes
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludesOutputReference>()!;
        }

        [JsiiProperty(name: "includes", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesOutputReference\"}")]
        public virtual aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesOutputReference Includes
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludesInput", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes? ExcludesInput
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaExcludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includesInput", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes? IncludesInput
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteriaIncludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
