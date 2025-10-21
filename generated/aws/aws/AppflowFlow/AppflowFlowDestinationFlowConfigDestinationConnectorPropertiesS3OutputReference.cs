using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3OutputFormatConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig\"}}]")]
        public virtual void PutS3OutputFormatConfig(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketPrefix")]
        public virtual void ResetBucketPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3OutputFormatConfig")]
        public virtual void ResetS3OutputFormatConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3OutputFormatConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigOutputReference S3OutputFormatConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigOutputReference>()!;
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
        [JsiiProperty(name: "s3OutputFormatConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig? S3OutputFormatConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfig?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
