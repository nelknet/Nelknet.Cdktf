using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerDefaultActionForwardTargetGroups), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups")]
    public interface IVpclatticeListenerDefaultActionForwardTargetGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_group_identifier VpclatticeListener#target_group_identifier}.</summary>
        [JsiiProperty(name: "targetGroupIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#weight VpclatticeListener#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerDefaultActionForwardTargetGroups), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListener.IVpclatticeListenerDefaultActionForwardTargetGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_group_identifier VpclatticeListener#target_group_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#weight VpclatticeListener#weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
