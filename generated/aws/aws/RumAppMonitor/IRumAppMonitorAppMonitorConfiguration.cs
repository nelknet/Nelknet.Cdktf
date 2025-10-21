using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RumAppMonitor
{
    [JsiiInterface(nativeType: typeof(IRumAppMonitorAppMonitorConfiguration), fullyQualifiedName: "aws.rumAppMonitor.RumAppMonitorAppMonitorConfiguration")]
    public interface IRumAppMonitorAppMonitorConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#allow_cookies RumAppMonitor#allow_cookies}.</summary>
        [JsiiProperty(name: "allowCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#enable_xray RumAppMonitor#enable_xray}.</summary>
        [JsiiProperty(name: "enableXray", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableXray
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#excluded_pages RumAppMonitor#excluded_pages}.</summary>
        [JsiiProperty(name: "excludedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedPages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#favorite_pages RumAppMonitor#favorite_pages}.</summary>
        [JsiiProperty(name: "favoritePages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FavoritePages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#guest_role_arn RumAppMonitor#guest_role_arn}.</summary>
        [JsiiProperty(name: "guestRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuestRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#identity_pool_id RumAppMonitor#identity_pool_id}.</summary>
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityPoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#included_pages RumAppMonitor#included_pages}.</summary>
        [JsiiProperty(name: "includedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedPages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#session_sample_rate RumAppMonitor#session_sample_rate}.</summary>
        [JsiiProperty(name: "sessionSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#telemetries RumAppMonitor#telemetries}.</summary>
        [JsiiProperty(name: "telemetries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Telemetries
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRumAppMonitorAppMonitorConfiguration), fullyQualifiedName: "aws.rumAppMonitor.RumAppMonitorAppMonitorConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.RumAppMonitor.IRumAppMonitorAppMonitorConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#allow_cookies RumAppMonitor#allow_cookies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowCookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#enable_xray RumAppMonitor#enable_xray}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableXray", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableXray
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#excluded_pages RumAppMonitor#excluded_pages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedPages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#favorite_pages RumAppMonitor#favorite_pages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "favoritePages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FavoritePages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#guest_role_arn RumAppMonitor#guest_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guestRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuestRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#identity_pool_id RumAppMonitor#identity_pool_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityPoolId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#included_pages RumAppMonitor#included_pages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedPages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#session_sample_rate RumAppMonitor#session_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#telemetries RumAppMonitor#telemetries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "telemetries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Telemetries
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
