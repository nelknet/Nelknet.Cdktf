using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTable.DynamodbTableImportTableOutputReference), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynamodbTableImportTableOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynamodbTableImportTableOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DynamodbTableImportTableOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableImportTableOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInputFormatOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}}]")]
        public virtual void PutInputFormatOptions(aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3BucketSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSource\"}}]")]
        public virtual void PutS3BucketSource(aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInputCompressionType")]
        public virtual void ResetInputCompressionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputFormatOptions")]
        public virtual void ResetInputFormatOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inputFormatOptions", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableImportTableInputFormatOptionsOutputReference InputFormatOptions
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableImportTableInputFormatOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "s3BucketSource", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSourceOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableImportTableS3BucketSourceOutputReference S3BucketSource
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableImportTableS3BucketSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputCompressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputCompressionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormatOptionsInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions? InputFormatOptionsInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketSourceInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableS3BucketSource\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource? S3BucketSourceInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableS3BucketSource?>();
        }

        [JsiiProperty(name: "inputCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputCompressionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTable\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTable? InternalValue
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTable?>();
            set => SetInstanceProperty(value);
        }
    }
}
