using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiClass(nativeType: typeof(aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceOutputReference), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SsmcontactsRotationRecurrenceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SsmcontactsRotationRecurrenceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmcontactsRotationRecurrenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmcontactsRotationRecurrenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDailySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDailySettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonthlySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMonthlySettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShiftCoverages", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutShiftCoverages(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeeklySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWeeklySettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDailySettings")]
        public virtual void ResetDailySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlySettings")]
        public virtual void ResetMonthlySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShiftCoverages")]
        public virtual void ResetShiftCoverages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklySettings")]
        public virtual void ResetWeeklySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dailySettings", typeJson: "{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettingsList\"}")]
        public virtual aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceDailySettingsList DailySettings
        {
            get => GetInstanceProperty<aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceDailySettingsList>()!;
        }

        [JsiiProperty(name: "monthlySettings", typeJson: "{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsList\"}")]
        public virtual aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsList MonthlySettings
        {
            get => GetInstanceProperty<aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsList>()!;
        }

        [JsiiProperty(name: "shiftCoverages", typeJson: "{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesList\"}")]
        public virtual aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesList ShiftCoverages
        {
            get => GetInstanceProperty<aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesList>()!;
        }

        [JsiiProperty(name: "weeklySettings", typeJson: "{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsList\"}")]
        public virtual aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsList WeeklySettings
        {
            get => GetInstanceProperty<aws.SsmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailySettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DailySettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlySettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MonthlySettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfOnCallsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfOnCallsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceMultiplierInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecurrenceMultiplierInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shiftCoveragesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ShiftCoveragesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklySettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WeeklySettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "numberOfOnCalls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfOnCalls
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recurrenceMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecurrenceMultiplier
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrence\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrence cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrence).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
