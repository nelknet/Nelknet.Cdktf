using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiClass(nativeType: typeof(aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference), fullyQualifiedName: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMappingParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}}]")]
        public virtual void PutMappingParameters(aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMappingParameters")]
        public virtual void ResetMappingParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference\"}")]
        public virtual aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference MappingParameters
        {
            get => GetInstanceProperty<aws.KinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference>()!;
        }

        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordFormatType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mappingParametersInput", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        public virtual aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParametersInput
        {
            get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}", isOptional: true)]
        public virtual aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat? InternalValue
        {
            get => GetInstanceProperty<aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat?>();
            set => SetInstanceProperty(value);
        }
    }
}
