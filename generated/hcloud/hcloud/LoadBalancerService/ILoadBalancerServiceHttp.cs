using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancerService
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerServiceHttp), fullyQualifiedName: "hcloud.loadBalancerService.LoadBalancerServiceHttp")]
    public interface ILoadBalancerServiceHttp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#certificates LoadBalancerService#certificates}.</summary>
        [JsiiProperty(name: "certificates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? Certificates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#cookie_lifetime LoadBalancerService#cookie_lifetime}.</summary>
        [JsiiProperty(name: "cookieLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CookieLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#cookie_name LoadBalancerService#cookie_name}.</summary>
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CookieName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#redirect_http LoadBalancerService#redirect_http}.</summary>
        [JsiiProperty(name: "redirectHttp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedirectHttp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#sticky_sessions LoadBalancerService#sticky_sessions}.</summary>
        [JsiiProperty(name: "stickySessions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StickySessions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerServiceHttp), fullyQualifiedName: "hcloud.loadBalancerService.LoadBalancerServiceHttp")]
        internal sealed class _Proxy : DeputyBase, hcloud.LoadBalancerService.ILoadBalancerServiceHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#certificates LoadBalancerService#certificates}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? Certificates
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#cookie_lifetime LoadBalancerService#cookie_lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookieLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CookieLifetime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#cookie_name LoadBalancerService#cookie_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CookieName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#redirect_http LoadBalancerService#redirect_http}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectHttp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RedirectHttp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#sticky_sessions LoadBalancerService#sticky_sessions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stickySessions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StickySessions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
