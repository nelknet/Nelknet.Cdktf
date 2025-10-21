using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiByValue(fqn: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter")]
    public class EventgridEventSubscriptionSubjectFilter : azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter
    {
        private object? _caseSensitive;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#case_sensitive EventgridEventSubscription#case_sensitive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caseSensitive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CaseSensitive
        {
            get => _caseSensitive;
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
                _caseSensitive = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_begins_with EventgridEventSubscription#subject_begins_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectBeginsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectBeginsWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_ends_with EventgridEventSubscription#subject_ends_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectEndsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectEndsWith
        {
            get;
            set;
        }
    }
}
