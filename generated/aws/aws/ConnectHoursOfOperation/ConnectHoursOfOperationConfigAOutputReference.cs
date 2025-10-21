using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectHoursOfOperation
{
    [JsiiClass(nativeType: typeof(aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigAOutputReference), fullyQualifiedName: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConnectHoursOfOperationConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ConnectHoursOfOperationConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ConnectHoursOfOperationConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectHoursOfOperationConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEndTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime\"}}]")]
        public virtual void PutEndTime(aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStartTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime\"}}]")]
        public virtual void PutStartTime(aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime)}, new object[]{@value});
        }

        [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTimeOutputReference\"}")]
        public virtual aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigEndTimeOutputReference EndTime
        {
            get => GetInstanceProperty<aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigEndTimeOutputReference>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTimeOutputReference\"}")]
        public virtual aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigStartTimeOutputReference StartTime
        {
            get => GetInstanceProperty<aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigStartTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endTimeInput", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime\"}", isOptional: true)]
        public virtual aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime? EndTimeInput
        {
            get => GetInstanceProperty<aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startTimeInput", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime\"}", isOptional: true)]
        public virtual aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime? StartTimeInput
        {
            get => GetInstanceProperty<aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime?>();
        }

        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Day
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigA\"}]}}", isOptional: true)]
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
                        case aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigA cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigA).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
