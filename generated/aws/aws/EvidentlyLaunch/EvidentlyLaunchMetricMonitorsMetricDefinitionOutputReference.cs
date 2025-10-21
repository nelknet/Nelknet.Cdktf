using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiClass(nativeType: typeof(aws.EvidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EvidentlyLaunchMetricMonitorsMetricDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEventPattern")]
        public virtual void ResetEventPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnitLabel")]
        public virtual void ResetUnitLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityIdKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntityIdKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnitLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValueKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "entityIdKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityIdKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnitLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "valueKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValueKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition\"}", isOptional: true)]
        public virtual aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
