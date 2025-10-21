using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiClass(nativeType: typeof(aws.EvidentlyProject.EvidentlyProjectDataDeliveryOutputReference), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EvidentlyProjectDataDeliveryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EvidentlyProjectDataDeliveryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EvidentlyProjectDataDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EvidentlyProjectDataDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Destination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3Destination\"}}]")]
        public virtual void PutS3Destination(aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Destination")]
        public virtual void ResetS3Destination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference\"}")]
        public virtual aws.EvidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.EvidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3DestinationOutputReference\"}")]
        public virtual aws.EvidentlyProject.EvidentlyProjectDataDeliveryS3DestinationOutputReference S3Destination
        {
            get => GetInstanceProperty<aws.EvidentlyProject.EvidentlyProjectDataDeliveryS3DestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3Destination\"}", isOptional: true)]
        public virtual aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination? S3DestinationInput
        {
            get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDelivery\"}", isOptional: true)]
        public virtual aws.EvidentlyProject.IEvidentlyProjectDataDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
