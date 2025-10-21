using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationFsxOpenzfsFileSystem
{
    [JsiiClass(nativeType: typeof(aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference), fullyQualifiedName: "aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationFsxOpenzfsFileSystemProtocolNfsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMountOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions\"}}]")]
        public virtual void PutMountOptions(aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions)}, new object[]{@value});
        }

        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptionsOutputReference\"}")]
        public virtual aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptionsOutputReference MountOptions
        {
            get => GetInstanceProperty<aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountOptionsInput", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions\"}", isOptional: true)]
        public virtual aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions? MountOptionsInput
        {
            get => GetInstanceProperty<aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfsMountOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocolNfs\"}", isOptional: true)]
        public virtual aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs? InternalValue
        {
            get => GetInstanceProperty<aws.DatasyncLocationFsxOpenzfsFileSystem.IDatasyncLocationFsxOpenzfsFileSystemProtocolNfs?>();
            set => SetInstanceProperty(value);
        }
    }
}
