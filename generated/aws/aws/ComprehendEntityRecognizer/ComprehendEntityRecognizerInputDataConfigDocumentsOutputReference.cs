using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    [JsiiClass(nativeType: typeof(aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetInputFormat")]
        public virtual void ResetInputFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestS3Uri")]
        public virtual void ResetTestS3Uri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputFormatInput
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
        [JsiiProperty(name: "testS3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TestS3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputFormat
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

        [JsiiProperty(name: "testS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestS3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}", isOptional: true)]
        public virtual aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments? InternalValue
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments?>();
            set => SetInstanceProperty(value);
        }
    }
}
