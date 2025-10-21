using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestScheduleNotificationSettings), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleNotificationSettings")]
    public interface IDevTestScheduleNotificationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#status DevTestSchedule#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time_in_minutes DevTestSchedule#time_in_minutes}.</summary>
        [JsiiProperty(name: "timeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#webhook_url DevTestSchedule#webhook_url}.</summary>
        [JsiiProperty(name: "webhookUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebhookUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestScheduleNotificationSettings), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleNotificationSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#status DevTestSchedule#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time_in_minutes DevTestSchedule#time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#webhook_url DevTestSchedule#webhook_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webhookUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebhookUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
