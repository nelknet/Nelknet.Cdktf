using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowTriggerConfigOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowTriggerConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowTriggerConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowTriggerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowTriggerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTriggerProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}}]")]
        public virtual void PutTriggerProperties(aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTriggerProperties")]
        public virtual void ResetTriggerProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "triggerProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowTriggerConfigTriggerPropertiesOutputReference TriggerProperties
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowTriggerConfigTriggerPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerPropertiesInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties? TriggerPropertiesInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TriggerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowTriggerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
