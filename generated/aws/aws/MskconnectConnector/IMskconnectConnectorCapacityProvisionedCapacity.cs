using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorCapacityProvisionedCapacity), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity")]
    public interface IMskconnectConnectorCapacityProvisionedCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_count MskconnectConnector#worker_count}.</summary>
        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        double WorkerCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#mcu_count MskconnectConnector#mcu_count}.</summary>
        [JsiiProperty(name: "mcuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? McuCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorCapacityProvisionedCapacity), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_count MskconnectConnector#worker_count}.</summary>
            [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
            public double WorkerCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#mcu_count MskconnectConnector#mcu_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mcuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? McuCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
