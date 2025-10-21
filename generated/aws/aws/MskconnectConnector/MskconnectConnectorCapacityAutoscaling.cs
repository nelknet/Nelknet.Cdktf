using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling")]
    public class MskconnectConnectorCapacityAutoscaling : aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#max_worker_count MskconnectConnector#max_worker_count}.</summary>
        [JsiiProperty(name: "maxWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxWorkerCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#min_worker_count MskconnectConnector#min_worker_count}.</summary>
        [JsiiProperty(name: "minWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinWorkerCount
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

        /// <summary>scale_in_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_in_policy MskconnectConnector#scale_in_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy? ScaleInPolicy
        {
            get;
            set;
        }

        /// <summary>scale_out_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#scale_out_policy MskconnectConnector#scale_out_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleOutPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy? ScaleOutPolicy
        {
            get;
            set;
        }
    }
}
