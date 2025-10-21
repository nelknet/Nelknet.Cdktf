using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftserverlessWorkgroup
{
    [JsiiInterface(nativeType: typeof(IRedshiftserverlessWorkgroupPricePerformanceTarget), fullyQualifiedName: "aws.redshiftserverlessWorkgroup.RedshiftserverlessWorkgroupPricePerformanceTarget")]
    public interface IRedshiftserverlessWorkgroupPricePerformanceTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#enabled RedshiftserverlessWorkgroup#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#level RedshiftserverlessWorkgroup#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Level
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftserverlessWorkgroupPricePerformanceTarget), fullyQualifiedName: "aws.redshiftserverlessWorkgroup.RedshiftserverlessWorkgroupPricePerformanceTarget")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftserverlessWorkgroup.IRedshiftserverlessWorkgroupPricePerformanceTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#enabled RedshiftserverlessWorkgroup#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#level RedshiftserverlessWorkgroup#level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Level
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
