using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiClass(nativeType: typeof(aws.FisExperimentTemplate.FisExperimentTemplateExperimentOptionsOutputReference), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FisExperimentTemplateExperimentOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FisExperimentTemplateExperimentOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FisExperimentTemplateExperimentOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FisExperimentTemplateExperimentOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccountTargeting")]
        public virtual void ResetAccountTargeting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmptyTargetResolutionMode")]
        public virtual void ResetEmptyTargetResolutionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTargetingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountTargetingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emptyTargetResolutionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmptyTargetResolutionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountTargeting", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTargeting
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emptyTargetResolutionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmptyTargetResolutionMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions? InternalValue
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
