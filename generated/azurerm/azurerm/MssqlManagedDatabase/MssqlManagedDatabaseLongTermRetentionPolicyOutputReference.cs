using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    [JsiiClass(nativeType: typeof(azurerm.MssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicyOutputReference), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MssqlManagedDatabaseLongTermRetentionPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MssqlManagedDatabaseLongTermRetentionPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MssqlManagedDatabaseLongTermRetentionPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlManagedDatabaseLongTermRetentionPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMonthlyRetention")]
        public virtual void ResetMonthlyRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklyRetention")]
        public virtual void ResetWeeklyRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeekOfYear")]
        public virtual void ResetWeekOfYear()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetYearlyRetention")]
        public virtual void ResetYearlyRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlyRetentionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthlyRetentionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyRetentionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeeklyRetentionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weekOfYearInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WeekOfYearInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "yearlyRetentionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? YearlyRetentionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyRetention
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeeklyRetention
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WeekOfYear
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string YearlyRetention
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
