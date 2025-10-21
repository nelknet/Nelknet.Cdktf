using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildReportGroup
{
    [JsiiClass(nativeType: typeof(aws.CodebuildReportGroup.CodebuildReportGroupExportConfigOutputReference), fullyQualifiedName: "aws.codebuildReportGroup.CodebuildReportGroupExportConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildReportGroupExportConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildReportGroupExportConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodebuildReportGroupExportConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildReportGroupExportConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Destination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildReportGroup.CodebuildReportGroupExportConfigS3Destination\"}}]")]
        public virtual void PutS3Destination(aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Destination")]
        public virtual void ResetS3Destination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuildReportGroup.CodebuildReportGroupExportConfigS3DestinationOutputReference\"}")]
        public virtual aws.CodebuildReportGroup.CodebuildReportGroupExportConfigS3DestinationOutputReference S3Destination
        {
            get => GetInstanceProperty<aws.CodebuildReportGroup.CodebuildReportGroupExportConfigS3DestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"fqn\":\"aws.codebuildReportGroup.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true)]
        public virtual aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination? S3DestinationInput
        {
            get => GetInstanceProperty<aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuildReportGroup.CodebuildReportGroupExportConfig\"}", isOptional: true)]
        public virtual aws.CodebuildReportGroup.ICodebuildReportGroupExportConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CodebuildReportGroup.ICodebuildReportGroupExportConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
