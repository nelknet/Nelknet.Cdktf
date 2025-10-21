using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedDatabase
{
    [JsiiByValue(fqn: "azurerm.mssqlManagedDatabase.MssqlManagedDatabaseLongTermRetentionPolicy")]
    public class MssqlManagedDatabaseLongTermRetentionPolicy : azurerm.MssqlManagedDatabase.IMssqlManagedDatabaseLongTermRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#monthly_retention MssqlManagedDatabase#monthly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonthlyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#weekly_retention MssqlManagedDatabase#weekly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#week_of_year MssqlManagedDatabase#week_of_year}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeekOfYear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_database#yearly_retention MssqlManagedDatabase#yearly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YearlyRetention
        {
            get;
            set;
        }
    }
}
