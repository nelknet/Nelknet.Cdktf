using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RumAppMonitor
{
    [JsiiByValue(fqn: "aws.rumAppMonitor.RumAppMonitorAppMonitorConfiguration")]
    public class RumAppMonitorAppMonitorConfiguration : aws.RumAppMonitor.IRumAppMonitorAppMonitorConfiguration
    {
        private object? _allowCookies;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#allow_cookies RumAppMonitor#allow_cookies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowCookies
        {
            get => _allowCookies;
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
                _allowCookies = value;
            }
        }

        private object? _enableXray;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#enable_xray RumAppMonitor#enable_xray}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableXray", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableXray
        {
            get => _enableXray;
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
                _enableXray = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#excluded_pages RumAppMonitor#excluded_pages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#favorite_pages RumAppMonitor#favorite_pages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "favoritePages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FavoritePages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#guest_role_arn RumAppMonitor#guest_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "guestRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuestRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#identity_pool_id RumAppMonitor#identity_pool_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityPoolId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#included_pages RumAppMonitor#included_pages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedPages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedPages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#session_sample_rate RumAppMonitor#session_sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionSampleRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#telemetries RumAppMonitor#telemetries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "telemetries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Telemetries
        {
            get;
            set;
        }
    }
}
