using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiClass(nativeType: typeof(aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3OutputReference), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxDataRepositoryAssociationS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxDataRepositoryAssociationS3OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxDataRepositoryAssociationS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxDataRepositoryAssociationS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoExportPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy\"}}]")]
        public virtual void PutAutoExportPolicy(aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoImportPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy\"}}]")]
        public virtual void PutAutoImportPolicy(aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoExportPolicy")]
        public virtual void ResetAutoExportPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoImportPolicy")]
        public virtual void ResetAutoImportPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoExportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicyOutputReference\"}")]
        public virtual aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicyOutputReference AutoExportPolicy
        {
            get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "autoImportPolicy", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicyOutputReference\"}")]
        public virtual aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicyOutputReference AutoImportPolicy
        {
            get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoExportPolicyInput", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy\"}", isOptional: true)]
        public virtual aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy? AutoExportPolicyInput
        {
            get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoImportPolicyInput", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy\"}", isOptional: true)]
        public virtual aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy? AutoImportPolicyInput
        {
            get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3\"}", isOptional: true)]
        public virtual aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3? InternalValue
        {
            get => GetInstanceProperty<aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
