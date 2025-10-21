using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3InputFormatConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig\"}}]")]
        public virtual void PutS3InputFormatConfig(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3InputFormatConfig")]
        public virtual void ResetS3InputFormatConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3InputFormatConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfigOutputReference S3InputFormatConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3InputFormatConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig? S3InputFormatConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig?>();
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
