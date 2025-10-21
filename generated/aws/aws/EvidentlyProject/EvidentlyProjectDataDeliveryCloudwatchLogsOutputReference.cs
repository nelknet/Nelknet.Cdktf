using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiClass(nativeType: typeof(aws.EvidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLogGroup")]
        public virtual void ResetLogGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs? InternalValue
        {
            get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
