using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiByValue(fqn: "azurerm.mssqlDatabase.MssqlDatabaseLongTermRetentionPolicy")]
    public class MssqlDatabaseLongTermRetentionPolicy : azurerm.MssqlDatabase.IMssqlDatabaseLongTermRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#monthly_retention MssqlDatabase#monthly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonthlyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#weekly_retention MssqlDatabase#weekly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#week_of_year MssqlDatabase#week_of_year}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeekOfYear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#yearly_retention MssqlDatabase#yearly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YearlyRetention
        {
            get;
            set;
        }
    }
}
