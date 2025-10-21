using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowTriggerConfigTriggerPropertiesOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowTriggerConfigTriggerPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowTriggerConfigTriggerPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowTriggerConfigTriggerPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowTriggerConfigTriggerPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScheduled", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled\"}}]")]
        public virtual void PutScheduled(aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetScheduled")]
        public virtual void ResetScheduled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scheduled", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduledOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduledOutputReference Scheduled
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduledOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled? ScheduledInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowTriggerConfigTriggerProperties\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
