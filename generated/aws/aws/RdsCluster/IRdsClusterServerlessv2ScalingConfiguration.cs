using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RdsCluster
{
    [JsiiInterface(nativeType: typeof(IRdsClusterServerlessv2ScalingConfiguration), fullyQualifiedName: "aws.rdsCluster.RdsClusterServerlessv2ScalingConfiguration")]
    public interface IRdsClusterServerlessv2ScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#max_capacity RdsCluster#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MaxCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#min_capacity RdsCluster#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MinCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#seconds_until_auto_pause RdsCluster#seconds_until_auto_pause}.</summary>
        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SecondsUntilAutoPause
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdsClusterServerlessv2ScalingConfiguration), fullyQualifiedName: "aws.rdsCluster.RdsClusterServerlessv2ScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.RdsCluster.IRdsClusterServerlessv2ScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#max_capacity RdsCluster#max_capacity}.</summary>
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#min_capacity RdsCluster#min_capacity}.</summary>
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MinCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#seconds_until_auto_pause RdsCluster#seconds_until_auto_pause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SecondsUntilAutoPause
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
