using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTableExport
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTableExport.DynamodbTableExportIncrementalExportSpecificationOutputReference), fullyQualifiedName: "aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynamodbTableExportIncrementalExportSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynamodbTableExportIncrementalExportSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DynamodbTableExportIncrementalExportSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableExportIncrementalExportSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExportFromTime")]
        public virtual void ResetExportFromTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportToTime")]
        public virtual void ResetExportToTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportViewType")]
        public virtual void ResetExportViewType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportFromTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportFromTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportToTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportToTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportViewTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExportViewTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "exportFromTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportFromTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportToTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportToTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exportViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExportViewType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification\"}", isOptional: true)]
        public virtual aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
