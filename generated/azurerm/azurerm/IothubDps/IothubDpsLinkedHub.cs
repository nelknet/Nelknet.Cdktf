using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IothubDps
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.iothubDps.IothubDpsLinkedHub")]
    public class IothubDpsLinkedHub : azurerm.IothubDps.IIothubDpsLinkedHub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#connection_string IothubDps#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#location IothubDps#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#allocation_weight IothubDps#allocation_weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocationWeight
        {
            get;
            set;
        }

        private object? _applyAllocationPolicy;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps#apply_allocation_policy IothubDps#apply_allocation_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyAllocationPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyAllocationPolicy
        {
            get => _applyAllocationPolicy;
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
                _applyAllocationPolicy = value;
            }
        }
    }
}
