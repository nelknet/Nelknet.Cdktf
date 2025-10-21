using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TranscribeLanguageModel
{
    [JsiiClass(nativeType: typeof(aws.TranscribeLanguageModel.TranscribeLanguageModelInputDataConfigOutputReference), fullyQualifiedName: "aws.transcribeLanguageModel.TranscribeLanguageModelInputDataConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TranscribeLanguageModelInputDataConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TranscribeLanguageModelInputDataConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TranscribeLanguageModelInputDataConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TranscribeLanguageModelInputDataConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTuningDataS3Uri")]
        public virtual void ResetTuningDataS3Uri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataAccessRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tuningDataS3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TuningDataS3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tuningDataS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TuningDataS3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.transcribeLanguageModel.TranscribeLanguageModelInputDataConfig\"}", isOptional: true)]
        public virtual aws.TranscribeLanguageModel.ITranscribeLanguageModelInputDataConfig? InternalValue
        {
            get => GetInstanceProperty<aws.TranscribeLanguageModel.ITranscribeLanguageModelInputDataConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
