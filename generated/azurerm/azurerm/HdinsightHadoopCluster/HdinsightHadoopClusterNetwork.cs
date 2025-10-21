using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterNetwork")]
    public class HdinsightHadoopClusterNetwork : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#connection_direction HdinsightHadoopCluster#connection_direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionDirection
        {
            get;
            set;
        }

        private object? _privateLinkEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#private_link_enabled HdinsightHadoopCluster#private_link_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PrivateLinkEnabled
        {
            get => _privateLinkEnabled;
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
                _privateLinkEnabled = value;
            }
        }
    }
}
