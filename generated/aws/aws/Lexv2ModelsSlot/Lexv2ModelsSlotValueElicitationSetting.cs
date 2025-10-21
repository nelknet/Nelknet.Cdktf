using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSetting")]
    public class Lexv2ModelsSlotValueElicitationSetting : aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_constraint Lexv2ModelsSlot#slot_constraint}.</summary>
        [JsiiProperty(name: "slotConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string SlotConstraint
        {
            get;
            set;
        }

        private object? _defaultValueSpecification;

        /// <summary>default_value_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#default_value_specification Lexv2ModelsSlot#default_value_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultValueSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefaultValueSpecification
        {
            get => _defaultValueSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultValueSpecification = value;
            }
        }

        private object? _promptSpecification;

        /// <summary>prompt_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#prompt_specification Lexv2ModelsSlot#prompt_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PromptSpecification
        {
            get => _promptSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _promptSpecification = value;
            }
        }

        private object? _sampleUtterance;

        /// <summary>sample_utterance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#sample_utterance Lexv2ModelsSlot#sample_utterance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sampleUtterance", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingSampleUtterance\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SampleUtterance
        {
            get => _sampleUtterance;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSampleUtterance[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSampleUtterance).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sampleUtterance = value;
            }
        }

        private object? _slotResolutionSetting;

        /// <summary>slot_resolution_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_resolution_setting Lexv2ModelsSlot#slot_resolution_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slotResolutionSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingSlotResolutionSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SlotResolutionSetting
        {
            get => _slotResolutionSetting;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSlotResolutionSetting[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSlotResolutionSetting).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slotResolutionSetting = value;
            }
        }

        private object? _waitAndContinueSpecification;

        /// <summary>wait_and_continue_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#wait_and_continue_specification Lexv2ModelsSlot#wait_and_continue_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "waitAndContinueSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WaitAndContinueSpecification
        {
            get => _waitAndContinueSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingWaitAndContinueSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _waitAndContinueSpecification = value;
            }
        }
    }
}
