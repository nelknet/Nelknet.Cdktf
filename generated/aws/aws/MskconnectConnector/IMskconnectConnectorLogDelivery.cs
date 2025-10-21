using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorLogDelivery), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDelivery")]
    public interface IMskconnectConnectorLogDelivery
    {
        /// <summary>worker_log_delivery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_log_delivery MskconnectConnector#worker_log_delivery}
        /// </remarks>
        [JsiiProperty(name: "workerLogDelivery", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}")]
        aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery WorkerLogDelivery
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorLogDelivery), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDelivery")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorLogDelivery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>worker_log_delivery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_log_delivery MskconnectConnector#worker_log_delivery}
            /// </remarks>
            [JsiiProperty(name: "workerLogDelivery", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}")]
            public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery WorkerLogDelivery
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery>()!;
            }
        }
    }
}
