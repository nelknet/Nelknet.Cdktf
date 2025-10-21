using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiInterface(nativeType: typeof(IConfigRemediationConfigurationParameter), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationParameter")]
    public interface IConfigRemediationConfigurationParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#name ConfigRemediationConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#resource_value ConfigRemediationConfiguration#resource_value}.</summary>
        [JsiiProperty(name: "resourceValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_value ConfigRemediationConfiguration#static_value}.</summary>
        [JsiiProperty(name: "staticValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StaticValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_values ConfigRemediationConfiguration#static_values}.</summary>
        [JsiiProperty(name: "staticValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StaticValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigRemediationConfigurationParameter), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationParameter")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#name ConfigRemediationConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#resource_value ConfigRemediationConfiguration#resource_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_value ConfigRemediationConfiguration#static_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StaticValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_values ConfigRemediationConfiguration#static_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StaticValues
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
