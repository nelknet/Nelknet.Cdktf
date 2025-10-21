using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSource.QuicksightDataSourceParametersS3OutputReference), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSourceParametersS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSourceParametersS3OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSourceParametersS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManifestFileLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocation\"}}]")]
        public virtual void PutManifestFileLocation(aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference ManifestFileLocation
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "manifestFileLocationInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3ManifestFileLocation\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation? ManifestFileLocationInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersS3ManifestFileLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceParametersS3? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceParametersS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
