using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiByValue(fqn: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter")]
    public class EventgridEventSubscriptionAdvancedFilter : azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter
    {
        private object? _boolEquals;

        /// <summary>bool_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#bool_equals EventgridEventSubscription#bool_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boolEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _boolEquals = value;
            }
        }

        private object? _isNotNull;

        /// <summary>is_not_null block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_not_null EventgridEventSubscription#is_not_null}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isNotNull", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNotNull[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNotNull).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isNotNull = value;
            }
        }

        private object? _isNullOrUndefined;

        /// <summary>is_null_or_undefined block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#is_null_or_undefined EventgridEventSubscription#is_null_or_undefined}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isNullOrUndefined", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isNullOrUndefined = value;
            }
        }

        private object? _numberGreaterThan;

        /// <summary>number_greater_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than EventgridEventSubscription#number_greater_than}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThan[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThan).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberGreaterThan = value;
            }
        }

        private object? _numberGreaterThanOrEquals;

        /// <summary>number_greater_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_greater_than_or_equals EventgridEventSubscription#number_greater_than_or_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberGreaterThanOrEquals = value;
            }
        }

        private object? _numberIn;

        /// <summary>number_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in EventgridEventSubscription#number_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberIn = value;
            }
        }

        private object? _numberInRange;

        /// <summary>number_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_in_range EventgridEventSubscription#number_in_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberInRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberInRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberInRange = value;
            }
        }

        private object? _numberLessThan;

        /// <summary>number_less_than block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than EventgridEventSubscription#number_less_than}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberLessThan", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThan[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThan).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberLessThan = value;
            }
        }

        private object? _numberLessThanOrEquals;

        /// <summary>number_less_than_or_equals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_less_than_or_equals EventgridEventSubscription#number_less_than_or_equals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberLessThanOrEquals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberLessThanOrEquals = value;
            }
        }

        private object? _numberNotIn;

        /// <summary>number_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in EventgridEventSubscription#number_not_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberNotIn = value;
            }
        }

        private object? _numberNotInRange;

        /// <summary>number_not_in_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#number_not_in_range EventgridEventSubscription#number_not_in_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberNotInRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberNotInRange = value;
            }
        }

        private object? _stringBeginsWith;

        /// <summary>string_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_begins_with EventgridEventSubscription#string_begins_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringBeginsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringBeginsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringBeginsWith = value;
            }
        }

        private object? _stringContains;

        /// <summary>string_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_contains EventgridEventSubscription#string_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringContains[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringContains).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringContains = value;
            }
        }

        private object? _stringEndsWith;

        /// <summary>string_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_ends_with EventgridEventSubscription#string_ends_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringEndsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringEndsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringEndsWith = value;
            }
        }

        private object? _stringIn;

        /// <summary>string_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_in EventgridEventSubscription#string_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringIn = value;
            }
        }

        private object? _stringNotBeginsWith;

        /// <summary>string_not_begins_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_begins_with EventgridEventSubscription#string_not_begins_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotBeginsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotBeginsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotBeginsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotBeginsWith = value;
            }
        }

        private object? _stringNotContains;

        /// <summary>string_not_contains block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_contains EventgridEventSubscription#string_not_contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotContains", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotContains[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotContains).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotContains = value;
            }
        }

        private object? _stringNotEndsWith;

        /// <summary>string_not_ends_with block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_ends_with EventgridEventSubscription#string_not_ends_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotEndsWith", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotEndsWith[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotEndsWith).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotEndsWith = value;
            }
        }

        private object? _stringNotIn;

        /// <summary>string_not_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#string_not_in EventgridEventSubscription#string_not_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringNotIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotIn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotIn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringNotIn = value;
            }
        }
    }
}
