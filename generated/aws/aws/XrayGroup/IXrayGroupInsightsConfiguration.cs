using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.XrayGroup
{
    [JsiiInterface(nativeType: typeof(IXrayGroupInsightsConfiguration), fullyQualifiedName: "aws.xrayGroup.XrayGroupInsightsConfiguration")]
    public interface IXrayGroupInsightsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#insights_enabled XrayGroup#insights_enabled}.</summary>
        [JsiiProperty(name: "insightsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object InsightsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#notifications_enabled XrayGroup#notifications_enabled}.</summary>
        [JsiiProperty(name: "notificationsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotificationsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IXrayGroupInsightsConfiguration), fullyQualifiedName: "aws.xrayGroup.XrayGroupInsightsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.XrayGroup.IXrayGroupInsightsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#insights_enabled XrayGroup#insights_enabled}.</summary>
            [JsiiProperty(name: "insightsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object InsightsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#notifications_enabled XrayGroup#notifications_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? NotificationsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
