using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopScalingPlan
{
    [JsiiInterface(nativeType: typeof(IVirtualDesktopScalingPlanHostPool), fullyQualifiedName: "azurerm.virtualDesktopScalingPlan.VirtualDesktopScalingPlanHostPool")]
    public interface IVirtualDesktopScalingPlanHostPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#hostpool_id VirtualDesktopScalingPlan#hostpool_id}.</summary>
        [JsiiProperty(name: "hostpoolId", typeJson: "{\"primitive\":\"string\"}")]
        string HostpoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#scaling_plan_enabled VirtualDesktopScalingPlan#scaling_plan_enabled}.</summary>
        [JsiiProperty(name: "scalingPlanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ScalingPlanEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualDesktopScalingPlanHostPool), fullyQualifiedName: "azurerm.virtualDesktopScalingPlan.VirtualDesktopScalingPlanHostPool")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualDesktopScalingPlan.IVirtualDesktopScalingPlanHostPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#hostpool_id VirtualDesktopScalingPlan#hostpool_id}.</summary>
            [JsiiProperty(name: "hostpoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string HostpoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#scaling_plan_enabled VirtualDesktopScalingPlan#scaling_plan_enabled}.</summary>
            [JsiiProperty(name: "scalingPlanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ScalingPlanEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
