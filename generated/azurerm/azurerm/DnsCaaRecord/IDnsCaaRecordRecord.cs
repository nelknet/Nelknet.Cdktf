using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsCaaRecord
{
    [JsiiInterface(nativeType: typeof(IDnsCaaRecordRecord), fullyQualifiedName: "azurerm.dnsCaaRecord.DnsCaaRecordRecord")]
    public interface IDnsCaaRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#flags DnsCaaRecord#flags}.</summary>
        [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
        double Flags
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#tag DnsCaaRecord#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        string Tag
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#value DnsCaaRecord#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsCaaRecordRecord), fullyQualifiedName: "azurerm.dnsCaaRecord.DnsCaaRecordRecord")]
        internal sealed class _Proxy : DeputyBase, azurerm.DnsCaaRecord.IDnsCaaRecordRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#flags DnsCaaRecord#flags}.</summary>
            [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
            public double Flags
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#tag DnsCaaRecord#tag}.</summary>
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
            public string Tag
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#value DnsCaaRecord#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
