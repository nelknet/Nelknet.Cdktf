using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmMaintenanceWindows
{
    [JsiiInterface(nativeType: typeof(IDataAwsSsmMaintenanceWindowsFilter), fullyQualifiedName: "aws.dataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsFilter")]
    public interface IDataAwsSsmMaintenanceWindowsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#name DataAwsSsmMaintenanceWindows#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#values DataAwsSsmMaintenanceWindows#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSsmMaintenanceWindowsFilter), fullyQualifiedName: "aws.dataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSsmMaintenanceWindows.IDataAwsSsmMaintenanceWindowsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#name DataAwsSsmMaintenanceWindows#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#values DataAwsSsmMaintenanceWindows#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
