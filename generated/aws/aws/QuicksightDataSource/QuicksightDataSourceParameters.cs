using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceParameters")]
    public class QuicksightDataSourceParameters : aws.QuicksightDataSource.IQuicksightDataSourceParameters
    {
        /// <summary>amazon_elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
        {
            get;
            set;
        }

        /// <summary>athena block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#athena QuicksightDataSource#athena}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena? Athena
        {
            get;
            set;
        }

        /// <summary>aurora block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora QuicksightDataSource#aurora}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersAurora? Aurora
        {
            get;
            set;
        }

        /// <summary>aurora_postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
        {
            get;
            set;
        }

        /// <summary>aws_iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
        {
            get;
            set;
        }

        /// <summary>databricks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#databricks QuicksightDataSource#databricks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databricks", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersDatabricks\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersDatabricks? Databricks
        {
            get;
            set;
        }

        /// <summary>jira block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#jira QuicksightDataSource#jira}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersJira\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersJira? Jira
        {
            get;
            set;
        }

        /// <summary>maria_db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersMariaDb? MariaDb
        {
            get;
            set;
        }

        /// <summary>mysql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#mysql QuicksightDataSource#mysql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersMysql? Mysql
        {
            get;
            set;
        }

        /// <summary>oracle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#oracle QuicksightDataSource#oracle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersOracle? Oracle
        {
            get;
            set;
        }

        /// <summary>postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersPostgresql? Postgresql
        {
            get;
            set;
        }

        /// <summary>presto block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#presto QuicksightDataSource#presto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersPresto? Presto
        {
            get;
            set;
        }

        /// <summary>rds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#rds QuicksightDataSource#rds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRds\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersRds? Rds
        {
            get;
            set;
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#redshift QuicksightDataSource#redshift}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersRedshift? Redshift
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#s3 QuicksightDataSource#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersS3? S3
        {
            get;
            set;
        }

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#service_now QuicksightDataSource#service_now}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow? ServiceNow
        {
            get;
            set;
        }

        /// <summary>snowflake block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersSnowflake? Snowflake
        {
            get;
            set;
        }

        /// <summary>spark block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#spark QuicksightDataSource#spark}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersSpark? Spark
        {
            get;
            set;
        }

        /// <summary>sql_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersSqlServer? SqlServer
        {
            get;
            set;
        }

        /// <summary>teradata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#teradata QuicksightDataSource#teradata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersTeradata? Teradata
        {
            get;
            set;
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#twitter QuicksightDataSource#twitter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
        public aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter? Twitter
        {
            get;
            set;
        }
    }
}
