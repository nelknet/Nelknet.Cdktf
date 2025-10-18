using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "hcloud.loadBalancer.LoadBalancerTarget")]
    public class LoadBalancerTarget : hcloud.LoadBalancer.ILoadBalancerTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#type LoadBalancer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#server_id LoadBalancer#server_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ServerId
        {
            get;
            set;
        }

        private object? _usePrivateIp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#use_private_ip LoadBalancer#use_private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usePrivateIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UsePrivateIp
        {
            get => _usePrivateIp;
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
                _usePrivateIp = value;
            }
        }
    }
}
