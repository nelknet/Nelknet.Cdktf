using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamFleet
{
    [JsiiClass(nativeType: typeof(aws.AppstreamFleet.AppstreamFleetComputeCapacityOutputReference), fullyQualifiedName: "aws.appstreamFleet.AppstreamFleetComputeCapacityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppstreamFleetComputeCapacityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppstreamFleetComputeCapacityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppstreamFleetComputeCapacityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppstreamFleetComputeCapacityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDesiredInstances")]
        public virtual void ResetDesiredInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredSessions")]
        public virtual void ResetDesiredSessions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "available", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Available
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inUse", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InUse
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "running", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Running
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredSessionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredSessionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredSessions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredSessions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appstreamFleet.AppstreamFleetComputeCapacity\"}", isOptional: true)]
        public virtual aws.AppstreamFleet.IAppstreamFleetComputeCapacity? InternalValue
        {
            get => GetInstanceProperty<aws.AppstreamFleet.IAppstreamFleetComputeCapacity?>();
            set => SetInstanceProperty(value);
        }
    }
}
