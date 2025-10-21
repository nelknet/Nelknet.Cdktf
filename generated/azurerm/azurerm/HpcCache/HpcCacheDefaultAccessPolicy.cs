using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCache.HpcCacheDefaultAccessPolicy")]
    public class HpcCacheDefaultAccessPolicy : azurerm.HpcCache.IHpcCacheDefaultAccessPolicy
    {
        private object _accessRule;

        /// <summary>access_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#access_rule HpcCache#access_rule}
        /// </remarks>
        [JsiiProperty(name: "accessRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicyAccessRule\"},\"kind\":\"array\"}}]}}")]
        public object AccessRule
        {
            get => _accessRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.HpcCache.IHpcCacheDefaultAccessPolicyAccessRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HpcCache.IHpcCacheDefaultAccessPolicyAccessRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.HpcCache.IHpcCacheDefaultAccessPolicyAccessRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessRule = value;
            }
        }
    }
}
