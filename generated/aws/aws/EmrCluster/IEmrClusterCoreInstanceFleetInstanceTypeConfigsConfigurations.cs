using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations), fullyQualifiedName: "aws.emrCluster.EmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations")]
    public interface IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#classification EmrCluster#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Classification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#properties EmrCluster#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations), fullyQualifiedName: "aws.emrCluster.EmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.EmrCluster.IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#classification EmrCluster#classification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Classification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#properties EmrCluster#properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
