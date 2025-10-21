using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference), fullyQualifiedName: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatasetFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat\"}}]")]
        public virtual void PutDatasetFormat(aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLocalPath")]
        public virtual void ResetLocalPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3DataDistributionType")]
        public virtual void ResetS3DataDistributionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3InputMode")]
        public virtual void ResetS3InputMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "datasetFormat", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormatOutputReference\"}")]
        public virtual aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormatOutputReference DatasetFormat
        {
            get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCapturedDestinationS3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataCapturedDestinationS3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetFormatInput", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat\"}", isOptional: true)]
        public virtual aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat? DatasetFormatInput
        {
            get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInputDatasetFormat?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DataDistributionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3DataDistributionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3InputModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3InputModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataCapturedDestinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCapturedDestinationS3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3DataDistributionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3InputMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3InputMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInput\"}", isOptional: true)]
        public virtual aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInput? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobInputBatchTransformInput?>();
            set => SetInstanceProperty(value);
        }
    }
}
