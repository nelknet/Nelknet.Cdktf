using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftserverlessWorkgroup
{
    [JsiiInterface(nativeType: typeof(IRedshiftserverlessWorkgroupConfigParameter), fullyQualifiedName: "aws.redshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfigParameter")]
    public interface IRedshiftserverlessWorkgroupConfigParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_key RedshiftserverlessWorkgroup#parameter_key}.</summary>
        [JsiiProperty(name: "parameterKey", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_value RedshiftserverlessWorkgroup#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftserverlessWorkgroupConfigParameter), fullyQualifiedName: "aws.redshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfigParameter")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftserverlessWorkgroup.IRedshiftserverlessWorkgroupConfigParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_key RedshiftserverlessWorkgroup#parameter_key}.</summary>
            [JsiiProperty(name: "parameterKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_value RedshiftserverlessWorkgroup#parameter_value}.</summary>
            [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
