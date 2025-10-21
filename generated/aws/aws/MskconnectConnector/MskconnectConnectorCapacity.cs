using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorCapacity")]
    public class MskconnectConnectorCapacity : aws.MskconnectConnector.IMskconnectConnectorCapacity
    {
        /// <summary>autoscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#autoscaling MskconnectConnector#autoscaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling? Autoscaling
        {
            get;
            set;
        }

        /// <summary>provisioned_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#provisioned_capacity MskconnectConnector#provisioned_capacity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedCapacity", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity? ProvisionedCapacity
        {
            get;
            set;
        }
    }
}
