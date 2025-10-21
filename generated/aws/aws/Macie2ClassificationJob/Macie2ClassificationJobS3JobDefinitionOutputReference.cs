using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiClass(nativeType: typeof(aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionOutputReference), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Macie2ClassificationJobS3JobDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Macie2ClassificationJobS3JobDefinitionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Macie2ClassificationJobS3JobDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2ClassificationJobS3JobDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBucketCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}}]")]
        public virtual void PutBucketCriteria(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBucketDefinitions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBucketDefinitions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScoping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScoping\"}}]")]
        public virtual void PutScoping(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketCriteria")]
        public virtual void ResetBucketCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketDefinitions")]
        public virtual void ResetBucketDefinitions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScoping")]
        public virtual void ResetScoping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bucketCriteria", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference\"}")]
        public virtual aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference BucketCriteria
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitionsList\"}")]
        public virtual aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitionsList BucketDefinitions
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitionsList>()!;
        }

        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingOutputReference\"}")]
        public virtual aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingOutputReference Scoping
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScopingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketCriteriaInput", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketCriteria\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria? BucketCriteriaInput
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionBucketCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketDefinitionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BucketDefinitionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopingInput", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping? ScopingInput
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinitionScoping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2ClassificationJob.Macie2ClassificationJobS3JobDefinition\"}", isOptional: true)]
        public virtual aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2ClassificationJob.IMacie2ClassificationJobS3JobDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
