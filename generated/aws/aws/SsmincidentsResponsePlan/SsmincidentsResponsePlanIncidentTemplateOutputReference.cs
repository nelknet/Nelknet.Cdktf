using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiClass(nativeType: typeof(aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateOutputReference), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmincidentsResponsePlanIncidentTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmincidentsResponsePlanIncidentTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmincidentsResponsePlanIncidentTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmincidentsResponsePlanIncidentTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNotificationTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNotificationTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDedupeString")]
        public virtual void ResetDedupeString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncidentTags")]
        public virtual void ResetIncidentTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationTarget")]
        public virtual void ResetNotificationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSummary")]
        public virtual void ResetSummary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "notificationTarget", typeJson: "{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTargetList\"}")]
        public virtual aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTargetList NotificationTarget
        {
            get => GetInstanceProperty<aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTargetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedupeStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedupeStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "impactInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ImpactInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "incidentTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? IncidentTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotificationTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "summaryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SummaryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dedupeString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedupeString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "impact", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Impact
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "incidentTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> IncidentTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplate\"}", isOptional: true)]
        public virtual aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
