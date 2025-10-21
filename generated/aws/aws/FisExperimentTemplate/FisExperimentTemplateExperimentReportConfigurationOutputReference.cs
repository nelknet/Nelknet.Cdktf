using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiClass(nativeType: typeof(aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputReference), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FisExperimentTemplateExperimentReportConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FisExperimentTemplateExperimentReportConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FisExperimentTemplateExperimentReportConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FisExperimentTemplateExperimentReportConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources\"}}]")]
        public virtual void PutDataSources(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs\"}}]")]
        public virtual void PutOutputs(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataSources")]
        public virtual void ResetDataSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputs")]
        public virtual void ResetOutputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostExperimentDuration")]
        public virtual void ResetPostExperimentDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreExperimentDuration")]
        public virtual void ResetPreExperimentDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataSources", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesOutputReference DataSources
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesOutputReference>()!;
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputsOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputsOutputReference Outputs
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourcesInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources? DataSourcesInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputsInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs? OutputsInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postExperimentDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostExperimentDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preExperimentDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreExperimentDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "postExperimentDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostExperimentDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preExperimentDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreExperimentDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
