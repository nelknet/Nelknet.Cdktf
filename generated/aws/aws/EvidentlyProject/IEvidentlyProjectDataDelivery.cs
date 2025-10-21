using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiInterface(nativeType: typeof(IEvidentlyProjectDataDelivery), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDelivery")]
    public interface IEvidentlyProjectDataDelivery
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#cloudwatch_logs EvidentlyProject#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#s3_destination EvidentlyProject#s3_destination}
        /// </remarks>
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3Destination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination? S3Destination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyProjectDataDelivery), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDelivery")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyProject.IEvidentlyProjectDataDelivery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#cloudwatch_logs EvidentlyProject#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}", isOptional: true)]
            public aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs?>();
            }

            /// <summary>s3_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#s3_destination EvidentlyProject#s3_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3Destination\"}", isOptional: true)]
            public aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination? S3Destination
            {
                get => GetInstanceProperty<aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination?>();
            }
        }
    }
}
