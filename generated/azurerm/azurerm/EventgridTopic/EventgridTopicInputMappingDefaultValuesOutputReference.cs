using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridTopic
{
    [JsiiClass(nativeType: typeof(azurerm.EventgridTopic.EventgridTopicInputMappingDefaultValuesOutputReference), fullyQualifiedName: "azurerm.eventgridTopic.EventgridTopicInputMappingDefaultValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EventgridTopicInputMappingDefaultValuesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EventgridTopicInputMappingDefaultValuesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EventgridTopicInputMappingDefaultValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridTopicInputMappingDefaultValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDataVersion")]
        public virtual void ResetDataVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventType")]
        public virtual void ResetEventType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubject")]
        public virtual void ResetSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.eventgridTopic.EventgridTopicInputMappingDefaultValues\"}", isOptional: true)]
        public virtual azurerm.EventgridTopic.IEventgridTopicInputMappingDefaultValues? InternalValue
        {
            get => GetInstanceProperty<azurerm.EventgridTopic.IEventgridTopicInputMappingDefaultValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
