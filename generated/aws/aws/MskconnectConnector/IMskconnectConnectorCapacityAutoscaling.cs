using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorCapacityAutoscaling), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling")]
    public interface IMskconnectConnectorCapacityAutoscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#max_worker_count MskconnectConnector#max_worker_count}.</summary>
        [JsiiProperty(name: "maxWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxWorkerCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#min_worker_count MskconnectConnector#min_worker_count}.</summary>
        [JsiiProperty(name: "minWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinWorkerCount
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

        /// <summary>scale_in_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_in_policy MskconnectConnector#scale_in_policy}
        /// </remarks>
        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy? ScaleInPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>scale_out_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_out_policy MskconnectConnector#scale_out_policy}
        /// </remarks>
        [JsiiProperty(name: "scaleOutPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorCapacityAutoscaling), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#max_worker_count MskconnectConnector#max_worker_count}.</summary>
            [JsiiProperty(name: "maxWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxWorkerCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#min_worker_count MskconnectConnector#min_worker_count}.</summary>
            [JsiiProperty(name: "minWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinWorkerCount
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

            /// <summary>scale_in_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_in_policy MskconnectConnector#scale_in_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy? ScaleInPolicy
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy?>();
            }

            /// <summary>scale_out_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_out_policy MskconnectConnector#scale_out_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleOutPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy?>();
            }
        }
    }
}
