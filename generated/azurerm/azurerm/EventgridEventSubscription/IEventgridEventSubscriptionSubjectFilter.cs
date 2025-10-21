using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionSubjectFilter), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter")]
    public interface IEventgridEventSubscriptionSubjectFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#case_sensitive EventgridEventSubscription#case_sensitive}.</summary>
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaseSensitive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_begins_with EventgridEventSubscription#subject_begins_with}.</summary>
        [JsiiProperty(name: "subjectBeginsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectBeginsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_ends_with EventgridEventSubscription#subject_ends_with}.</summary>
        [JsiiProperty(name: "subjectEndsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectEndsWith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionSubjectFilter), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#case_sensitive EventgridEventSubscription#case_sensitive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CaseSensitive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_begins_with EventgridEventSubscription#subject_begins_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectBeginsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectBeginsWith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_ends_with EventgridEventSubscription#subject_ends_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectEndsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectEndsWith
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
