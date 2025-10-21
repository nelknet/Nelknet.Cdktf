using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    [JsiiClass(nativeType: typeof(aws.GlueJob.GlueJobNotificationPropertyOutputReference), fullyQualifiedName: "aws.glueJob.GlueJobNotificationPropertyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueJobNotificationPropertyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueJobNotificationPropertyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueJobNotificationPropertyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueJobNotificationPropertyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNotifyDelayAfter")]
        public virtual void ResetNotifyDelayAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "notifyDelayAfterInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NotifyDelayAfterInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NotifyDelayAfter
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueJob.GlueJobNotificationProperty\"}", isOptional: true)]
        public virtual aws.GlueJob.IGlueJobNotificationProperty? InternalValue
        {
            get => GetInstanceProperty<aws.GlueJob.IGlueJobNotificationProperty?>();
            set => SetInstanceProperty(value);
        }
    }
}
