using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiClass(nativeType: typeof(aws.DatasyncTask.DatasyncTaskTaskReportConfigReportOverridesOutputReference), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasyncTaskTaskReportConfigReportOverridesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasyncTaskTaskReportConfigReportOverridesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasyncTaskTaskReportConfigReportOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTaskTaskReportConfigReportOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDeletedOverride")]
        public virtual void ResetDeletedOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkippedOverride")]
        public virtual void ResetSkippedOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferredOverride")]
        public virtual void ResetTransferredOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifiedOverride")]
        public virtual void ResetVerifiedOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletedOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeletedOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skippedOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkippedOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferredOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransferredOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifiedOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifiedOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deletedOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletedOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skippedOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkippedOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transferredOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferredOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifiedOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifiedOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides? InternalValue
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
