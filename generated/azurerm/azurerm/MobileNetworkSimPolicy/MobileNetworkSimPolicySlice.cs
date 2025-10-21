using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySlice")]
    public class MobileNetworkSimPolicySlice : azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySlice
    {
        private object _dataNetwork;

        /// <summary>data_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network MobileNetworkSimPolicy#data_network}
        /// </remarks>
        [JsiiProperty(name: "dataNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork\"},\"kind\":\"array\"}}]}}")]
        public object DataNetwork
        {
            get => _dataNetwork;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetwork[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetwork).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetwork).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataNetwork = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_data_network_id MobileNetworkSimPolicy#default_data_network_id}.</summary>
        [JsiiProperty(name: "defaultDataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultDataNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#slice_id MobileNetworkSimPolicy#slice_id}.</summary>
        [JsiiProperty(name: "sliceId", typeJson: "{\"primitive\":\"string\"}")]
        public string SliceId
        {
            get;
            set;
        }
    }
}
