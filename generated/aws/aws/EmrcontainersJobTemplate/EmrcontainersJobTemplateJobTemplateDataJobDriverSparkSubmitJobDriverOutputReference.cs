using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiClass(nativeType: typeof(aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriverOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEntryPointArguments")]
        public virtual void ResetEntryPointArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSparkSubmitParameters")]
        public virtual void ResetSparkSubmitParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "entryPointArgumentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EntryPointArgumentsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entryPointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntryPointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkSubmitParametersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkSubmitParametersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "entryPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntryPoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entryPointArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EntryPointArguments
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkSubmitParameters", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkSubmitParameters
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver? InternalValue
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver?>();
            set => SetInstanceProperty(value);
        }
    }
}
