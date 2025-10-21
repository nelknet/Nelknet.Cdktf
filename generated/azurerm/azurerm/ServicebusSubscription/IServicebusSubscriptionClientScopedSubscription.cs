using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServicebusSubscription
{
    [JsiiInterface(nativeType: typeof(IServicebusSubscriptionClientScopedSubscription), fullyQualifiedName: "azurerm.servicebusSubscription.ServicebusSubscriptionClientScopedSubscription")]
    public interface IServicebusSubscriptionClientScopedSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#client_id ServicebusSubscription#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#is_client_scoped_subscription_shareable ServicebusSubscription#is_client_scoped_subscription_shareable}.</summary>
        [JsiiProperty(name: "isClientScopedSubscriptionShareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsClientScopedSubscriptionShareable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicebusSubscriptionClientScopedSubscription), fullyQualifiedName: "azurerm.servicebusSubscription.ServicebusSubscriptionClientScopedSubscription")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServicebusSubscription.IServicebusSubscriptionClientScopedSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#client_id ServicebusSubscription#client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#is_client_scoped_subscription_shareable ServicebusSubscription#is_client_scoped_subscription_shareable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isClientScopedSubscriptionShareable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsClientScopedSubscriptionShareable
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
