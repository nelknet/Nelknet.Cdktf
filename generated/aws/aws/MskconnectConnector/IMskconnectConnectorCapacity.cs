using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorCapacity), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacity")]
    public interface IMskconnectConnectorCapacity
    {
        /// <summary>autoscaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#autoscaling MskconnectConnector#autoscaling}
        /// </remarks>
        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling? Autoscaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>provisioned_capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#provisioned_capacity MskconnectConnector#provisioned_capacity}
        /// </remarks>
        [JsiiProperty(name: "provisionedCapacity", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity? ProvisionedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorCapacity), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>autoscaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#autoscaling MskconnectConnector#autoscaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling? Autoscaling
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling?>();
            }

            /// <summary>provisioned_capacity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#provisioned_capacity MskconnectConnector#provisioned_capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedCapacity", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity? ProvisionedCapacity
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity?>();
            }
        }
    }
}
