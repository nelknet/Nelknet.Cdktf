using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilter), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter")]
    public interface IEventgridEventSubscriptionAdvancedFilter
    {
        /// <summary>bool_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#bool_equals EventgridEventSubscription#bool_equals}
        /// </remarks>
        [JsiiProperty(name: "boolEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BoolEquals
        {
            get
            {
                return null;
            }
        }

        /// <summary>is_not_null block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_not_null EventgridEventSubscription#is_not_null}
        /// </remarks>
        [JsiiProperty(name: "isNotNull", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNotNull
        {
            get
            {
                return null;
            }
        }

        /// <summary>is_null_or_undefined block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_null_or_undefined EventgridEventSubscription#is_null_or_undefined}
        /// </remarks>
        [JsiiProperty(name: "isNullOrUndefined", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNullOrUndefined
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_greater_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than EventgridEventSubscription#number_greater_than}
        /// </remarks>
        [JsiiProperty(name: "numberGreaterThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberGreaterThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_greater_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than_or_equals EventgridEventSubscription#number_greater_than_or_equals}
        /// </remarks>
        [JsiiProperty(name: "numberGreaterThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberGreaterThanOrEquals
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in EventgridEventSubscription#number_in}
        /// </remarks>
        [JsiiProperty(name: "numberIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in_range EventgridEventSubscription#number_in_range}
        /// </remarks>
        [JsiiProperty(name: "numberInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberInRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_less_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than EventgridEventSubscription#number_less_than}
        /// </remarks>
        [JsiiProperty(name: "numberLessThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_less_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than_or_equals EventgridEventSubscription#number_less_than_or_equals}
        /// </remarks>
        [JsiiProperty(name: "numberLessThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberLessThanOrEquals
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in EventgridEventSubscription#number_not_in}
        /// </remarks>
        [JsiiProperty(name: "numberNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberNotIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_not_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in_range EventgridEventSubscription#number_not_in_range}
        /// </remarks>
        [JsiiProperty(name: "numberNotInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberNotInRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_begins_with EventgridEventSubscription#string_begins_with}
        /// </remarks>
        [JsiiProperty(name: "stringBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringBeginsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_contains EventgridEventSubscription#string_contains}
        /// </remarks>
        [JsiiProperty(name: "stringContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringContains
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_ends_with EventgridEventSubscription#string_ends_with}
        /// </remarks>
        [JsiiProperty(name: "stringEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringEndsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_in EventgridEventSubscription#string_in}
        /// </remarks>
        [JsiiProperty(name: "stringIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_not_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_begins_with EventgridEventSubscription#string_not_begins_with}
        /// </remarks>
        [JsiiProperty(name: "stringNotBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringNotBeginsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_not_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_contains EventgridEventSubscription#string_not_contains}
        /// </remarks>
        [JsiiProperty(name: "stringNotContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringNotContains
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_not_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_ends_with EventgridEventSubscription#string_not_ends_with}
        /// </remarks>
        [JsiiProperty(name: "stringNotEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringNotEndsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_in EventgridEventSubscription#string_not_in}
        /// </remarks>
        [JsiiProperty(name: "stringNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringNotIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilter), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bool_equals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#bool_equals EventgridEventSubscription#bool_equals}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boolEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BoolEquals
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>is_not_null block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_not_null EventgridEventSubscription#is_not_null}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isNotNull", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IsNotNull
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>is_null_or_undefined block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_null_or_undefined EventgridEventSubscription#is_null_or_undefined}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isNullOrUndefined", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IsNullOrUndefined
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_greater_than block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than EventgridEventSubscription#number_greater_than}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberGreaterThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberGreaterThan
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_greater_than_or_equals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than_or_equals EventgridEventSubscription#number_greater_than_or_equals}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberGreaterThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberGreaterThanOrEquals
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_in block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in EventgridEventSubscription#number_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_in_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in_range EventgridEventSubscription#number_in_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberInRange
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_less_than block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than EventgridEventSubscription#number_less_than}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberLessThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberLessThan
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_less_than_or_equals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than_or_equals EventgridEventSubscription#number_less_than_or_equals}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberLessThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberLessThanOrEquals
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_not_in block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in EventgridEventSubscription#number_not_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberNotIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_not_in_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in_range EventgridEventSubscription#number_not_in_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberNotInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberNotInRange
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_begins_with block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_begins_with EventgridEventSubscription#string_begins_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringBeginsWith
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_contains block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_contains EventgridEventSubscription#string_contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringContains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_ends_with block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_ends_with EventgridEventSubscription#string_ends_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringEndsWith
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_in block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_in EventgridEventSubscription#string_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_not_begins_with block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_begins_with EventgridEventSubscription#string_not_begins_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringNotBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringNotBeginsWith
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_not_contains block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_contains EventgridEventSubscription#string_not_contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringNotContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringNotContains
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_not_ends_with block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_ends_with EventgridEventSubscription#string_not_ends_with}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringNotEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringNotEndsWith
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_not_in block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_in EventgridEventSubscription#string_not_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringNotIn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
