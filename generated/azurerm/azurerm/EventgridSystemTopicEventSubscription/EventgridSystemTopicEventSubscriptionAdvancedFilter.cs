using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    [JsiiByValue(fqn: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilter")]
    public class EventgridSystemTopicEventSubscriptionAdvancedFilter : azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilter
    {
        private object? _boolEquals;

        /// <summary>bool_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#bool_equals EventgridSystemTopicEventSubscription#bool_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boolEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BoolEquals
        {
            get => _boolEquals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterBoolEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterBoolEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _boolEquals = value;
            }
        }

        private object? _isNotNull;

        /// <summary>is_not_null block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#is_not_null EventgridSystemTopicEventSubscription#is_not_null}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isNotNull", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IsNotNull
        {
            get => _isNotNull;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNotNull[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNotNull).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isNotNull = value;
            }
        }

        private object? _isNullOrUndefined;

        /// <summary>is_null_or_undefined block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#is_null_or_undefined EventgridSystemTopicEventSubscription#is_null_or_undefined}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isNullOrUndefined", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IsNullOrUndefined
        {
            get => _isNullOrUndefined;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isNullOrUndefined = value;
            }
        }

        private object? _numberGreaterThan;

        /// <summary>number_greater_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_greater_than EventgridSystemTopicEventSubscription#number_greater_than}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberGreaterThan
        {
            get => _numberGreaterThan;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThan[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThan).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberGreaterThan = value;
            }
        }

        private object? _numberGreaterThanOrEquals;

        /// <summary>number_greater_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_greater_than_or_equals EventgridSystemTopicEventSubscription#number_greater_than_or_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberGreaterThanOrEquals
        {
            get => _numberGreaterThanOrEquals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberGreaterThanOrEquals = value;
            }
        }

        private object? _numberIn;

        /// <summary>number_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_in EventgridSystemTopicEventSubscription#number_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberIn
        {
            get => _numberIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberIn = value;
            }
        }

        private object? _numberInRange;

        /// <summary>number_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_in_range EventgridSystemTopicEventSubscription#number_in_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberInRange
        {
            get => _numberInRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberInRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberInRange = value;
            }
        }

        private object? _numberLessThan;

        /// <summary>number_less_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_less_than EventgridSystemTopicEventSubscription#number_less_than}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberLessThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberLessThan
        {
            get => _numberLessThan;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThan[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThan).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberLessThan = value;
            }
        }

        private object? _numberLessThanOrEquals;

        /// <summary>number_less_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_less_than_or_equals EventgridSystemTopicEventSubscription#number_less_than_or_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberLessThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberLessThanOrEquals
        {
            get => _numberLessThanOrEquals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThanOrEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberLessThanOrEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberLessThanOrEquals = value;
            }
        }

        private object? _numberNotIn;

        /// <summary>number_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_not_in EventgridSystemTopicEventSubscription#number_not_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberNotIn
        {
            get => _numberNotIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberNotIn = value;
            }
        }

        private object? _numberNotInRange;

        /// <summary>number_not_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#number_not_in_range EventgridSystemTopicEventSubscription#number_not_in_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberNotInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberNotInRange
        {
            get => _numberNotInRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotInRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterNumberNotInRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberNotInRange = value;
            }
        }

        private object? _stringBeginsWith;

        /// <summary>string_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_begins_with EventgridSystemTopicEventSubscription#string_begins_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringBeginsWith
        {
            get => _stringBeginsWith;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringBeginsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringBeginsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringBeginsWith = value;
            }
        }

        private object? _stringContains;

        /// <summary>string_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_contains EventgridSystemTopicEventSubscription#string_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringContains
        {
            get => _stringContains;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringContains[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringContains).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringContains = value;
            }
        }

        private object? _stringEndsWith;

        /// <summary>string_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_ends_with EventgridSystemTopicEventSubscription#string_ends_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringEndsWith
        {
            get => _stringEndsWith;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringEndsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringEndsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringEndsWith = value;
            }
        }

        private object? _stringIn;

        /// <summary>string_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_in EventgridSystemTopicEventSubscription#string_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringIn
        {
            get => _stringIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringIn = value;
            }
        }

        private object? _stringNotBeginsWith;

        /// <summary>string_not_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_not_begins_with EventgridSystemTopicEventSubscription#string_not_begins_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringNotBeginsWith
        {
            get => _stringNotBeginsWith;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotBeginsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotBeginsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotBeginsWith = value;
            }
        }

        private object? _stringNotContains;

        /// <summary>string_not_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_not_contains EventgridSystemTopicEventSubscription#string_not_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringNotContains
        {
            get => _stringNotContains;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotContains[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotContains).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotContains = value;
            }
        }

        private object? _stringNotEndsWith;

        /// <summary>string_not_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_not_ends_with EventgridSystemTopicEventSubscription#string_not_ends_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringNotEndsWith
        {
            get => _stringNotEndsWith;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotEndsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotEndsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotEndsWith = value;
            }
        }

        private object? _stringNotIn;

        /// <summary>string_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#string_not_in EventgridSystemTopicEventSubscription#string_not_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringNotIn
        {
            get => _stringNotIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterStringNotIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotIn = value;
            }
        }
    }
}
