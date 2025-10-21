using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeEnrichmentParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeEnrichmentParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeEnrichmentParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeEnrichmentParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeEnrichmentParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeEnrichmentParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters\"}}]")]
        public virtual void PutHttpParameters(aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpParameters")]
        public virtual void ResetHttpParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputTemplate")]
        public virtual void ResetInputTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParametersOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeEnrichmentParametersHttpParametersOutputReference HttpParameters
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeEnrichmentParametersHttpParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpParametersInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters? HttpParametersInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeEnrichmentParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeEnrichmentParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
