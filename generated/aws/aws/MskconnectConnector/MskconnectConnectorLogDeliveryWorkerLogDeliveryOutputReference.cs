using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose\"}}]")]
        public virtual void PutFirehose(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3\"}}]")]
        public virtual void PutS3(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogsOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehoseOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3OutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3OutputReference S3
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3? S3Input
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
