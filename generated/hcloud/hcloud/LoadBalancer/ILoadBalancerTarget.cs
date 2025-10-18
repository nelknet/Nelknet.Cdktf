using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerTarget), fullyQualifiedName: "hcloud.loadBalancer.LoadBalancerTarget")]
    public interface ILoadBalancerTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#type LoadBalancer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#server_id LoadBalancer#server_id}.</summary>
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ServerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#use_private_ip LoadBalancer#use_private_ip}.</summary>
        [JsiiProperty(name: "usePrivateIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UsePrivateIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerTarget), fullyQualifiedName: "hcloud.loadBalancer.LoadBalancerTarget")]
        internal sealed class _Proxy : DeputyBase, hcloud.LoadBalancer.ILoadBalancerTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#type LoadBalancer#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#server_id LoadBalancer#server_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ServerId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#use_private_ip LoadBalancer#use_private_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usePrivateIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UsePrivateIp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
