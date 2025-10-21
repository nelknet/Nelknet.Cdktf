using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    [JsiiClass(nativeType: typeof(aws.DatasyncTask.DatasyncTaskTaskReportConfigOutputReference), fullyQualifiedName: "aws.datasyncTask.DatasyncTaskTaskReportConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasyncTaskTaskReportConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasyncTaskTaskReportConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatasyncTaskTaskReportConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTaskTaskReportConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReportOverrides", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}}]")]
        public virtual void PutReportOverrides(aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Destination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination\"}}]")]
        public virtual void PutS3Destination(aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOutputType")]
        public virtual void ResetOutputType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportLevel")]
        public virtual void ResetReportLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportOverrides")]
        public virtual void ResetReportOverrides()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ObjectVersioning")]
        public virtual void ResetS3ObjectVersioning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "reportOverrides", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverridesOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskTaskReportConfigReportOverridesOutputReference ReportOverrides
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskTaskReportConfigReportOverridesOutputReference>()!;
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3DestinationOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskTaskReportConfigS3DestinationOutputReference S3Destination
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskTaskReportConfigS3DestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportOverridesInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigReportOverrides\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides? ReportOverridesInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfigReportOverrides?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigS3Destination\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination? S3DestinationInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfigS3Destination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersioningInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3ObjectVersioningInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outputType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3ObjectVersioning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3ObjectVersioning
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfig\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskTaskReportConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
