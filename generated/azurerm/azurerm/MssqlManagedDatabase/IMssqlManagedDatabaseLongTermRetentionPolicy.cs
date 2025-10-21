using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlManagedDatabaseLongTermRetentionPolicy), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy")]
    public interface IMssqlManagedDatabaseLongTermRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#monthly_retention MssqlManagedDatabase#monthly_retention}.</summary>
        [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthlyRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#weekly_retention MssqlManagedDatabase#weekly_retention}.</summary>
        [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeeklyRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#week_of_year MssqlManagedDatabase#week_of_year}.</summary>
        [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WeekOfYear
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#yearly_retention MssqlManagedDatabase#yearly_retention}.</summary>
        [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? YearlyRetention
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlManagedDatabaseLongTermRetentionPolicy), fullyQualifiedName: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#monthly_retention MssqlManagedDatabase#monthly_retention}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthlyRetention
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#weekly_retention MssqlManagedDatabase#weekly_retention}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeeklyRetention
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#week_of_year MssqlManagedDatabase#week_of_year}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WeekOfYear
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#yearly_retention MssqlManagedDatabase#yearly_retention}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? YearlyRetention
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
