using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceRefresh), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefresh")]
    public interface IAutoscalingGroupInstanceRefresh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#strategy AutoscalingGroup#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        string Strategy
        {
            get;
        }

        /// <summary>preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#preferences AutoscalingGroup#preferences}
        /// </remarks>
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences? Preferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#triggers AutoscalingGroup#triggers}.</summary>
        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Triggers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceRefresh), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefresh")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceRefresh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#strategy AutoscalingGroup#strategy}.</summary>
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
            public string Strategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>preferences block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#preferences AutoscalingGroup#preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences? Preferences
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#triggers AutoscalingGroup#triggers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Triggers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
