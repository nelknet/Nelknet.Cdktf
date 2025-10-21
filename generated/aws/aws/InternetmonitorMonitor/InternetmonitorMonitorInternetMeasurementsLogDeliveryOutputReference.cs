using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InternetmonitorMonitor
{
    [JsiiClass(nativeType: typeof(aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference), fullyQualifiedName: "aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InternetmonitorMonitorInternetMeasurementsLogDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Config", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config\"}}]")]
        public virtual void PutS3Config(aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Config")]
        public virtual void ResetS3Config()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3ConfigOutputReference\"}")]
        public virtual aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3ConfigOutputReference S3Config
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3ConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigInput", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config\"}", isOptional: true)]
        public virtual aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config? S3ConfigInput
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDeliveryS3Config?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.internetmonitorMonitor.InternetmonitorMonitorInternetMeasurementsLogDelivery\"}", isOptional: true)]
        public virtual aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.InternetmonitorMonitor.IInternetmonitorMonitorInternetMeasurementsLogDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
