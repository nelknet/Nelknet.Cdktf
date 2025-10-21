using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule")]
    public interface IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#days HdinsightSparkCluster#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Days
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#target_instance_count HdinsightSparkCluster#target_instance_count}.</summary>
        [JsiiProperty(name: "targetInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double TargetInstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#time HdinsightSparkCluster#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrenceSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#days HdinsightSparkCluster#days}.</summary>
            [JsiiProperty(name: "days", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Days
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#target_instance_count HdinsightSparkCluster#target_instance_count}.</summary>
            [JsiiProperty(name: "targetInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#time HdinsightSparkCluster#time}.</summary>
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
            public string Time
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
