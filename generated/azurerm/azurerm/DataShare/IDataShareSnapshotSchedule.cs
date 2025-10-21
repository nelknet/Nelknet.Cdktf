using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataShare
{
    [JsiiInterface(nativeType: typeof(IDataShareSnapshotSchedule), fullyQualifiedName: "azurerm.dataShare.DataShareSnapshotSchedule")]
    public interface IDataShareSnapshotSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#name DataShare#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#recurrence DataShare#recurrence}.</summary>
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
        string Recurrence
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#start_time DataShare#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataShareSnapshotSchedule), fullyQualifiedName: "azurerm.dataShare.DataShareSnapshotSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataShare.IDataShareSnapshotSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#name DataShare#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#recurrence DataShare#recurrence}.</summary>
            [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
            public string Recurrence
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#start_time DataShare#start_time}.</summary>
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
