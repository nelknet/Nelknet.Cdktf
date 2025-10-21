using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity")]
    public class MskconnectConnectorCapacityProvisionedCapacity : aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_count MskconnectConnector#worker_count}.</summary>
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public double WorkerCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#mcu_count MskconnectConnector#mcu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mcuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? McuCount
        {
            get;
            set;
        }
    }
}
