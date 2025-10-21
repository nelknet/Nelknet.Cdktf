using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EbsSnapshotImport
{
    [JsiiClass(nativeType: typeof(aws.EbsSnapshotImport.EbsSnapshotImportDiskContainerOutputReference), fullyQualifiedName: "aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EbsSnapshotImportDiskContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EbsSnapshotImportDiskContainerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EbsSnapshotImportDiskContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EbsSnapshotImportDiskContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUserBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket\"}}]")]
        public virtual void PutUserBucket(aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrl")]
        public virtual void ResetUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserBucket")]
        public virtual void ResetUserBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "userBucket", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucketOutputReference\"}")]
        public virtual aws.EbsSnapshotImport.EbsSnapshotImportDiskContainerUserBucketOutputReference UserBucket
        {
            get => GetInstanceProperty<aws.EbsSnapshotImport.EbsSnapshotImportDiskContainerUserBucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userBucketInput", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainerUserBucket\"}", isOptional: true)]
        public virtual aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket? UserBucketInput
        {
            get => GetInstanceProperty<aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainerUserBucket?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ebsSnapshotImport.EbsSnapshotImportDiskContainer\"}", isOptional: true)]
        public virtual aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainer? InternalValue
        {
            get => GetInstanceProperty<aws.EbsSnapshotImport.IEbsSnapshotImportDiskContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
