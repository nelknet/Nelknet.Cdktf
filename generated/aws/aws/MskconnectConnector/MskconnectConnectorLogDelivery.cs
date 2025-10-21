using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorLogDelivery")]
    public class MskconnectConnectorLogDelivery : aws.MskconnectConnector.IMskconnectConnectorLogDelivery
    {
        /// <summary>worker_log_delivery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_log_delivery MskconnectConnector#worker_log_delivery}
        /// </remarks>
        [JsiiProperty(name: "workerLogDelivery", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery\"}")]
        public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery WorkerLogDelivery
        {
            get;
            set;
        }
    }
}
