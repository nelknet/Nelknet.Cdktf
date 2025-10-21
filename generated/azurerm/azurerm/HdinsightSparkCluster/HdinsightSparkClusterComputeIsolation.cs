using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterComputeIsolation")]
    public class HdinsightSparkClusterComputeIsolation : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComputeIsolation
    {
        private object? _computeIsolationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#compute_isolation_enabled HdinsightSparkCluster#compute_isolation_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeIsolationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ComputeIsolationEnabled
        {
            get => _computeIsolationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _computeIsolationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#host_sku HdinsightSparkCluster#host_sku}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostSku
        {
            get;
            set;
        }
    }
}
