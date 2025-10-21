using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorLogDeliveryOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorLogDeliveryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorLogDeliveryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorLogDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorLogDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWorkerLogDelivery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}}]")]
        public virtual void PutWorkerLogDelivery(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery)}, new object[]{@value});
        }

        [JsiiProperty(name: "workerLogDelivery", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference WorkerLogDelivery
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerLogDeliveryInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery? WorkerLogDeliveryInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDelivery\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorLogDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
